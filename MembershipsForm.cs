using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CapitalControl.Models;
using CapitalControl.Services;

namespace CapitalControl
{
    public partial class MembershipsForm : Form
    {
        public event EventHandler<string> NavigateRequested;

        private bool _layoutReady = false;

        // Responsive constants (matching DashboardForm)
        private const int LayoutMargin = 24;
        private const int ColGap = 18;
        private const int DesktopBreak = 1300;
        private const int TabletBreak = 900;
        private const int SidebarExpanded = 260;
        private const int SidebarCollapsed = 64;

        public MembershipsForm()
        {
            InitializeComponent();

            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                WireEvents();
                Refresh();
                return;
            }

            this.MinimumSize = new Size(520, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            pnlRoot.Dock = DockStyle.Fill;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.AutoScroll = true;

            ApplyEmojiFallbackFont();
            StoreOriginalSidebarTexts();

            this.Load += MembershipsForm_Load;
            this.Resize += MembershipsForm_Resize;
            // Recargar la tabla cada vez que se muestra (los datos llegan después del login)
            this.VisibleChanged += (s, e) => { if (Visible) Refresh(); };

            WireEvents();
            Refresh();
        }

        private void MembershipsForm_Load(object sender, EventArgs e)
        {
            _layoutReady = true;
            PerformResponsiveLayout();
        }

        private void MembershipsForm_Resize(object sender, EventArgs e)
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

                // Title / subtitle + add button
                currentTop = LayoutTitleBlock(contentW, currentTop, isMobile);

                // Summary cards
                currentTop = LayoutSummaryCards(contentW, currentTop, isDesktop, isTablet, isMobile);

                // Projection panel
                currentTop = LayoutProjection(contentW, currentTop, isDesktop, isTablet, isMobile);

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

        private int LayoutTitleBlock(int contentW, int top, bool mobile)
        {
            lblTitle.Width = contentW;
            lblTitle.Left = LayoutMargin;
            lblTitle.Top = top;

            lblSubtitle.Width = contentW;
            lblSubtitle.Left = LayoutMargin;
            lblSubtitle.Top = lblTitle.Bottom + 8;

            // Add button
            if (mobile)
            {
                btnAdd.Width = contentW;
                btnAdd.Left = LayoutMargin;
                btnAdd.Top = lblSubtitle.Bottom + 12;
                return btnAdd.Bottom + LayoutMargin;
            }
            else
            {
                btnAdd.Width = 180;
                btnAdd.Left = LayoutMargin + contentW - btnAdd.Width;
                btnAdd.Top = top; // align with title top
                return Math.Max(lblSubtitle.Bottom, btnAdd.Bottom) + LayoutMargin;
            }
        }

        private int LayoutSummaryCards(int contentW, int top, bool desktop, bool tablet, bool mobile)
        {
            var cards = new[] { pnlSummaryActive, pnlSummaryMonthly, pnlSummaryAnnual };
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

        private int LayoutProjection(int contentW, int top, bool desktop, bool tablet, bool mobile)
        {
            pnlProjection.Width = contentW;
            pnlProjection.Left = LayoutMargin;
            pnlProjection.Top = top + LayoutMargin;

            var pairs = new[]
            {
                new { Title = lblProjMonthlyTitle, Value = lblProjMonthlyValue },
                new { Title = lblProjQuarterlyTitle, Value = lblProjQuarterlyValue },
                new { Title = lblProjSemiannualTitle, Value = lblProjSemiannualValue },
                new { Title = lblProjAnnualTitle, Value = lblProjAnnualValue }
            };

            int cols = desktop ? 4 : (tablet ? 2 : 1);
            int gap = ColGap;
            int itemW = (contentW - (cols - 1) * gap) / cols;
            int startX = LayoutMargin;
            int y = 20; // internal top padding inside pnlProjection

            for (int i = 0; i < pairs.Length; i++)
            {
                int row = mobile ? i : (tablet ? i / 2 : 0);
                int col = mobile ? 0 : (tablet ? i % 2 : i);
                int x = startX + col * (itemW + gap);
                int itemY = y + row * (60 + 8); // each pair ~60 height

                var p = pairs[i];
                p.Title.Left = x;
                p.Title.Top = itemY;
                p.Title.Width = itemW;
                p.Value.Left = x;
                p.Value.Top = itemY + 24;
                p.Value.Width = itemW;
            }

            int rows = mobile ? 4 : (tablet ? 2 : 1);
            int panelH = y + rows * (60 + 8) + 20;
            pnlProjection.Height = panelH;

            return pnlProjection.Bottom;
        }

        private int LayoutListCard(int contentW, int top)
        {
            pnlListCard.Width = contentW;
            pnlListCard.Left = LayoutMargin;
            pnlListCard.Top = top + LayoutMargin;

            gridMemberships.Dock = DockStyle.Fill;
            lblEmptyBox.Dock = DockStyle.Fill;

            int cardH = Math.Max(360, this.ClientSize.Height - pnlListCard.Top - LayoutMargin);
            pnlListCard.Height = cardH;

            return pnlListCard.Bottom;
        }

        // ---------- Sidebar ----------
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
                btnNavMemberships, btnNavDebts, btnNavGoals, btnNavBack,
                btnAdd
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
            btnAdd.Click += BtnAdd_Click;
            gridMemberships.CellClick += GridMemberships_CellClick;
        }

