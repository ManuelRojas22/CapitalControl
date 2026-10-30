using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CapitalControl
{
    /// <summary>
    /// Formulario de previsualizacion (WinForms) de la Landing Page.
    /// Generado con el patron estandar de InitializeComponent para poder
    /// abrirse y editarse desde el Diseñador de Windows Forms de Visual Studio
    /// (mover botones, paneles y etiquetas con el mouse) sin necesidad de ejecutar la app.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>Se dispara cuando el usuario pide navegar a "login", "register" o "app".</summary>
        public event EventHandler<string> NavigateRequested;

        private bool _layoutReady = false;
        private const int LayoutMargin = 24;
        private const int ColGap = 20;
        private const int DesktopBreak = 1300;
        private const int TabletBreak = 700;

        public MainForm()
        {
            InitializeComponent();

            // Prevent layout code from running in the VS Designer
            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            this.MinimumSize = new Size(600, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            pnlRoot.AutoScroll = true;
            pnlRoot.Dock = DockStyle.Fill;

            this.Load += MainForm_Load;
            this.Resize += MainForm_Resize;

            WireEvents();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _layoutReady = true;
            PerformResponsiveLayout();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (_layoutReady)
                PerformResponsiveLayout();
        }

        private void PerformResponsiveLayout()
        {
            pnlRoot.SuspendLayout();
            try
            {
                int w = pnlRoot.ClientSize.Width;
                int contentW = w - 2 * LayoutMargin;
                if (contentW < 300) contentW = 300;

                bool isDesktop = w >= DesktopBreak;
                bool isTablet = w >= TabletBreak && w < DesktopBreak;
                bool isMobile = w < TabletBreak;

                int y = 0;

                // ---------- Header ----------
                LayoutHeader(w, contentW);
                y += pnlHeader.Height + LayoutMargin;

                // ---------- Hero ----------
                LayoutHero(w, contentW, isDesktop, isTablet, isMobile);
                y += pnlHero.Height + LayoutMargin;

                // ---------- Stats ----------
                LayoutStats(w, contentW, isDesktop, isTablet, isMobile);
                y += pnlStats.Height + LayoutMargin;

                // ---------- Features ----------
                LayoutFeatures(w, contentW, isDesktop, isTablet, isMobile);
                y += pnlFeatures.Height + LayoutMargin;

                // ---------- Steps ----------
                LayoutSteps(w, contentW, isDesktop, isTablet, isMobile);
                y += pnlSteps.Height + LayoutMargin;

                // ---------- CTA ----------
                LayoutCta(w, contentW);
                y += pnlCta.Height + LayoutMargin;

                // ---------- Footer ----------
                LayoutFooter(w, contentW);
                y += pnlFooter.Height;

                // Update scroll
                pnlRoot.AutoScrollMinSize = new Size(0, y + LayoutMargin);
            }
            finally
            {
                pnlRoot.ResumeLayout();
            }
        }

        // ----- Section layout helpers -----
        private void LayoutHeader(int w, int contentW)
        {
            pnlHeader.Width = w;
            pnlHeader.Left = 0;
            pnlHeader.Top = 0;
            pnlHeader.Height = 70;

            lblLogo.Left = LayoutMargin;
            lblLogo.Top = (pnlHeader.Height - lblLogo.Height) / 2;

            int btnRight = w - LayoutMargin;
            btnRegisterTop.Width = 150;
            btnRegisterTop.Height = 40;
            btnRegisterTop.Left = btnRight - btnRegisterTop.Width;
            btnRegisterTop.Top = (pnlHeader.Height - btnRegisterTop.Height) / 2;
            btnRight = btnRegisterTop.Left - 12;

            btnLoginTop.Width = 130;
            btnLoginTop.Height = 40;
            btnLoginTop.Left = btnRight - btnLoginTop.Width;
            btnLoginTop.Top = (pnlHeader.Height - btnLoginTop.Height) / 2;
        }

        private void LayoutHero(int w, int contentW, bool desktop, bool tablet, bool mobile)
        {
            pnlHero.Width = w;
            pnlHero.Left = 0;
            pnlHero.Top = pnlHeader.Bottom + LayoutMargin;

            int leftColX = LayoutMargin;

            // left column (text)
            int maxTextW;
            int previewW = 0;
            bool showPreview = desktop; // desktop only shows side-by-side

            if (desktop)
            {
                // two columns: left text, right preview card
                // reserve minimum 300 for preview, rest for text, with gap
                maxTextW = Math.Min(620, contentW - 300 - ColGap);
                if (maxTextW < 300) maxTextW = 300;
                previewW = contentW - maxTextW - ColGap;
                if (previewW < 300) previewW = 300;
            }
            else
            {
                // tablet or mobile: single column, full width for text
                maxTextW = contentW;
                previewW = contentW;
            }

            lblChip.Left = leftColX;
            lblChip.Top = 30;

            lblHeroTitle.Width = maxTextW;
            lblHeroTitle.Left = leftColX;
            lblHeroTitle.Top = 66;

            lblHeroDesc.Width = maxTextW;
            lblHeroDesc.Left = leftColX;
            lblHeroDesc.Top = lblHeroTitle.Bottom + 10;

            btnHeroRegister.Left = leftColX;
            btnHeroRegister.Top = lblHeroDesc.Bottom + 20;

            btnHeroDemo.Left = btnHeroRegister.Right + 12;
            btnHeroDemo.Top = btnHeroRegister.Top;

            lblTrust1.Left = leftColX;
            lblTrust1.Top = btnHeroRegister.Bottom + 20;
            lblTrust2.Left = lblTrust1.Right + 12;
            lblTrust2.Top = lblTrust1.Top;
            lblTrust3.Left = lblTrust2.Right + 12;
            lblTrust3.Top = lblTrust1.Top;

            int leftBottom = Math.Max(lblTrust1.Bottom, Math.Max(lblTrust2.Bottom, lblTrust3.Bottom));

            // preview card: visible in all modes; side-by-side only on desktop
            pnlPreviewCard.Visible = true;
            if (showPreview)
            {
                pnlPreviewCard.Width = previewW;
                pnlPreviewCard.Height = 370;
                pnlPreviewCard.Left = w - LayoutMargin - previewW;
                pnlPreviewCard.Top = 30;

                // inner 2x2 grid
                int cardColW = (previewW - 2 * 22 - ColGap) / 2;
                int cardColH = 110;
                int startX = 22;
                int startY = 60;
                LayoutPreviewItem(pnlPrevIngresos, startX, startY, cardColW, cardColH);
                LayoutPreviewItem(pnlPrevGastos, startX + cardColW + ColGap, startY, cardColW, cardColH);
                LayoutPreviewItem(pnlPrevMetas, startX, startY + cardColH + ColGap, cardColW, cardColH);
                LayoutPreviewItem(pnlPrevSubs, startX + cardColW + ColGap, startY + cardColH + ColGap, cardColW, cardColH);

                pnlHero.Height = Math.Max(leftBottom, pnlPreviewCard.Bottom) + 20;
            }
            else
            {
                // tablet / mobile: stack preview below text
                pnlPreviewCard.Width = previewW;
                pnlPreviewCard.Height = 370;
                pnlPreviewCard.Left = LayoutMargin;
                pnlPreviewCard.Top = leftBottom + 20;

                int cardColW = (previewW - 2 * 22 - ColGap) / 2;
                int cardColH = 110;
                int startX = 22;
                int startY = 60;
                LayoutPreviewItem(pnlPrevIngresos, startX, startY, cardColW, cardColH);
                LayoutPreviewItem(pnlPrevGastos, startX + cardColW + ColGap, startY, cardColW, cardColH);
                LayoutPreviewItem(pnlPrevMetas, startX, startY + cardColH + ColGap, cardColW, cardColH);
                LayoutPreviewItem(pnlPrevSubs, startX + cardColW + ColGap, startY + cardColH + ColGap, cardColW, cardColH);

                pnlHero.Height = pnlPreviewCard.Bottom + 20;
            }
        }

        private void LayoutPreviewItem(Panel panel, int x, int y, int w, int h)
        {
            panel.Left = x;
            panel.Top = y;
            panel.Width = w;
            panel.Height = h;
        }

        private void LayoutStats(int w, int contentW, bool desktop, bool tablet, bool mobile)
        {
            pnlStats.Width = w;
            pnlStats.Left = 0;
            pnlStats.Top = pnlHero.Bottom + LayoutMargin;

            int cols = desktop ? 4 : (tablet ? 2 : 1);
            int colW = (contentW - (cols - 1) * ColGap) / cols;
            int startX = LayoutMargin;
            int topIcon = 28;
            int topVal = 60;
            int topTitle = 98;
            int statH = 130;

            var stats = new[]
            {
                new {Icon=lblStat1Icon, Val=lblStat1Value, Title=lblStat1Title},
                new {Icon=lblStat2Icon, Val=lblStat2Value, Title=lblStat2Title},
                new {Icon=lblStat3Icon, Val=lblStat3Value, Title=lblStat3Title},
                new {Icon=lblStat4Icon, Val=lblStat4Value, Title=lblStat4Title},
            };

            for (int i = 0; i < stats.Length; i++)
            {
                int row = mobile ? i : (tablet ? i / 2 : 0);
                int col = mobile ? 0 : (tablet ? i % 2 : i);
                int x = startX + col * (colW + ColGap);
                int y = row * (statH + ColGap);

                stats[i].Icon.Left = x;
                stats[i].Icon.Top = y + topIcon;
                stats[i].Icon.Width = colW;
                stats[i].Icon.Height = 30;

                stats[i].Val.Left = x;
                stats[i].Val.Top = y + topVal;
                stats[i].Val.Width = colW;
                stats[i].Val.Height = 34;

                stats[i].Title.Left = x;
                stats[i].Title.Top = y + topTitle;
                stats[i].Title.Width = colW;
                stats[i].Title.Height = 22;
            }

            int rows = mobile ? 4 : (tablet ? 2 : 1);
            pnlStats.Height = rows * (statH + ColGap) + 20;
        }

        private void LayoutFeatures(int w, int contentW, bool desktop, bool tablet, bool mobile)
        {
            pnlFeatures.Width = w;
            pnlFeatures.Left = 0;
            pnlFeatures.Top = pnlStats.Bottom + LayoutMargin;

            lblFeaturesTitle.Width = contentW;
            lblFeaturesTitle.Left = LayoutMargin;
            lblFeaturesTitle.Top = 20;

            lblFeaturesSubtitle.Width = contentW;
            lblFeaturesSubtitle.Left = LayoutMargin;
            lblFeaturesSubtitle.Top = lblFeaturesTitle.Bottom + 2;

            int cols = desktop ? 3 : 1;
            int colW = (contentW - (cols - 1) * ColGap) / cols;
            int startX = LayoutMargin;
            int top = lblFeaturesSubtitle.Bottom + 20;
            int cardH = 200;

            var feats = new[]
            {
                new {Panel=pnlFeature1, Icon=lblFeature1Icon, Title=lblFeature1Title, Desc=lblFeature1Desc},
                new {Panel=pnlFeature2, Icon=lblFeature2Icon, Title=lblFeature2Title, Desc=lblFeature2Desc},
                new {Panel=pnlFeature3, Icon=lblFeature3Icon, Title=lblFeature3Title, Desc=lblFeature3Desc},
            };

            for (int i = 0; i < feats.Length; i++)
            {
                int row = mobile ? i : 0;
                int col = mobile ? 0 : i;
                int x = startX + col * (colW + ColGap);
                int y = row * (cardH + ColGap) + top;

                feats[i].Panel.Left = x;
                feats[i].Panel.Top = y;
                feats[i].Panel.Width = colW;
                feats[i].Panel.Height = cardH;

                // inner controls keep their relative positions; just ensure desc width fits
                feats[i].Desc.Width = colW - 40;
            }

            int rows = mobile ? 3 : 1;
            pnlFeatures.Height = top + rows * (cardH + ColGap) + 20;
        }

        private void LayoutSteps(int w, int contentW, bool desktop, bool tablet, bool mobile)
        {
            pnlSteps.Width = w;
            pnlSteps.Left = 0;
            pnlSteps.Top = pnlFeatures.Bottom + LayoutMargin;

            lblStepsTitle.Width = contentW;
            lblStepsTitle.Left = LayoutMargin;
            lblStepsTitle.Top = 20;

            lblStepsSubtitle.Width = contentW;
            lblStepsSubtitle.Left = LayoutMargin;
            lblStepsSubtitle.Top = lblStepsTitle.Bottom + 2;

            int cols = desktop ? 3 : 1;
            int colW = (contentW - (cols - 1) * ColGap) / cols;
            int startX = LayoutMargin;
            int top = lblStepsSubtitle.Bottom + 20;
            int cardH = 200;

            var steps = new[]
            {
                new {Panel=pnlStep1, Num=lblStep1Num, Title=lblStep1Title, Desc=lblStep1Desc},
                new {Panel=pnlStep2, Num=lblStep2Num, Title=lblStep2Title, Desc=lblStep2Desc},
                new {Panel=pnlStep3, Num=lblStep3Num, Title=lblStep3Title, Desc=lblStep3Desc},
            };

            for (int i = 0; i < steps.Length; i++)
            {
                int row = mobile ? i : 0;
                int col = mobile ? 0 : i;
                int x = startX + col * (colW + ColGap);
                int y = row * (cardH + ColGap) + top;

                steps[i].Panel.Left = x;
                steps[i].Panel.Top = y;
                steps[i].Panel.Width = colW;
                steps[i].Panel.Height = cardH;

                steps[i].Desc.Width = colW - 40;
            }

            int rows = mobile ? 3 : 1;
            pnlSteps.Height = top + rows * (cardH + ColGap) + 20;
        }

        private void LayoutCta(int w, int contentW)
        {
            pnlCta.Width = w;
            pnlCta.Left = 0;
            pnlCta.Top = pnlSteps.Bottom + LayoutMargin;

            lblCtaTitle.Width = contentW;
            lblCtaTitle.Left = LayoutMargin;
            lblCtaTitle.Top = 30;

            lblCtaDesc.Width = contentW;
            lblCtaDesc.Left = LayoutMargin;
            lblCtaDesc.Top = lblCtaTitle.Bottom + 4;

            btnCtaRegister.Left = (w - btnCtaRegister.Width) / 2;
            btnCtaRegister.Top = lblCtaDesc.Bottom + 20;

            pnlCta.Height = btnCtaRegister.Bottom + 30;
        }

        private void LayoutFooter(int w, int contentW)
        {
            pnlFooter.Width = w;
            pnlFooter.Left = 0;
            pnlFooter.Top = pnlCta.Bottom + LayoutMargin;

            lblFooter.Width = contentW;
            lblFooter.Left = LayoutMargin;
            lblFooter.Top = (pnlFooter.Height - lblFooter.Height) / 2;
        }

        // ----- Existing event wiring -----
        private void WireEvents()
        {
            btnLoginTop.Click += (s, e) => Raise("login");
            btnRegisterTop.Click += (s, e) => Raise("register");
            btnHeroRegister.Click += (s, e) => Raise("register");
            btnHeroDemo.Click += (s, e) => Raise("app");
            btnCtaRegister.Click += (s, e) => Raise("register");
        }

        private void Raise(string target)
        {
            EventHandler<string> handler = NavigateRequested;
            if (handler != null) handler(this, target);
        }
    }
}
