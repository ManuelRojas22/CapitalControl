using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapitalControl.Controls;

namespace CapitalControl
{
    /// <summary>
    /// Formulario de previsualizacion (WinForms) del Dashboard.
    /// Generado con el patron estandar de InitializeComponent para poder
    /// abrirse y editarse desde el Diseñador de Windows Forms de Visual Studio
    /// (mover tarjetas, paneles y etiquetas con el mouse) sin necesidad de ejecutar la app,
    /// replicando el diseño de Views/DashboardView.xaml (version WPF) con datos de
    /// muestra tomados de Services/AppData.cs.
    /// </summary>
    public partial class DashboardForm : Form
    {
        /// <summary>Se dispara cuando el usuario pide navegar a "dashboard", "transaction" o "landing".</summary>
        public event EventHandler<string> NavigateRequested;

        private bool _layoutReady = false;

        // Responsive constants
        private const int LayoutMargin = 24;
        private const int ColGap = 18;
        private const int DesktopBreak = 1300;   // total form width
        private const int TabletBreak = 900;     // total form width
        private const int SidebarExpanded = 260;
        private const int SidebarCollapsed = 64;

        public DashboardForm()
        {
            InitializeComponent();

            // Prevent layout code from running in the VS Designer
            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            this.MinimumSize = new Size(520, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            pnlRoot.Dock = DockStyle.Fill;
            pnlMain.AutoScroll = true;
            pnlMain.Dock = DockStyle.Fill;

            // Apply emoji-capable font to controls that show icons
            ApplyEmojiFallbackFont();

            // Give stat icons explicit foreground colors so the monochrome emoji outline is visible
            lblStat1Icon.ForeColor = Color.FromArgb(0, 208, 132);   // green for income
            lblStat2Icon.ForeColor = Color.FromArgb(239, 68, 68);   // red for expenses
            lblStat3Icon.ForeColor = Color.FromArgb(55, 148, 255);  // blue for balance

            // Store original button texts for sidebar collapse/expand
            StoreOriginalSidebarTexts();

            this.Load += DashboardForm_Load;
            this.Resize += DashboardForm_Resize;

            WireEvents();
            LoadChartData();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            _layoutReady = true;
            PerformResponsiveLayout();
        }

        private void DashboardForm_Resize(object sender, EventArgs e)
        {
            if (_layoutReady)
                PerformResponsiveLayout();
        }

        private void PerformResponsiveLayout()
        {
            pnlMain.SuspendLayout();
            pnlSidebar.SuspendLayout();
            try
            {
                int totalW = this.ClientSize.Width;
                int totalH = this.ClientSize.Height;

                bool isDesktop = totalW >= DesktopBreak;
                bool isTablet = totalW >= TabletBreak && totalW < DesktopBreak;
                bool isMobile = totalW < TabletBreak;

                // ---- Sidebar ----
                LayoutSidebar(isMobile);
                int sidebarW = isMobile ? SidebarCollapsed : SidebarExpanded;

                // ---- Main content area (pnlMain) ----
                int contentW = totalW - sidebarW - 2 * LayoutMargin;
                if (contentW < 300) contentW = 300;

                int currentTop = 0;

                // TopBar spans full width of pnlMain
                currentTop = LayoutTopBar(contentW, currentTop);

                // Title block
                currentTop = LayoutTitleBlock(contentW, currentTop);

                // Alerts
                currentTop = LayoutAlerts(contentW, currentTop);

                // Stats row
                currentTop = LayoutStats(contentW, isDesktop, isTablet, isMobile, currentTop);

                // Chart & Payments cards
                currentTop = LayoutChartAndPayments(contentW, isDesktop, isTablet, isMobile, currentTop);

                // Update scrollable area
                pnlMain.AutoScrollMinSize = new Size(0, currentTop + LayoutMargin);
            }
            finally
            {
                pnlSidebar.ResumeLayout();
                pnlMain.ResumeLayout();
            }
        }

        // ---------- Sidebar ----------
        private void StoreOriginalSidebarTexts()
        {
            var btns = new[] { btnNavDashboard, btnNavTransaction, btnNavHistory,
                               btnNavMemberships, btnNavDebts, btnNavGoals };
            foreach (var b in btns)
            {
                if (b.Tag == null) b.Tag = b.Text; // keep original
            }
        }

        private void ApplyEmojiFallbackFont()
        {
            // Choose best emoji-capable font available on the system
            string fontName = "Segoe UI Emoji";
            try
            {
                if (!FontFamily.Families.Any(f => f.Name == "Segoe UI Emoji"))
                {
                    if (FontFamily.Families.Any(f => f.Name == "Segoe UI Symbol"))
                        fontName = "Segoe UI Symbol";
                    else
                        fontName = "Segoe UI";
                }
            }
            catch
            {
                fontName = "Segoe UI";
            }

            var controls = new Control[]
            {
                btnNavDashboard, btnNavTransaction, btnNavHistory,
                btnNavMemberships, btnNavDebts, btnNavGoals, btnNavBack,
                lblAlert1Icon, lblAlert2Icon,
                lblStat1Icon, lblStat2Icon, lblStat3Icon
            };

            foreach (var c in controls)
            {
                if (c != null)
                {
                    c.Font = new Font(fontName, c.Font.Size, c.Font.Style);
                }
            }
        }

        private void LayoutSidebar(bool mobile)
        {
            int w = mobile ? SidebarCollapsed : SidebarExpanded;
            pnlSidebar.Width = w;
            pnlSidebar.Height = this.ClientSize.Height; // full height

            // Ensure background color is opaque (designer sets it, but keep it non‑transparent)
            if (pnlSidebar.BackColor == Color.Transparent)
                pnlSidebar.BackColor = Color.FromArgb(37, 37, 38);

            // Logo / subtitle
            lblSidebarLogo.Visible = !mobile;
            lblSidebarSubtitle.Visible = !mobile;

            var btns = new[] { btnNavDashboard, btnNavTransaction, btnNavHistory,
                               btnNavMemberships, btnNavDebts, btnNavGoals };

            int startTop = 106;
            int backBtnHeight = 40;
            int bottomMargin = 12;
            int gapAboveBack = 12;

            // Available height for the 6 nav buttons
            int availableH = pnlSidebar.ClientSize.Height - startTop
                             - backBtnHeight - bottomMargin - gapAboveBack;

            // Ideal spacing per button (height + gap)
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
                // Scale down proportionally, with a readable floor
                float scale = Math.Max(0.6f, (float)availableH / neededH);
                btnH = Math.Max(30, (int)(idealBtnH * scale));
                gap = Math.Max(2, (int)(idealGap * scale));

                int scaledNeeded = btns.Length * (btnH + gap);
                needsScroll = scaledNeeded > availableH;
            }

            pnlSidebar.AutoScroll = needsScroll;

            int btnW = w - 24 - (needsScroll ? 16 : 0); // reserve scrollbar width if needed
            int left = 12;
            int top = startTop;
            foreach (var b in btns)
            {
                b.Width = btnW;
                b.Left = left;
                b.Top = top;
                b.Height = btnH;
                b.Visible = true; // ensure buttons stay visible

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
            {
                // inside scrollable area, just below last button
                btnNavBack.Top = top + gapAboveBack;
            }
            else
            {
                btnNavBack.Top = pnlSidebar.ClientSize.Height - btnNavBack.Height - bottomMargin;
            }
        }

        // ---------- TopBar ----------
        private int LayoutTopBar(int contentW, int top)
        {
            pnlTopBar.Width = pnlMain.ClientSize.Width;
            pnlTopBar.Left = 0;
            pnlTopBar.Top = top;
            pnlTopBar.Height = 60;

            lblLogo.Left = LayoutMargin;
            lblLogo.Top = (pnlTopBar.Height - lblLogo.Height) / 2;

            return pnlTopBar.Bottom;
        }

        // ---------- Title block ----------
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

        // ---------- Alerts ----------
        private int LayoutAlerts(int contentW, int top)
        {
            pnlAlert1.Width = contentW;
            pnlAlert1.Left = LayoutMargin;
            pnlAlert1.Top = top;

            pnlAlert2.Width = contentW;
            pnlAlert2.Left = LayoutMargin;
            pnlAlert2.Top = pnlAlert1.Bottom + 12;

            return pnlAlert2.Bottom;
        }

        // ---------- Stats ----------
        private int LayoutStats(int contentW, bool desktop, bool tablet, bool mobile, int top)
        {
            int cols = desktop ? 3 : (tablet ? 2 : 1);
            int colW = (contentW - (cols - 1) * ColGap) / cols;
            int startX = LayoutMargin;

            var stats = new[]
            {
                new {Panel=pnlStat1, Icon=lblStat1Icon, Change=lblStat1Change, Title=lblStat1Title, Value=lblStat1Value},
                new {Panel=pnlStat2, Icon=lblStat2Icon, Change=lblStat2Change, Title=lblStat2Title, Value=lblStat2Value},
                new {Panel=pnlStat3, Icon=lblStat3Icon, Change=lblStat3Change, Title=lblStat3Title, Value=lblStat3Value},
            };

            for (int i = 0; i < stats.Length; i++)
            {
                int row = mobile ? i : (tablet ? i / 2 : 0);
                int col = mobile ? 0 : (tablet ? i % 2 : i);
                int x = startX + col * (colW + ColGap);
                int y = top + row * (120 + ColGap);

                var s = stats[i];
                s.Panel.Left = x;
                s.Panel.Top = y;
                s.Panel.Width = colW;
                s.Panel.Height = 120;

                s.Icon.Left = 20;
                s.Change.Left = colW - 20 - s.Change.Width;
                s.Title.Width = colW - 40;
                s.Value.Width = colW - 40;
            }

            int rows = mobile ? 3 : (tablet ? 2 : 1);
            int bottom = top + rows * (120 + ColGap) + 20;
            // ensure bottom reflects actual panels
            bottom = Math.Max(bottom, Math.Max(pnlStat1.Bottom, Math.Max(pnlStat2.Bottom, pnlStat3.Bottom)));
            return bottom;
        }

        // ---------- Chart & Payments ----------
        private int LayoutChartAndPayments(int contentW, bool desktop, bool tablet, bool mobile, int top)
        {
            bool stacked = !desktop; // tablet & mobile stacked
            int gap = ColGap;

            if (!stacked)
            {
                // side by side
                int cardW = (contentW - gap) / 2;
                // Chart card
                pnlChartCard.Width = cardW;
                pnlChartCard.Height = 380;
                pnlChartCard.Left = LayoutMargin;
                pnlChartCard.Top = top;

                // Payments card
                pnlPaymentsCard.Width = cardW;
                pnlPaymentsCard.Height = 380;
                pnlPaymentsCard.Left = pnlChartCard.Right + gap;
                pnlPaymentsCard.Top = top;

                LayoutChartInner(cardW);
                LayoutPaymentsInner(cardW);

                return Math.Max(pnlChartCard.Bottom, pnlPaymentsCard.Bottom);
            }
            else
            {
                // stacked: each full width, one below the other
                int cardW = contentW;
                // Chart card
                pnlChartCard.Width = cardW;
                pnlChartCard.Height = 380;
                pnlChartCard.Left = LayoutMargin;
                pnlChartCard.Top = top;

                // Payments card below chart
                pnlPaymentsCard.Width = cardW;
                pnlPaymentsCard.Height = 380;
                pnlPaymentsCard.Left = LayoutMargin;
                pnlPaymentsCard.Top = pnlChartCard.Bottom + gap;

                LayoutChartInner(cardW);
                LayoutPaymentsInner(cardW);

                return pnlPaymentsCard.Bottom;
            }
        }

        private void LayoutChartInner(int cardW)
        {
            // Title
            lblChartTitle.Width = Math.Max(100, cardW - 40);
            lblChartTitle.Left = 20;
            lblChartTitle.Top = 16;

            // Donut chart: ensure it fits within card
            int donutSize = Math.Min(210, Math.Max(80, cardW - 20));
            if (donutSize < 80) donutSize = 80; // safeguard
            donutChart.Size = new Size(donutSize, donutSize);
            donutChart.Left = Math.Max(10, (cardW - donutSize) / 2);
            donutChart.Top = 56;
            donutChart.Visible = true; // ensure visible

            // Legends layout
            int legendStartX = donutChart.Right + 20;
            int legendY = 64;

            // Available width for legend columns
            int availLegendW = cardW - legendStartX - 20; // 20 right margin
            bool twoColumns = availLegendW >= 240; // each column at least 120

            int legendColW;
            if (twoColumns)
            {
                legendColW = Math.Max(120, (availLegendW) / 2);
            }
            else
            {
                legendColW = Math.Max(120, availLegendW);
            }

            var legends = new[]
            {
                new {Swatch=lblLegend1Swatch, Text=lblLegend1Text},
                new {Swatch=lblLegend2Swatch, Text=lblLegend2Text},
                new {Swatch=lblLegend3Swatch, Text=lblLegend3Text},
                new {Swatch=lblLegend4Swatch, Text=lblLegend4Text},
                new {Swatch=lblLegend5Swatch, Text=lblLegend5Text},
                new {Swatch=lblLegend6Swatch, Text=lblLegend6Text},
                new {Swatch=lblLegend7Swatch, Text=lblLegend7Text},
            };

            for (int i = 0; i < legends.Length; i++)
            {
                int col = twoColumns ? (i % 2) : 0;
                int row = twoColumns ? (i / 2) : i;
                int x = legendStartX + col * legendColW;
                int y = legendY + row * 26;
                legends[i].Swatch.Left = x;
                legends[i].Swatch.Top = y;
                legends[i].Text.Left = x + 16;
                legends[i].Text.Top = y - 2;
                legends[i].Swatch.Visible = true;
                legends[i].Text.Visible = true;
            }
        }

        private void LayoutPaymentsInner(int cardW)
        {
            lblPaymentsTitle.Width = cardW - 40;
            lblPaymentsTitle.Left = 20;
            lblPaymentsTitle.Top = 16;

            var pays = new[]
            {
                new {Panel=pnlPay1, Name=lblPay1Name, Date=lblPay1Date, Amount=lblPay1Amount, Urgent=lblPay1Urgent},
                new {Panel=pnlPay2, Name=lblPay2Name, Date=lblPay2Date, Amount=lblPay2Amount, Urgent=lblPay2Urgent},
                new {Panel=pnlPay3, Name=lblPay3Name, Date=lblPay3Date, Amount=lblPay3Amount, Urgent=lblPay3Urgent},
                new {Panel=pnlPay4, Name=lblPay4Name, Date=lblPay4Date, Amount=lblPay4Amount, Urgent=lblPay4Urgent},
            };

            int innerW = cardW - 40;
            int top = 56;
            foreach (var p in pays)
            {
                p.Panel.Width = innerW;
                p.Panel.Height = 66;
                p.Panel.Left = 20;
                p.Panel.Top = top;

                // Reserve space for Amount + Urgent on the right
                int reservedRight = Math.Max(p.Amount.Width, p.Urgent.Width) + 20;
                int nameWidth = Math.Max(80, innerW - reservedRight);
                p.Name.Width = nameWidth;
                p.Date.Width = nameWidth;
                p.Amount.Left = innerW - p.Amount.Width;
                p.Urgent.Left = innerW - p.Urgent.Width;

                top += p.Panel.Height + 10;
            }
        }

        // ---------- Existing wiring ----------
        private void WireEvents()
        {
            btnNavDashboard.Click += (s, e) => Raise("dashboard");
            btnNavTransaction.Click += (s, e) => Raise("transaction");
            btnNavHistory.Click += (s, e) => Raise("history");
            btnNavMemberships.Click += (s, e) => Raise("memberships");
            btnNavDebts.Click += (s, e) => Raise("debts");
            btnNavGoals.Click += (s, e) => Raise("goals");
            btnNavBack.Click += (s, e) => Raise("landing");
        }

        private void Raise(string target)
        {
            EventHandler<string> handler = NavigateRequested;
            if (handler != null) handler(this, target);
        }

        /// <summary>Carga las porciones del grafico de "Gastos por Categoria" (datos de muestra).</summary>
        private void LoadChartData()
        {
            donutChart.Slices = new List<DonutSlice>
            {
                new DonutSlice("Vivienda", 720000, Color.FromArgb(0xEF, 0x44, 0x44)),
                new DonutSlice("Alimentacion", 680000, Color.FromArgb(0x37, 0x94, 0xFF)),
                new DonutSlice("Transporte", 336000, Color.FromArgb(0xFA, 0xCC, 0x15)),
                new DonutSlice("Entretenimiento", 280000, Color.FromArgb(0x00, 0xD0, 0x84)),
                new DonutSlice("Salud", 184000, Color.FromArgb(0x8B, 0x5C, 0xF6)),
                new DonutSlice("Otros", 80000, Color.FromArgb(0xF5, 0x9E, 0x0B)),
                new DonutSlice("Servicios", 74800, Color.FromArgb(0x38, 0xBD, 0xF8)),
            };
            donutChart.Invalidate();
        }
    }
}