        private new void Refresh()
        {
            var active = AppData.Subscriptions.Where(s => s.IsActive).ToList();
            decimal monthly = active.Sum(s => s.Cost);

            lblSummaryActiveValue.Text = active.Count.ToString();
            lblSummaryMonthlyValue.Text = Fmt.Money(monthly);
            lblSummaryAnnualValue.Text = Fmt.Money(monthly * 12);

            lblProjMonthlyValue.Text = Fmt.Money(monthly);
            lblProjQuarterlyValue.Text = Fmt.Money(monthly * 3);
            lblProjSemiannualValue.Text = Fmt.Money(monthly * 6);
            lblProjAnnualValue.Text = Fmt.Money(monthly * 12);

            FillGrid();
        }

        private void FillGrid()
        {
            gridMemberships.Rows.Clear();

            foreach (Subscription s in AppData.Subscriptions)
            {
                int rowIndex = gridMemberships.Rows.Add(
                    s.Logo,
                    s.Name,
                    s.CostLabel,
                    s.BillingLabel,
                    s.StatusLabel,
                    s.IsActive ? "Editar / Cancelar" : "Reactivar");

                DataGridViewRow row = gridMemberships.Rows[rowIndex];
                row.Tag = s;

                row.Cells["colStatus"].Style.ForeColor = s.IsActive
                    ? System.Drawing.Color.FromArgb(34, 197, 94)
                    : System.Drawing.Color.FromArgb(133, 133, 133);

                if (!s.IsActive)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
                    }
                }
            }

            lblEmptyBox.Visible = AppData.Subscriptions.Count == 0;
            gridMemberships.Visible = AppData.Subscriptions.Count > 0;
        }

        private void GridMemberships_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (gridMemberships.Columns[e.ColumnIndex].Name != "colAction") return;

            Subscription s = gridMemberships.Rows[e.RowIndex].Tag as Subscription;
            if (s == null) return;

            if (s.IsActive)
            {
                ShowMemberActionsMenu(s);
            }
            else
            {
                s.IsActive = true;
                BaseDatos.ActualizarMembresia(s);
                Refresh();
            }
        }

        private void ShowMemberActionsMenu(Subscription s)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Editar", null, (s2, e2) => EditMembership(s));
            menu.Items.Add("Cancelar suscripcion", null, (s2, e2) => CancelMembership(s));
            menu.Show(Cursor.Position);
        }

        private void EditMembership(Subscription s)
        {
            using (MembershipEditForm dlg = new MembershipEditForm(s.Name, s.Cost, s.BillingDay, s.Logo))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                s.Name = dlg.MembershipName;
                s.Cost = dlg.MembershipCost;
                s.BillingDay = dlg.MembershipBillingDay;
                if (!string.IsNullOrWhiteSpace(dlg.MembershipLogo)) s.Logo = dlg.MembershipLogo;
                BaseDatos.ActualizarMembresia(s);
                Refresh();
            }
        }

        private void CancelMembership(Subscription s)
        {
            DialogResult r = MessageBox.Show(
                this,
                "Deseas cancelar la suscripcion a " + s.Name + "?",
                "Cancelar suscripcion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r != DialogResult.Yes) return;

            s.IsActive = false;
            BaseDatos.ActualizarMembresia(s);
            Refresh();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (MembershipEditForm dlg = new MembershipEditForm("", 0, 1, "\U0001F4B3"))
            {
                dlg.Text = "Nueva Membresia";
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                BaseDatos.InsertarMembresia(new Subscription
                {
                    Name = dlg.MembershipName,
                    Cost = dlg.MembershipCost,
                    BillingDay = dlg.MembershipBillingDay,
                    Logo = string.IsNullOrWhiteSpace(dlg.MembershipLogo) ? "\U0001F4B3" : dlg.MembershipLogo,
                    IsActive = true
                });

                Refresh();
            }
        }

        private void Raise(string target)
        {
            EventHandler<string> handler = NavigateRequested;
            if (handler != null) handler(this, target);
        }
    }
}