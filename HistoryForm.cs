using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapitalControl.Models;
using CapitalControl.Services;

namespace CapitalControl
{
    public partial class HistoryForm : Form
    {
        public event EventHandler<string> NavigateRequested;

        private bool _ready;
        private bool _layoutReady = false;

        // Responsive constants (matching DashboardForm)
        private const int LayoutMargin = 24;
        private const int ColGap = 18;
        private const int DesktopBreak = 1300;
        private const int TabletBreak = 900;
        private const int SidebarExpanded = 260;
        private const int SidebarCollapsed = 64;

        public HistoryForm()
        {
            InitializeComponent();

            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                WireEvents();
                BuildFilters();
                _ready = true;
                ApplyFilters();
                return;
            }

            this.MinimumSize = new Size(520, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            pnlRoot.Dock = DockStyle.Fill;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.AutoScroll = true;

            ApplyEmojiFallbackFont();
            StoreOriginalSidebarTexts();

            this.Load += HistoryForm_Load;
            this.Resize += HistoryForm_Resize;

            WireEvents();
            BuildFilters();
            _ready = true;
            ApplyFilters();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            _layoutReady = true;
            PerformResponsiveLayout();
        }

        private void HistoryForm_Resize(object sender, EventArgs e)
        {
            if (_layoutReady) PerformResponsiveLayout();
        }

        private void PerformResponsiveLayout()
        {
            pnlMain.SuspendLayout();
            pnlSidebar.SuspendLayout();
            try
            {
                int totalW = this.ClientSize.Width;
                bool isMobile = totalW < TabletBreak;
                bool isTablet = totalW >= TabletBreak && totalW < DesktopBreak;
                bool isDesktop = totalW >= DesktopBreak;

                LayoutSidebar(isMobile);
                int sidebarW = isMobile ? SidebarCollapsed : SidebarExpanded;

                int contentW = totalW - sidebarW - 2 * LayoutMargin;
                if (contentW < 300) contentW = 300;

                int currentTop = 0;

                // Title / subtitle
                currentTop = LayoutTitleBlock(contentW, currentTop);

                // Summary cards
                currentTop = LayoutSummaryCards(contentW, currentTop, isDesktop, isTablet, isMobile);

                // Filters
                currentTop = LayoutFilters(contentW, currentTop, isDesktop, isTablet, isMobile);

                // List card (grid)
                currentTop = LayoutListCard(contentW, currentTop);

                pnlMain.AutoScrollMinSize = new Size(0, currentTop + LayoutMargin);
            }
            finally
            {
                pnlSidebar.ResumeLayout();
                pnlMain.ResumeLayout();
            }
        }

        private int LayoutTitleBlock(int contentW, int top)
        {
            lblTitle.Width = contentW;
            lblTitle.Left = LayoutMargin;
            lblTitle.Top = top;

            lblSubtitle.Width = contentW;
            lblSubtitle.Left = LayoutMargin;
            lblSubtitle.Top = lblTitle.Bottom + 8;

            return lblSubtitle.Bottom;
        }

        private int LayoutSummaryCards(int contentW, int top, bool desktop, bool tablet, bool mobile)
        {
            var cards = new[] { pnlSummaryIncome, pnlSummaryExpenses, pnlSummaryCount };
            int cols = desktop ? 3 : (tablet ? 2 : 1);
            int cardW = (contentW - (cols - 1) * ColGap) / cols;
            int cardH = 90;
            int startX = LayoutMargin;

            for (int i = 0; i < cards.Length; i++)
            {
                int row = mobile ? i : (tablet ? i / 2 : 0);
                int col = mobile ? 0 : (tablet ? i % 2 : i);
                int x = startX + col * (cardW + ColGap);
                int y = top + row * (cardH + ColGap);

                var c = cards[i];
                c.Left = x;
                c.Top = y;
                c.Width = cardW;
                c.Height = cardH;
            }

            int rows = mobile ? 3 : (tablet ? 2 : 1);
            return top + rows * (cardH + ColGap);
        }

