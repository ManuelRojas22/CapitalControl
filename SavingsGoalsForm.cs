using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapitalControl.Models;
using CapitalControl.Services;

namespace CapitalControl
{
    public partial class SavingsGoalsForm : Form
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

        public SavingsGoalsForm()
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

            this.Load += SavingsGoalsForm_Load;
            this.Resize += SavingsGoalsForm_Resize;

            WireEvents();
            Refresh();
        }

        private void SavingsGoalsForm_Load(object sender, EventArgs e)
        {
            _layoutReady = true;
            PerformResponsiveLayout();
        }

        private void SavingsGoalsForm_Resize(object sender, EventArgs e)
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

                // Title / subtitle + Add button
                currentTop = LayoutTitleBlock(contentW, 0, isMobile);

                // Summary cards (4)
                currentTop = LayoutSummaryCards(contentW, currentTop, isDesktop, false, isMobile);

                // Goals card (grid)
                currentTop = LayoutGoalsCard(contentW, currentTop);

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
            lblTitle.Top = 0;

            lblSubtitle.Width = contentW;
            lblSubtitle.Left = LayoutMargin;
            lblSubtitle.Top = lblTitle.Bottom + 8;

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
                btnAdd.Top = 0;
                return Math.Max(lblSubtitle.Bottom, btnAdd.Bottom) + LayoutMargin;
            }
        }

        private int LayoutSummaryCards(int contentW, int top, bool desktop, bool tablet, bool mobile)
        {
            var cards = new[]
            {
                pnlSummaryTarget,
                pnlSummaryCurrent,
                pnlSummaryRemaining,
                pnlSummaryCount
            };

            int colsActual = mobile ? 1 : (this.ClientSize.Width >= TabletBreak && this.ClientSize.Width < DesktopBreak ? 2 : 4);
            int colsActualDesktop = 4;
            int colsActualTablet = 2;
            int colsActualMobile = 1;
            int cols = (this.ClientSize.Width >= DesktopBreak) ? 4 : (this.ClientSize.Width >= TabletBreak ? 2 : 1);

            int cardW = (contentW - (cols - 1) * ColGap) / cols;
            int cardH = 90;
            int startX = LayoutMargin;

            for (int i = 0; i < 4; i++)
            {
                int row = mobile ? i : (this.ClientSize.Width >= TabletBreak && this.ClientSize.Width < DesktopBreak ? i / 2 : 0);
                int col = mobile ? 0 : (this.ClientSize.Width >= TabletBreak && this.ClientSize.Width < DesktopBreak ? i % 2 : i);
                int x = LayoutMargin + col * (cardW + ColGap);
                int y = top + row * (90 + ColGap);

                var c = new[] { pnlSummaryTarget, pnlSummaryCurrent, pnlSummaryRemaining, pnlSummaryCount }[i];
                c.Left = x;
                c.Top = y;
                c.Width = cardW;
                c.Height = 90;
            }

            int rows = mobile ? 4 : (this.ClientSize.Width >= TabletBreak && this.ClientSize.Width < DesktopBreak ? 2 : 1);
            return top + rows * (90 + ColGap);
        }

        private int LayoutGoalsCard(int contentW, int top)
        {
            pnlGoalsCard.Width = contentW;
            pnlGoalsCard.Left = LayoutMargin;
            pnlGoalsCard.Top = top + LayoutMargin;

            gridGoals.Dock = DockStyle.Fill;
            lblEmpty.Dock = DockStyle.Fill;

            int cardH = Math.Max(360, this.ClientSize.Height - pnlGoalsCard.Top - LayoutMargin);
            pnlGoalsCard.Height = cardH;

            return pnlGoalsCard.Bottom;
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
            btnNavBack.Click += (s, e) => Raise("landing");

            btnAdd.Click += BtnAdd_Click;
            gridGoals.CellClick += GridGoals_CellClick;
        }

        private new void Refresh()
        {
            decimal totalTarget = AppData.Goals.Sum(g => g.Target);
            decimal totalCurrent = AppData.Goals.Sum(g => g.Current);
            decimal totalRemaining = totalTarget - totalCurrent;

            lblSummaryTargetValue.Text = Fmt.Money(totalTarget);
            lblSummaryCurrentValue.Text = Fmt.Money(totalCurrent);
            lblSummaryRemainingValue.Text = Fmt.Money(totalRemaining);
            lblSummaryCountValue.Text = AppData.Goals.Count.ToString();

            FillGrid();
        }

        private void FillGrid()
        {
            gridGoals.Rows.Clear();

            foreach (SavingsGoal g in AppData.Goals)
            {
                int rowIndex = gridGoals.Rows.Add(
                    g.Name,
                    g.Category,
                    g.ProgressLabel,
                    g.TargetLabel,
                    g.CurrentLabel,
                    g.RemainingLabel,
                    g.TargetDateLabel,
                    g.MonthlyLabel,
                    "Abonar / Editar");

                DataGridViewRow row = gridGoals.Rows[rowIndex];
                row.Tag = g;

                System.Drawing.Color progressColor = g.Progress >= 75
                    ? System.Drawing.Color.FromArgb(34, 197, 94)
                    : (g.Progress >= 50
                        ? System.Drawing.Color.FromArgb(234, 179, 8)
                        : System.Drawing.Color.FromArgb(239, 68, 68));

                row.Cells["colProgress"].Style.ForeColor = progressColor;

                if (g.DaysRemaining < 90)
                {
                    row.Cells["colTargetDate"].Style.ForeColor = System.Drawing.Color.FromArgb(234, 179, 8);
                }
            }

            lblEmpty.Visible = AppData.Goals.Count == 0;
            gridGoals.Visible = AppData.Goals.Count > 0;
        }

        private void GridGoals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (gridGoals.Columns[e.ColumnIndex].Name != "colAction") return;

            SavingsGoal g = gridGoals.Rows[e.RowIndex].Tag as SavingsGoal;
            if (g == null) return;

            ShowGoalActionsMenu(g);
        }

        private void ShowGoalActionsMenu(SavingsGoal g)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Abonar", null, (s, e) => ContributeToGoal(g));
            menu.Items.Add("Editar", null, (s, e) => EditGoal(g));
            menu.Items.Add("Eliminar", null, (s, e) => DeleteGoal(g));
            menu.Show(Cursor.Position);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (GoalEditForm dlg = new GoalEditForm("", "", 0, 0, DateTime.Today.AddYears(1), "blue"))
            {
                dlg.Text = "Nueva Meta";
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                AppData.Goals.Insert(0, new SavingsGoal
                {
                    Name = dlg.GoalName,
                    Category = dlg.GoalCategory,
                    Target = dlg.GoalTarget,
                    Current = Math.Min(dlg.GoalTarget, dlg.GoalCurrent),
                    TargetDate = dlg.GoalTargetDate.ToString("yyyy-MM-dd"),
                    ColorKey = dlg.GoalColorKey
                });

                Refresh();
            }
        }

        private void EditGoal(SavingsGoal g)
        {
            using (GoalEditForm dlg = new GoalEditForm(g.Name, g.Category, g.Target, g.Current, DateTime.TryParse(g.TargetDate, out DateTime dt) ? dt : DateTime.Today, g.ColorKey))
            {
                dlg.Text = "Editar Meta";
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                g.Name = dlg.GoalName;
                g.Category = dlg.GoalCategory;
                g.Target = dlg.GoalTarget;
                g.Current = Math.Min(dlg.GoalTarget, dlg.GoalCurrent);
                g.TargetDate = dlg.GoalTargetDate.ToString("yyyy-MM-dd");
                g.ColorKey = dlg.GoalColorKey;
                g.RaiseAll();

                Refresh();
            }
        }

        private void ContributeToGoal(SavingsGoal g)
        {
            using (ContributeGoalForm dlg = new ContributeGoalForm(g.Name, g.RemainingLabel))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                decimal amount = dlg.ContributionAmount;
                g.Current = Math.Min(g.Target, g.Current + amount);
                g.RaiseAll();

                AppData.Transactions.Insert(0, new Transaction
                {
                    Date = DateTime.Today,
                    Type = TxType.Gasto,
                    Category = "Otros",
                    Description = "Abono meta: " + g.Name,
                    Amount = amount
                });

                Refresh();
            }
        }

        private void DeleteGoal(SavingsGoal g)
        {
            DialogResult r = MessageBox.Show(
                this,
                "Deseas eliminar la meta \"" + g.Name + "\"?",
                "Eliminar meta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r != DialogResult.Yes) return;

            AppData.Goals.Remove(g);
            Refresh();
        }

        private void Raise(string target)
        {
            EventHandler<string> handler = NavigateRequested;
            if (handler != null) handler(this, target);
        }
    }
}