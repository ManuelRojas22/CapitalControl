using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CapitalControl.Models;
using CapitalControl.Services;

namespace CapitalControl
{
    public partial class DebtsCreditsForm : Form
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

        public DebtsCreditsForm()
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

            this.Load += DebtsCreditsForm_Load;
            this.Resize += DebtsCreditsForm_Resize;
            // Recargar la tabla cada vez que se muestra (los datos llegan después del login)
            this.VisibleChanged += (s, e) => { if (Visible) Refresh(); };

            WireEvents();
            Refresh();
        }

        private void DebtsCreditsForm_Load(object sender, EventArgs e)
        {
            _layoutReady = true;
            PerformResponsiveLayout();
        }

        private void DebtsCreditsForm_Resize(object sender, EventArgs e)
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
                currentTop = LayoutSummaryCards(contentW, currentTop, true, false, false);

                // Bank section
                currentTop = LayoutBankSection(contentW, currentTop);

                // Personal section
                currentTop = LayoutPersonalSection(contentW, currentTop);

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
                pnlSummaryTotal,
                pnlSummaryPaid,
                pnlSummaryPending,
                pnlSummaryCount
            };

            int cols = 4;
            if (mobile) cols = 1;
            else if (TabletBreak <= 900) cols = 2; // tablet 2x2

            int colsActual = desktop ? 4 : (tablet ? 2 : 1);
            int cardW = (contentW - (colsActual - 1) * ColGap) / colsActual;
            int cardH = 90;
            int startX = LayoutMargin;

            for (int i = 0; i < 4; i++)
            {
                int row = mobile ? i : (tablet ? i / 2 : 0);
                int col = mobile ? 0 : (tablet ? i % 2 : i);
                int x = LayoutMargin + col * (cardW + ColGap);
                int y = top + row * (90 + ColGap);

                var c = new[] { pnlSummaryTotal, pnlSummaryPaid, pnlSummaryPending, pnlSummaryCount }[i];
                c.Left = x;
                c.Top = y;
                c.Width = cardW;
                c.Height = 90;
            }

            int rows = mobile ? 4 : (tablet ? 2 : 1);
            return top + rows * (90 + ColGap);
        }

        private int LayoutBankSection(int contentW, int top)
        {
            // Title + count chip
            lblBankTitle.Width = contentW;
            lblBankTitle.Left = LayoutMargin;
            lblBankTitle.Top = top + LayoutMargin;

            lblBankCountChip.Left = lblBankTitle.Right + 12;
            lblBankCountChip.Top = lblBankTitle.Top + (lblBankTitle.Height - lblBankCountChip.Height) / 2;

            // Card
            int cardTop = lblBankTitle.Bottom + 8;
            pnlBankCard.Width = contentW;
            pnlBankCard.Left = LayoutMargin;
            pnlBankCard.Top = lblBankTitle.Bottom + 8;
            pnlBankCard.Height = 230;

            gridBank.Dock = DockStyle.Fill;
            lblBankEmpty.Dock = DockStyle.Fill;

            int bottom = pnlBankCard.Bottom + LayoutMargin;
            return bottom;
        }

        private int LayoutPersonalSection(int contentW, int top)
        {
            lblPersonalTitle.Width = contentW;
            lblPersonalTitle.Left = LayoutMargin;
            lblPersonalTitle.Top = top + LayoutMargin;

            lblPersonalCountChip.Left = lblPersonalTitle.Right + 12;
            lblPersonalCountChip.Top = lblPersonalTitle.Top + (lblPersonalTitle.Height - lblPersonalCountChip.Height) / 2;

            int cardTop = lblPersonalTitle.Bottom + 8;
            pnlPersonalCard.Width = contentW;
            pnlPersonalCard.Left = LayoutMargin;
            pnlPersonalCard.Top = lblPersonalTitle.Bottom + 8;
            pnlPersonalCard.Height = 230;

            gridPersonal.Dock = DockStyle.Fill;
            lblPersonalEmpty.Dock = DockStyle.Fill;

            return pnlPersonalCard.Bottom + LayoutMargin;
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
                needsScroll = btns.Length * (btnH + gap) > availableH;
            }

            pnlSidebar.AutoScroll = needsScroll;

            int btnW = w - 24 - (needsScroll ? 16 : 0);
            int left = 12;
            int top = 106;
            foreach (var b in new[] { btnNavDashboard, btnNavTransaction, btnNavHistory,
                               btnNavMemberships, btnNavDebts, btnNavGoals })
            {
                b.Width = btnW; b.Left = 12; b.Top = top; b.Height = btnH; b.Visible = true;
                if (mobile) { b.Text = (b.Tag?.ToString() ?? b.Text).Split(' ')[0]; b.TextAlign = ContentAlignment.MiddleCenter; }
                else { b.Text = b.Tag?.ToString() ?? b.Text; b.TextAlign = ContentAlignment.MiddleLeft; }
                top += b.Height + 6;
            }

            btnNavBack.Left = 12; btnNavBack.Width = btnW; btnNavBack.Visible = true;
            btnNavBack.Top = needsScroll ? top + 12 : pnlSidebar.ClientSize.Height - btnNavBack.Height - 12;
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
            gridBank.CellClick += GridBank_CellClick;
            gridPersonal.CellClick += GridPersonal_CellClick;
        }

        private new void Refresh()
        {
            List<Debt> bank = AppData.Debts.Where(d => d.IsBank).ToList();
            List<Debt> personal = AppData.Debts.Where(d => !d.IsBank).ToList();

            lblBankCountChip.Text = bank.Count.ToString();
            lblPersonalCountChip.Text = personal.Count.ToString();

            decimal total = AppData.Debts.Sum(d => d.Total);
            decimal paid = AppData.Debts.Sum(d => d.Paid);

            lblSummaryTotalValue.Text = Fmt.Money(total);
            lblSummaryPaidValue.Text = Fmt.Money(paid);
            lblSummaryPendingValue.Text = Fmt.Money(total - paid);
            lblSummaryCountValue.Text = AppData.Debts.Count.ToString();

            FillGrid(gridBank, bank);
            FillGrid(gridPersonal, personal);

            lblBankEmpty.Visible = bank.Count == 0;
            gridBank.Visible = bank.Count > 0;

            lblPersonalEmpty.Visible = personal.Count == 0;
            gridPersonal.Visible = personal.Count > 0;
        }

        private static void FillGrid(DataGridView grid, List<Debt> debts)
        {
            grid.Rows.Clear();

            foreach (Debt d in debts)
            {
                int rowIndex = grid.Rows.Add(
                    d.TypeIcon,
                    d.Creditor,
                    d.ProgressLabel,
                    d.TotalLabel,
                    d.PaidLabel,
                    d.RemainingLabel,
                    d.DueLabel,
                    "Pagar / Editar");

                DataGridViewRow row = grid.Rows[rowIndex];
                row.Tag = d;

                System.Drawing.Color remainingColor = d.DaysToDue < 30
                    ? System.Drawing.Color.FromArgb(239, 68, 68)
                    : System.Drawing.Color.FromArgb(204, 204, 204);

                row.Cells["col" + (grid.Name == "gridBank" ? "Bank" : "Personal") + "Remaining"].Style.ForeColor = remainingColor;
            }
        }

        private void GridBank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleGridClick(gridBank, e);
        }

        private void GridPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleGridClick(gridPersonal, e);
        }

        private void HandleGridClick(DataGridView grid, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = grid.Columns[e.ColumnIndex].Name;
            if (colName != "colBankAction" && colName != "colPersonalAction") return;

            Debt d = grid.Rows[e.RowIndex].Tag as Debt;
            if (d == null) return;

            ShowDebtActionsMenu(d);
        }

        private void ShowDebtActionsMenu(Debt d)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Registrar Pago", null, (s, e) => PayDebt(d));
            menu.Items.Add("Editar", null, (s, e) => EditDebt(d));
            menu.Show(Cursor.Position);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (DebtEditForm dlg = new DebtEditForm("", true, 0, 0, DateTime.Today.AddMonths(6), 0))
            {
                dlg.Text = "Nueva Deuda";
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                BaseDatos.InsertarDeuda(new Debt
                {
                    Creditor = dlg.DebtCreditor,
                    IsBank = dlg.DebtIsBank,
                    Total = dlg.DebtTotal,
                    Paid = Math.Min(dlg.DebtTotal, dlg.DebtPaid),
                    DueDate = dlg.DebtDueDate,
                    InterestRate = dlg.DebtInterestRate
                });

                Refresh();
            }
        }

        private void EditDebt(Debt d)
        {
            using (DebtEditForm dlg = new DebtEditForm(d.Creditor, d.IsBank, d.Total, d.Paid, d.DueDate, d.InterestRate))
            {
                dlg.Text = "Editar Deuda";
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                d.Creditor = dlg.DebtCreditor;
                d.IsBank = dlg.DebtIsBank;
                d.Total = dlg.DebtTotal;
                d.Paid = Math.Min(dlg.DebtTotal, dlg.DebtPaid);
                d.DueDate = dlg.DebtDueDate;
                d.InterestRate = dlg.DebtInterestRate;
                BaseDatos.ActualizarDeuda(d);

                Refresh();
            }
        }

        private void PayDebt(Debt d)
        {
            using (PayDebtForm dlg = new PayDebtForm(d.Creditor, d.RemainingLabel))
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                decimal amount = dlg.PaymentAmount;
                d.Paid = Math.Min(d.Total, d.Paid + amount);
                if (!BaseDatos.ActualizarDeuda(d)) return;

                BaseDatos.InsertarTransaccion(new Transaction
                {
                    Date = DateTime.Today,
                    Type = TxType.Gasto,
                    Category = "Otros",
                    Description = "Pago deuda: " + d.Creditor,
                    Amount = amount
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