        private int LayoutFilters(int contentW, int top, bool desktop, bool tablet, bool mobile)
        {
            pnlFilters.Width = contentW;
            pnlFilters.Left = LayoutMargin;
            pnlFilters.Top = top + LayoutMargin;

            int comboFixedW = 200; // fixed width for type and category combos
            int colGap = 12;

            if (desktop || tablet)
            {
                // Three columns side by side: Search (flex), Type (fixed), Category (fixed)
                int comboW = comboFixedW;
                int fixedColsWidth = 2 * comboW + 2 * colGap; // two combos + gaps between columns
                int searchW = contentW - 2 * LayoutMargin - fixedColsWidth;
                if (searchW < 200) searchW = 200; // minimum

                // Column 1: Search
                int col1X = LayoutMargin;
                lblSearchLabel.Left = col1X;
                lblSearchLabel.Top = 10;
                lblSearchLabel.Width = Math.Min(searchW, 300);
                txtSearch.Left = col1X;
                txtSearch.Top = 28;
                txtSearch.Width = Math.Max(200, contentW - 2 * LayoutMargin - 2 * (comboW + colGap));

                // Column 2: Type
                int col2X = col1X + txtSearch.Width + colGap;
                lblTypeFilterLabel.Left = col2X;
                lblTypeFilterLabel.Top = 10;
                cmbTypeFilter.Left = col2X;
                cmbTypeFilter.Top = 28;
                cmbTypeFilter.Width = comboFixedW;

                // Column 3: Category
                int col3X = col2X + comboFixedW + colGap;
                lblCategoryFilterLabel.Left = col3X;
                lblCategoryFilterLabel.Top = 10;
                cmbCategoryFilter.Left = col3X;
                cmbCategoryFilter.Top = 28;
                cmbCategoryFilter.Width = comboFixedW;

                // Height of panel = labels + controls + padding
                pnlFilters.Height = 10 + 18 + 30 + 12; // ~70
            }
            else
            {
                // Mobile: stack vertically, each control full width
                int y = 10;

                lblSearchLabel.Left = LayoutMargin; lblSearchLabel.Top = y;
                txtSearch.Left = LayoutMargin; txtSearch.Top = lblSearchLabel.Bottom + 4; txtSearch.Width = contentW - 2 * LayoutMargin;
                y = txtSearch.Bottom + 12;

                lblTypeFilterLabel.Left = LayoutMargin; lblTypeFilterLabel.Top = y;
                cmbTypeFilter.Left = LayoutMargin; cmbTypeFilter.Top = lblTypeFilterLabel.Bottom + 4; cmbTypeFilter.Width = contentW - 2 * LayoutMargin;
                y = cmbTypeFilter.Bottom + 12;

                lblCategoryFilterLabel.Left = LayoutMargin; lblCategoryFilterLabel.Top = y;
                cmbCategoryFilter.Left = LayoutMargin; cmbCategoryFilter.Top = lblCategoryFilterLabel.Bottom + 4; cmbCategoryFilter.Width = contentW - 2 * LayoutMargin;
                y = cmbCategoryFilter.Bottom + 12;

                pnlFilters.Height = y;
            }

            pnlFilters.Width = contentW;
            pnlFilters.Left = LayoutMargin;
            pnlFilters.Top = top + LayoutMargin;

            return pnlFilters.Bottom;
        }

        private int LayoutListCard(int contentW, int top)
        {
            pnlListCard.Width = contentW;
            pnlListCard.Left = LayoutMargin;
            pnlListCard.Top = top + LayoutMargin;

            // grid inside fills the card
            gridTransactions.Dock = DockStyle.Fill;
            lblEmptyBox.Dock = DockStyle.Fill;

            int cardH = Math.Max(360, this.ClientSize.Height - pnlListCard.Top - LayoutMargin);
            pnlListCard.Height = cardH;

            return pnlListCard.Bottom;
        }

        // ---------- Sidebar (copied from DashboardForm) ----------
        private void StoreOriginalSidebarTexts()
        {
            var btns = new[] { btnNavDashboard, btnNavTransaction, btnNavHistory,
                               btnNavMemberships, btnNavDebts, btnNavGoals };
            foreach (var b in btns) if (b.Tag == null) b.Tag = b.Text;
        }

        private void ApplyEmojiFallbackFont()
        {
            string fontName = "Segoe UI";
            using (var installed = new System.Drawing.Text.InstalledFontCollection())
            {
                var names = installed.Families.Select(f => f.Name).ToArray();
                if (names.Contains("Segoe UI Emoji")) fontName = "Segoe UI Emoji";
                else if (names.Contains("Segoe UI Symbol")) fontName = "Segoe UI Symbol";
            }

            var controls = new Control[]
            {
                btnNavDashboard, btnNavTransaction, btnNavHistory,
                btnNavMemberships, btnNavDebts, btnNavGoals, btnNavBack
            };

            foreach (var c in controls) if (c != null) c.Font = new Font(fontName, c.Font.Size, c.Font.Style);
        }

        private void LayoutSidebar(bool mobile)
        {
            int w = mobile ? SidebarCollapsed : SidebarExpanded;
            pnlSidebar.Width = w;
            pnlSidebar.Height = this.ClientSize.Height;

            if (pnlSidebar.BackColor == Color.Transparent)
                pnlSidebar.BackColor = Color.FromArgb(37, 37, 38);

            lblSidebarLogo.Visible = !mobile;
            lblSidebarSubtitle.Visible = !mobile;

            var btns = new[] { btnNavDashboard, btnNavTransaction, btnNavHistory,
                               btnNavMemberships, btnNavDebts, btnNavGoals };

            int startTop = 106;
            int backBtnHeight = 40;
            int bottomMargin = 12;
            int gapAboveBack = 12;

            int availableH = pnlSidebar.ClientSize.Height - startTop
                             - backBtnHeight - bottomMargin - gapAboveBack;

            const int idealBtnH = 48;
            const int idealGap = 6;
            int idealPerBtn = idealBtnH + idealGap;
            int neededH = btns.Length * idealPerBtn;

            int btnH, gap;
            bool needsScroll = false;

            if (availableH >= neededH)
            {
                btnH = idealBtnH;
                gap = idealGap;
            }
            else
            {
                float scale = Math.Max(0.6f, (float)availableH / neededH);
                btnH = Math.Max(30, (int)(idealBtnH * scale));
                gap = Math.Max(2, (int)(idealGap * scale));
                int scaledNeeded = btns.Length * (btnH + gap);
                needsScroll = scaledNeeded > availableH;
            }

            pnlSidebar.AutoScroll = needsScroll;

            int btnW = w - 24 - (needsScroll ? 16 : 0);
            int left = 12;
            int top = startTop;
            foreach (var b in btns)
            {
                b.Width = btnW;
                b.Left = left;
                b.Top = top;
                b.Height = btnH;
                b.Visible = true;

                if (mobile)
                {
                    string original = b.Tag?.ToString() ?? b.Text;
                    string emoji = original.Split(' ')[0];
                    b.Text = emoji;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    b.Text = b.Tag?.ToString() ?? b.Text;
                    b.TextAlign = ContentAlignment.MiddleLeft;
                }
                top += b.Height + gap;
            }

            btnNavBack.Left = left;
            btnNavBack.Width = btnW;
            btnNavBack.Visible = true;
            if (needsScroll)
                btnNavBack.Top = top + 12;
            else
                btnNavBack.Top = pnlSidebar.ClientSize.Height - btnNavBack.Height - 12;
        }

        // Existing logic
        private void WireEvents()
        {
            btnNavDashboard.Click += (s, e) => Raise("dashboard");
            btnNavTransaction.Click += (s, e) => Raise("transaction");
            btnNavHistory.Click += (s, e) => Raise("history");
            btnNavMemberships.Click += (s, e) => Raise("memberships");
            btnNavDebts.Click += (s, e) => Raise("debts");
            btnNavGoals.Click += (s, e) => Raise("goals");
            btnNavBack.Click += (s, e) => Raise("landing");

            txtSearch.TextChanged += (s, e) => ApplyFilters();
            cmbTypeFilter.SelectedIndexChanged += (s, e) => ApplyFilters();
            cmbCategoryFilter.SelectedIndexChanged += (s, e) => ApplyFilters();
        }

        private void BuildFilters()
        {
            cmbTypeFilter.Items.Clear();
            cmbTypeFilter.Items.Add("Todos los tipos");
            cmbTypeFilter.Items.Add("Ingreso");
            cmbTypeFilter.Items.Add("Gasto");
            cmbTypeFilter.Items.Add("Inversion");
            cmbTypeFilter.SelectedIndex = 0;

            cmbCategoryFilter.Items.Clear();
            cmbCategoryFilter.Items.Add("Todas las categorias");
            foreach (string c in AppData.Transactions.Select(t => t.Category).Distinct().OrderBy(c => c))
                cmbCategoryFilter.Items.Add(c);
            cmbCategoryFilter.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            if (!_ready) return;

            string search = (txtSearch.Text ?? "").Trim().ToLowerInvariant();
            string type = cmbTypeFilter.SelectedItem as string ?? "Todos los tipos";
            string category = cmbCategoryFilter.SelectedItem as string ?? "Todas las categorias";

            var list = AppData.Transactions.Where(t =>
            {
                bool matchesSearch = string.IsNullOrEmpty(search)
                                     || t.Description.ToLowerInvariant().Contains(search)
                                     || t.Category.ToLowerInvariant().Contains(search);
                bool matchesType = type == "Todos los tipos" || t.Type.ToString() == type;
                bool matchesCategory = category == "Todas las categorias" || t.Category == category;
                return matchesSearch && matchesType && matchesCategory;
            })
            .OrderByDescending(t => t.Date)
            .ToList();

            FillGrid(list);

            lblEmptyBox.Visible = list.Count == 0;
            gridTransactions.Visible = list.Count > 0;

            decimal income = list.Where(t => t.Type == TxType.Ingreso).Sum(t => t.Amount);
            decimal expenses = list.Where(t => t.Type == TxType.Gasto).Sum(t => t.Amount);

            lblSummaryIncomeValue.Text = Fmt.Money(income);
            lblSummaryExpensesValue.Text = Fmt.Money(expenses);
            lblSummaryCountValue.Text = list.Count.ToString();
        }

        private void FillGrid(System.Collections.Generic.List<Transaction> list)
        {
            gridTransactions.Rows.Clear();

            foreach (Transaction t in list)
            {
                int rowIndex = gridTransactions.Rows.Add(
                    t.DateLabel,
                    t.TypeIcon + " " + t.TypeLabel,
                    t.Description,
                    t.Category,
                    t.AmountLabel);

                DataGridViewRow row = gridTransactions.Rows[rowIndex];

                Color typeColor;
                if (t.Type == TxType.Ingreso) typeColor = Color.FromArgb(34, 197, 94);
                else if (t.Type == TxType.Gasto) typeColor = Color.FromArgb(239, 68, 68);
                else typeColor = Color.FromArgb(55, 148, 255);

                row.Cells["colType"].Style.ForeColor = typeColor;
                row.Cells["colAmount"].Style.ForeColor = typeColor;
                row.Cells["colAmount"].Style.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            }
        }

        private void Raise(string target)
        {
            EventHandler<string> handler = NavigateRequested;
            if (handler != null) handler(this, target);
        }
    }
}