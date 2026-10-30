namespace CapitalControl
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codigo generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.pnlRoot = new System.Windows.Forms.Panel();

            // ---- Barra lateral de navegacion (igual patron que Views/ShellView.xaml) ----
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarLogo = new System.Windows.Forms.Label();
            this.lblSidebarSubtitle = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavTransaction = new System.Windows.Forms.Button();
            this.btnNavHistory = new System.Windows.Forms.Button();
            this.btnNavMemberships = new System.Windows.Forms.Button();
            this.btnNavDebts = new System.Windows.Forms.Button();
            this.btnNavGoals = new System.Windows.Forms.Button();
            this.btnNavBack = new System.Windows.Forms.Button();

            // ---- Contenido principal (se desplaza a la derecha de la barra lateral) ----
            this.pnlMain = new System.Windows.Forms.Panel();

            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.pnlAlert1 = new System.Windows.Forms.Panel();
            this.lblAlert1Icon = new System.Windows.Forms.Label();
            this.lblAlert1Text = new System.Windows.Forms.Label();

            this.pnlAlert2 = new System.Windows.Forms.Panel();
            this.lblAlert2Icon = new System.Windows.Forms.Label();
            this.lblAlert2Text = new System.Windows.Forms.Label();

            this.pnlStat1 = new System.Windows.Forms.Panel();
            this.lblStat1Icon = new System.Windows.Forms.Label();
            this.lblStat1Change = new System.Windows.Forms.Label();
            this.lblStat1Title = new System.Windows.Forms.Label();
            this.lblStat1Value = new System.Windows.Forms.Label();

            this.pnlStat2 = new System.Windows.Forms.Panel();
            this.lblStat2Icon = new System.Windows.Forms.Label();
            this.lblStat2Change = new System.Windows.Forms.Label();
            this.lblStat2Title = new System.Windows.Forms.Label();
            this.lblStat2Value = new System.Windows.Forms.Label();

            this.pnlStat3 = new System.Windows.Forms.Panel();
            this.lblStat3Icon = new System.Windows.Forms.Label();
            this.lblStat3Change = new System.Windows.Forms.Label();
            this.lblStat3Title = new System.Windows.Forms.Label();
            this.lblStat3Value = new System.Windows.Forms.Label();

            this.pnlChartCard = new System.Windows.Forms.Panel();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.donutChart = new CapitalControl.Controls.DashboardDonut();
            this.lblLegend1Swatch = new System.Windows.Forms.Label();
            this.lblLegend1Text = new System.Windows.Forms.Label();
            this.lblLegend2Swatch = new System.Windows.Forms.Label();
            this.lblLegend2Text = new System.Windows.Forms.Label();
            this.lblLegend3Swatch = new System.Windows.Forms.Label();
            this.lblLegend3Text = new System.Windows.Forms.Label();
            this.lblLegend4Swatch = new System.Windows.Forms.Label();
            this.lblLegend4Text = new System.Windows.Forms.Label();
            this.lblLegend5Swatch = new System.Windows.Forms.Label();
            this.lblLegend5Text = new System.Windows.Forms.Label();
            this.lblLegend6Swatch = new System.Windows.Forms.Label();
            this.lblLegend6Text = new System.Windows.Forms.Label();
            this.lblLegend7Swatch = new System.Windows.Forms.Label();
            this.lblLegend7Text = new System.Windows.Forms.Label();

            this.pnlPaymentsCard = new System.Windows.Forms.Panel();
            this.lblPaymentsTitle = new System.Windows.Forms.Label();

            this.pnlPay1 = new System.Windows.Forms.Panel();
            this.lblPay1Name = new System.Windows.Forms.Label();
            this.lblPay1Date = new System.Windows.Forms.Label();
            this.lblPay1Amount = new System.Windows.Forms.Label();
            this.lblPay1Urgent = new System.Windows.Forms.Label();

            this.pnlPay2 = new System.Windows.Forms.Panel();
            this.lblPay2Name = new System.Windows.Forms.Label();
            this.lblPay2Date = new System.Windows.Forms.Label();
            this.lblPay2Amount = new System.Windows.Forms.Label();
            this.lblPay2Urgent = new System.Windows.Forms.Label();

            this.pnlPay3 = new System.Windows.Forms.Panel();
            this.lblPay3Name = new System.Windows.Forms.Label();
            this.lblPay3Date = new System.Windows.Forms.Label();
            this.lblPay3Amount = new System.Windows.Forms.Label();
            this.lblPay3Urgent = new System.Windows.Forms.Label();

            this.pnlPay4 = new System.Windows.Forms.Panel();
            this.lblPay4Name = new System.Windows.Forms.Label();
            this.lblPay4Date = new System.Windows.Forms.Label();
            this.lblPay4Amount = new System.Windows.Forms.Label();
            this.lblPay4Urgent = new System.Windows.Forms.Label();

            this.pnlRoot.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlAlert1.SuspendLayout();
            this.pnlAlert2.SuspendLayout();
            this.pnlStat1.SuspendLayout();
            this.pnlStat2.SuspendLayout();
            this.pnlStat3.SuspendLayout();
            this.pnlChartCard.SuspendLayout();
            this.pnlPaymentsCard.SuspendLayout();
            this.pnlPay1.SuspendLayout();
            this.pnlPay2.SuspendLayout();
            this.pnlPay3.SuspendLayout();
            this.pnlPay4.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlRoot
            //
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlRoot.Name = "pnlRoot";
            //
            // pnlTopBar
            //
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Size = new System.Drawing.Size(1340, 60);
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlTopBar.Name = "pnlTopBar";
            //
            // pnlSidebar
            //
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 220;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlSidebar.Name = "pnlSidebar";
            //
            // lblSidebarLogo
            //
            this.lblSidebarLogo.Location = new System.Drawing.Point(20, 20);
            this.lblSidebarLogo.Size = new System.Drawing.Size(180, 28);
            this.lblSidebarLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSidebarLogo.ForeColor = System.Drawing.Color.FromArgb(0, 208, 132);
            this.lblSidebarLogo.Text = "\U0001F4B0 Capital Control";
            this.lblSidebarLogo.AutoSize = false;
            //
            // lblSidebarSubtitle
            //
            this.lblSidebarSubtitle.Location = new System.Drawing.Point(20, 50);
            this.lblSidebarSubtitle.Size = new System.Drawing.Size(180, 32);
            this.lblSidebarSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSidebarSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSidebarSubtitle.Text = "Gestion Financiera Personal";
            this.lblSidebarSubtitle.AutoSize = false;
            //
            // btnNavDashboard
            //
            this.btnNavDashboard.Location = new System.Drawing.Point(12, 106);
            this.btnNavDashboard.Size = new System.Drawing.Size(196, 42);
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavDashboard.Text = "   \U0001F4CA  Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.Name = "btnNavDashboard";
            //
            // btnNavTransaction
            //
            this.btnNavTransaction.Location = new System.Drawing.Point(12, 152);
            this.btnNavTransaction.Size = new System.Drawing.Size(196, 42);
            this.btnNavTransaction.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.btnNavTransaction.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnNavTransaction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavTransaction.Text = "   \u2795  Nueva Transaccion";
            this.btnNavTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTransaction.FlatAppearance.BorderSize = 0;
            this.btnNavTransaction.UseVisualStyleBackColor = false;
            this.btnNavTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTransaction.Name = "btnNavTransaction";
            //
            // btnNavHistory
            //
            this.btnNavHistory.Location = new System.Drawing.Point(12, 198);
            this.btnNavHistory.Size = new System.Drawing.Size(196, 42);
            this.btnNavHistory.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.btnNavHistory.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnNavHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavHistory.Text = "   \U0001F4C3  Historial";
            this.btnNavHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHistory.FlatAppearance.BorderSize = 0;
            this.btnNavHistory.UseVisualStyleBackColor = false;
            this.btnNavHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavHistory.Name = "btnNavHistory";
            //
            // btnNavMemberships
            //
            this.btnNavMemberships.Location = new System.Drawing.Point(12, 244);
            this.btnNavMemberships.Size = new System.Drawing.Size(196, 42);
            this.btnNavMemberships.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.btnNavMemberships.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnNavMemberships.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavMemberships.Text = "   \U0001F4B3  Membresias";
            this.btnNavMemberships.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMemberships.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMemberships.FlatAppearance.BorderSize = 0;
            this.btnNavMemberships.UseVisualStyleBackColor = false;
            this.btnNavMemberships.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMemberships.Name = "btnNavMemberships";
            //
            // btnNavDebts
            //
            this.btnNavDebts.Location = new System.Drawing.Point(12, 290);
            this.btnNavDebts.Size = new System.Drawing.Size(196, 42);
            this.btnNavDebts.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.btnNavDebts.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnNavDebts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavDebts.Text = "   \U0001F3E6  Deudas y Creditos";
            this.btnNavDebts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDebts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDebts.FlatAppearance.BorderSize = 0;
            this.btnNavDebts.UseVisualStyleBackColor = false;
            this.btnNavDebts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDebts.Name = "btnNavDebts";
            //
            // btnNavGoals
            //
            this.btnNavGoals.Location = new System.Drawing.Point(12, 336);
            this.btnNavGoals.Size = new System.Drawing.Size(196, 42);
            this.btnNavGoals.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.btnNavGoals.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnNavGoals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavGoals.Text = "   \U0001F3AF  Metas de Ahorro";
            this.btnNavGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavGoals.FlatAppearance.BorderSize = 0;
            this.btnNavGoals.UseVisualStyleBackColor = false;
            this.btnNavGoals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavGoals.Name = "btnNavGoals";
            //
            // btnNavBack
            //
            this.btnNavBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNavBack.Location = new System.Drawing.Point(12, 838);
            this.btnNavBack.Size = new System.Drawing.Size(196, 40);
            this.btnNavBack.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.btnNavBack.ForeColor = System.Drawing.Color.White;
            this.btnNavBack.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnNavBack.Text = "\u2190 Volver al inicio";
            this.btnNavBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBack.UseVisualStyleBackColor = false;
            this.btnNavBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnNavBack.Name = "btnNavBack";
            //
            // pnlMain
            //
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.AutoScroll = true;
            this.pnlMain.AutoScrollMinSize = new System.Drawing.Size(1340, 860);
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlMain.Name = "pnlMain";
            //
            // lblLogo
            //
            this.lblLogo.Location = new System.Drawing.Point(28, 15);
            this.lblLogo.Size = new System.Drawing.Size(260, 30);
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(0, 208, 132);
            this.lblLogo.Text = "\U0001F4B0  Capital Control";
            this.lblLogo.AutoSize = false;
            //
            // lblTitle
            //
            this.lblTitle.Location = new System.Drawing.Point(28, 84);
            this.lblTitle.Size = new System.Drawing.Size(400, 38);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Dashboard";
            this.lblTitle.AutoSize = false;
            //
            // lblSubtitle
            //
            this.lblSubtitle.Location = new System.Drawing.Point(28, 124);
            this.lblSubtitle.Size = new System.Drawing.Size(500, 24);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSubtitle.Text = "Resumen de tu situacion financiera";
            this.lblSubtitle.AutoSize = false;
            //
            // pnlAlert1
            //
            this.pnlAlert1.Location = new System.Drawing.Point(28, 160);
            this.pnlAlert1.Size = new System.Drawing.Size(1284, 56);
            this.pnlAlert1.BackColor = System.Drawing.Color.FromArgb(62, 49, 27);
            this.pnlAlert1.Name = "pnlAlert1";
            //
            // lblAlert1Icon
            //
            this.lblAlert1Icon.Location = new System.Drawing.Point(14, 10);
            this.lblAlert1Icon.Size = new System.Drawing.Size(30, 30);
            this.lblAlert1Icon.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblAlert1Icon.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblAlert1Icon.Text = "\u26A0";
            this.lblAlert1Icon.AutoSize = false;
            //
            // lblAlert1Text
            //
            this.lblAlert1Text.Location = new System.Drawing.Point(50, 8);
            this.lblAlert1Text.Size = new System.Drawing.Size(1210, 40);
            this.lblAlert1Text.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAlert1Text.ForeColor = System.Drawing.Color.White;
            this.lblAlert1Text.Text = "Tu gasto en entretenimiento va en $280.000 este mes (85% del limite).";
            this.lblAlert1Text.AutoSize = false;
            //
            // pnlAlert2
            //
            this.pnlAlert2.Location = new System.Drawing.Point(28, 224);
            this.pnlAlert2.Size = new System.Drawing.Size(1284, 56);
            this.pnlAlert2.BackColor = System.Drawing.Color.FromArgb(61, 36, 36);
            this.pnlAlert2.Name = "pnlAlert2";
            //
            // lblAlert2Icon
            //
            this.lblAlert2Icon.Location = new System.Drawing.Point(14, 10);
            this.lblAlert2Icon.Size = new System.Drawing.Size(30, 30);
            this.lblAlert2Icon.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblAlert2Icon.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblAlert2Icon.Text = "\u26A0";
            this.lblAlert2Icon.AutoSize = false;
            //
            // lblAlert2Text
            //
            this.lblAlert2Text.Location = new System.Drawing.Point(50, 8);
            this.lblAlert2Text.Size = new System.Drawing.Size(1210, 40);
            this.lblAlert2Text.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAlert2Text.ForeColor = System.Drawing.Color.White;
            this.lblAlert2Text.Text = "Pago proximo: Bancolombia - Tarjeta Credito - $1.600.000 (Vence en 25 dias)";
            this.lblAlert2Text.AutoSize = false;
            //
            // pnlStat1
            //
            this.pnlStat1.Location = new System.Drawing.Point(28, 296);
            this.pnlStat1.Size = new System.Drawing.Size(416, 120);
            this.pnlStat1.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlStat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat1.Name = "pnlStat1";
            //
            // lblStat1Icon
            //
            this.lblStat1Icon.Location = new System.Drawing.Point(20, 14);
            this.lblStat1Icon.Size = new System.Drawing.Size(40, 34);
            this.lblStat1Icon.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblStat1Icon.Text = "\U0001F4C8";
            this.lblStat1Icon.AutoSize = false;
            //
            // lblStat1Change
            //
            this.lblStat1Change.Location = new System.Drawing.Point(300, 18);
            this.lblStat1Change.Size = new System.Drawing.Size(96, 24);
            this.lblStat1Change.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStat1Change.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblStat1Change.Text = "+12%";
            this.lblStat1Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStat1Change.AutoSize = false;
            //
            // lblStat1Title
            //
            this.lblStat1Title.Location = new System.Drawing.Point(20, 58);
            this.lblStat1Title.Size = new System.Drawing.Size(300, 20);
            this.lblStat1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat1Title.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblStat1Title.Text = "Ingresos del Mes";
            this.lblStat1Title.AutoSize = false;
            //
            // lblStat1Value
            //
            this.lblStat1Value.Location = new System.Drawing.Point(20, 78);
            this.lblStat1Value.Size = new System.Drawing.Size(376, 34);
            this.lblStat1Value.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblStat1Value.ForeColor = System.Drawing.Color.White;
            this.lblStat1Value.Text = "$4.140.000";
            this.lblStat1Value.AutoSize = false;
            //
            // pnlStat2
            //
            this.pnlStat2.Location = new System.Drawing.Point(462, 296);
            this.pnlStat2.Size = new System.Drawing.Size(416, 120);
            this.pnlStat2.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlStat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat2.Name = "pnlStat2";
            //
            // lblStat2Icon
            //
            this.lblStat2Icon.Location = new System.Drawing.Point(20, 14);
            this.lblStat2Icon.Size = new System.Drawing.Size(40, 34);
            this.lblStat2Icon.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblStat2Icon.Text = "\U0001F4C9";
            this.lblStat2Icon.AutoSize = false;
            //
            // lblStat2Change
            //
            this.lblStat2Change.Location = new System.Drawing.Point(300, 18);
            this.lblStat2Change.Size = new System.Drawing.Size(96, 24);
            this.lblStat2Change.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStat2Change.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblStat2Change.Text = "-8%";
            this.lblStat2Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStat2Change.AutoSize = false;
            //
            // lblStat2Title
            //
            this.lblStat2Title.Location = new System.Drawing.Point(20, 58);
            this.lblStat2Title.Size = new System.Drawing.Size(300, 20);
            this.lblStat2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat2Title.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblStat2Title.Text = "Gastos del Mes";
            this.lblStat2Title.AutoSize = false;
            //
            // lblStat2Value
            //
            this.lblStat2Value.Location = new System.Drawing.Point(20, 78);
            this.lblStat2Value.Size = new System.Drawing.Size(376, 34);
            this.lblStat2Value.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblStat2Value.ForeColor = System.Drawing.Color.White;
            this.lblStat2Value.Text = "$2.354.800";
            this.lblStat2Value.AutoSize = false;
            //
            // pnlStat3
            //
            this.pnlStat3.Location = new System.Drawing.Point(896, 296);
            this.pnlStat3.Size = new System.Drawing.Size(416, 120);
            this.pnlStat3.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlStat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStat3.Name = "pnlStat3";
            //
            // lblStat3Icon
            //
            this.lblStat3Icon.Location = new System.Drawing.Point(20, 14);
            this.lblStat3Icon.Size = new System.Drawing.Size(40, 34);
            this.lblStat3Icon.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblStat3Icon.Text = "\U0001F4B0";
            this.lblStat3Icon.AutoSize = false;
            //
            // lblStat3Change
            //
            this.lblStat3Change.Location = new System.Drawing.Point(280, 18);
            this.lblStat3Change.Size = new System.Drawing.Size(116, 24);
            this.lblStat3Change.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStat3Change.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.lblStat3Change.Text = "Actualizado";
            this.lblStat3Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStat3Change.AutoSize = false;
            //
            // lblStat3Title
            //
            this.lblStat3Title.Location = new System.Drawing.Point(20, 58);
            this.lblStat3Title.Size = new System.Drawing.Size(300, 20);
            this.lblStat3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStat3Title.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblStat3Title.Text = "Saldo Disponible";
            this.lblStat3Title.AutoSize = false;
            //
            // lblStat3Value
            //
            this.lblStat3Value.Location = new System.Drawing.Point(20, 78);
            this.lblStat3Value.Size = new System.Drawing.Size(376, 34);
            this.lblStat3Value.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblStat3Value.ForeColor = System.Drawing.Color.White;
            this.lblStat3Value.Text = "$1.385.200";
            this.lblStat3Value.AutoSize = false;
            //
            // pnlChartCard
            //
            this.pnlChartCard.Location = new System.Drawing.Point(28, 432);
            this.pnlChartCard.Size = new System.Drawing.Size(633, 380);
            this.pnlChartCard.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlChartCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChartCard.Name = "pnlChartCard";
            //
            // lblChartTitle
            //
            this.lblChartTitle.Location = new System.Drawing.Point(20, 16);
            this.lblChartTitle.Size = new System.Drawing.Size(400, 28);
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.White;
            this.lblChartTitle.Text = "Gastos por Categoria";
            this.lblChartTitle.AutoSize = false;
            //
            // donutChart
            //
            this.donutChart.Location = new System.Drawing.Point(20, 56);
            this.donutChart.Size = new System.Drawing.Size(210, 210);
            this.donutChart.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.donutChart.Name = "donutChart";
            //
            // lblLegend1Swatch
            //
            this.lblLegend1Swatch.Location = new System.Drawing.Point(250, 64);
            this.lblLegend1Swatch.Size = new System.Drawing.Size(10, 10);
            this.lblLegend1Swatch.BackColor = System.Drawing.Color.FromArgb(0xEF, 0x44, 0x44);
            this.lblLegend1Swatch.AutoSize = false;
            //
            // lblLegend1Text
            //
            this.lblLegend1Text.Location = new System.Drawing.Point(266, 60);
            this.lblLegend1Text.Size = new System.Drawing.Size(170, 20);
            this.lblLegend1Text.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegend1Text.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblLegend1Text.Text = "Vivienda  -  $720.000";
            this.lblLegend1Text.AutoSize = false;
            //
            // lblLegend2Swatch
            //
            this.lblLegend2Swatch.Location = new System.Drawing.Point(440, 64);
            this.lblLegend2Swatch.Size = new System.Drawing.Size(10, 10);
            this.lblLegend2Swatch.BackColor = System.Drawing.Color.FromArgb(0x37, 0x94, 0xFF);
            this.lblLegend2Swatch.AutoSize = false;
            //
            // lblLegend2Text
            //
            this.lblLegend2Text.Location = new System.Drawing.Point(456, 60);
            this.lblLegend2Text.Size = new System.Drawing.Size(170, 20);
            this.lblLegend2Text.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegend2Text.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblLegend2Text.Text = "Alimentacion  -  $680.000";
            this.lblLegend2Text.AutoSize = false;
            //
            // lblLegend3Swatch
            //
            this.lblLegend3Swatch.Location = new System.Drawing.Point(250, 90);
            this.lblLegend3Swatch.Size = new System.Drawing.Size(10, 10);
            this.lblLegend3Swatch.BackColor = System.Drawing.Color.FromArgb(0xFA, 0xCC, 0x15);
            this.lblLegend3Swatch.AutoSize = false;
            //
            // lblLegend3Text
            //
            this.lblLegend3Text.Location = new System.Drawing.Point(266, 86);
            this.lblLegend3Text.Size = new System.Drawing.Size(170, 20);
            this.lblLegend3Text.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegend3Text.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblLegend3Text.Text = "Transporte  -  $336.000";
            this.lblLegend3Text.AutoSize = false;
            //
            // lblLegend4Swatch
            //
            this.lblLegend4Swatch.Location = new System.Drawing.Point(440, 90);
            this.lblLegend4Swatch.Size = new System.Drawing.Size(10, 10);
            this.lblLegend4Swatch.BackColor = System.Drawing.Color.FromArgb(0x00, 0xD0, 0x84);
            this.lblLegend4Swatch.AutoSize = false;
            //
            // lblLegend4Text
            //
            this.lblLegend4Text.Location = new System.Drawing.Point(456, 86);
            this.lblLegend4Text.Size = new System.Drawing.Size(170, 20);
            this.lblLegend4Text.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegend4Text.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblLegend4Text.Text = "Entretenimiento  -  $280.000";
            this.lblLegend4Text.AutoSize = false;
            //
            // lblLegend5Swatch
            //
            this.lblLegend5Swatch.Location = new System.Drawing.Point(250, 116);
            this.lblLegend5Swatch.Size = new System.Drawing.Size(10, 10);
            this.lblLegend5Swatch.BackColor = System.Drawing.Color.FromArgb(0x8B, 0x5C, 0xF6);
            this.lblLegend5Swatch.AutoSize = false;
            //
            // lblLegend5Text
            //
            this.lblLegend5Text.Location = new System.Drawing.Point(266, 112);
            this.lblLegend5Text.Size = new System.Drawing.Size(170, 20);
            this.lblLegend5Text.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegend5Text.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblLegend5Text.Text = "Salud  -  $184.000";
            this.lblLegend5Text.AutoSize = false;
            //
            // lblLegend6Swatch
            //
            this.lblLegend6Swatch.Location = new System.Drawing.Point(440, 116);
            this.lblLegend6Swatch.Size = new System.Drawing.Size(10, 10);
            this.lblLegend6Swatch.BackColor = System.Drawing.Color.FromArgb(0xF5, 0x9E, 0x0B);
            this.lblLegend6Swatch.AutoSize = false;
            //
            // lblLegend6Text
            //
            this.lblLegend6Text.Location = new System.Drawing.Point(456, 112);
            this.lblLegend6Text.Size = new System.Drawing.Size(170, 20);
            this.lblLegend6Text.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegend6Text.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblLegend6Text.Text = "Otros  -  $80.000";
            this.lblLegend6Text.AutoSize = false;
            //
            // lblLegend7Swatch
            //
            this.lblLegend7Swatch.Location = new System.Drawing.Point(250, 142);
            this.lblLegend7Swatch.Size = new System.Drawing.Size(10, 10);
            this.lblLegend7Swatch.BackColor = System.Drawing.Color.FromArgb(0x38, 0xBD, 0xF8);
            this.lblLegend7Swatch.AutoSize = false;
            //
            // lblLegend7Text
            //
            this.lblLegend7Text.Location = new System.Drawing.Point(266, 138);
            this.lblLegend7Text.Size = new System.Drawing.Size(170, 20);
            this.lblLegend7Text.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLegend7Text.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblLegend7Text.Text = "Servicios  -  $74.800";
            this.lblLegend7Text.AutoSize = false;
            //
            // pnlPaymentsCard
            //
            this.pnlPaymentsCard.Location = new System.Drawing.Point(679, 432);
            this.pnlPaymentsCard.Size = new System.Drawing.Size(633, 380);
            this.pnlPaymentsCard.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlPaymentsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentsCard.Name = "pnlPaymentsCard";
            //
            // lblPaymentsTitle
            //
            this.lblPaymentsTitle.Location = new System.Drawing.Point(20, 16);
            this.lblPaymentsTitle.Size = new System.Drawing.Size(400, 28);
            this.lblPaymentsTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPaymentsTitle.ForeColor = System.Drawing.Color.White;
            this.lblPaymentsTitle.Text = "Proximos Pagos";
            this.lblPaymentsTitle.AutoSize = false;
            //
            // pnlPay1
            //
            this.pnlPay1.Location = new System.Drawing.Point(20, 56);
            this.pnlPay1.Size = new System.Drawing.Size(593, 66);
            this.pnlPay1.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.pnlPay1.Name = "pnlPay1";
            //
            // lblPay1Name
            //
            this.lblPay1Name.Location = new System.Drawing.Point(14, 10);
            this.lblPay1Name.Size = new System.Drawing.Size(340, 22);
            this.lblPay1Name.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPay1Name.ForeColor = System.Drawing.Color.White;
            this.lblPay1Name.Text = "ChatGPT Plus";
            this.lblPay1Name.AutoSize = false;
            //
            // lblPay1Date
            //
            this.lblPay1Date.Location = new System.Drawing.Point(14, 34);
            this.lblPay1Date.Size = new System.Drawing.Size(340, 20);
            this.lblPay1Date.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPay1Date.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblPay1Date.Text = "Dia 5 - Faltan 5 dias";
            this.lblPay1Date.AutoSize = false;
            //
            // lblPay1Amount
            //
            this.lblPay1Amount.Location = new System.Drawing.Point(380, 8);
            this.lblPay1Amount.Size = new System.Drawing.Size(199, 26);
            this.lblPay1Amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPay1Amount.ForeColor = System.Drawing.Color.White;
            this.lblPay1Amount.Text = "$79.900";
            this.lblPay1Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPay1Amount.AutoSize = false;
            //
            // lblPay1Urgent
            //
            this.lblPay1Urgent.Location = new System.Drawing.Point(380, 36);
            this.lblPay1Urgent.Size = new System.Drawing.Size(199, 18);
            this.lblPay1Urgent.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPay1Urgent.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblPay1Urgent.Text = "Urgente";
            this.lblPay1Urgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPay1Urgent.AutoSize = false;
            //
            // pnlPay2
            //
            this.pnlPay2.Location = new System.Drawing.Point(20, 132);
            this.pnlPay2.Size = new System.Drawing.Size(593, 66);
            this.pnlPay2.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.pnlPay2.Name = "pnlPay2";
            //
            // lblPay2Name
            //
            this.lblPay2Name.Location = new System.Drawing.Point(14, 10);
            this.lblPay2Name.Size = new System.Drawing.Size(340, 22);
            this.lblPay2Name.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPay2Name.ForeColor = System.Drawing.Color.White;
            this.lblPay2Name.Text = "Amazon Prime";
            this.lblPay2Name.AutoSize = false;
            //
            // lblPay2Date
            //
            this.lblPay2Date.Location = new System.Drawing.Point(14, 34);
            this.lblPay2Date.Size = new System.Drawing.Size(340, 20);
            this.lblPay2Date.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPay2Date.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblPay2Date.Text = "Dia 10 - Faltan 10 dias";
            this.lblPay2Date.AutoSize = false;
            //
            // lblPay2Amount
            //
            this.lblPay2Amount.Location = new System.Drawing.Point(380, 8);
            this.lblPay2Amount.Size = new System.Drawing.Size(199, 26);
            this.lblPay2Amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPay2Amount.ForeColor = System.Drawing.Color.White;
            this.lblPay2Amount.Text = "$29.900";
            this.lblPay2Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPay2Amount.AutoSize = false;
            //
            // lblPay2Urgent
            //
            this.lblPay2Urgent.Location = new System.Drawing.Point(380, 36);
            this.lblPay2Urgent.Size = new System.Drawing.Size(199, 18);
            this.lblPay2Urgent.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPay2Urgent.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblPay2Urgent.Text = "Urgente";
            this.lblPay2Urgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPay2Urgent.Visible = false;
            this.lblPay2Urgent.AutoSize = false;
            //
            // pnlPay3
            //
            this.pnlPay3.Location = new System.Drawing.Point(20, 208);
            this.pnlPay3.Size = new System.Drawing.Size(593, 66);
            this.pnlPay3.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.pnlPay3.Name = "pnlPay3";
            //
            // lblPay3Name
            //
            this.lblPay3Name.Location = new System.Drawing.Point(14, 10);
            this.lblPay3Name.Size = new System.Drawing.Size(340, 22);
            this.lblPay3Name.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPay3Name.ForeColor = System.Drawing.Color.White;
            this.lblPay3Name.Text = "GitHub Pro";
            this.lblPay3Name.AutoSize = false;
            //
            // lblPay3Date
            //
            this.lblPay3Date.Location = new System.Drawing.Point(14, 34);
            this.lblPay3Date.Size = new System.Drawing.Size(340, 20);
            this.lblPay3Date.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPay3Date.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblPay3Date.Text = "Dia 12 - Faltan 12 dias";
            this.lblPay3Date.AutoSize = false;
            //
            // lblPay3Amount
            //
            this.lblPay3Amount.Location = new System.Drawing.Point(380, 8);
            this.lblPay3Amount.Size = new System.Drawing.Size(199, 26);
            this.lblPay3Amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPay3Amount.ForeColor = System.Drawing.Color.White;
            this.lblPay3Amount.Text = "$35.900";
            this.lblPay3Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPay3Amount.AutoSize = false;
            //
            // lblPay3Urgent
            //
            this.lblPay3Urgent.Location = new System.Drawing.Point(380, 36);
            this.lblPay3Urgent.Size = new System.Drawing.Size(199, 18);
            this.lblPay3Urgent.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPay3Urgent.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblPay3Urgent.Text = "Urgente";
            this.lblPay3Urgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPay3Urgent.Visible = false;
            this.lblPay3Urgent.AutoSize = false;
            //
            // pnlPay4
            //
            this.pnlPay4.Location = new System.Drawing.Point(20, 284);
            this.pnlPay4.Size = new System.Drawing.Size(593, 66);
            this.pnlPay4.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.pnlPay4.Name = "pnlPay4";
            //
            // lblPay4Name
            //
            this.lblPay4Name.Location = new System.Drawing.Point(14, 10);
            this.lblPay4Name.Size = new System.Drawing.Size(340, 22);
            this.lblPay4Name.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPay4Name.ForeColor = System.Drawing.Color.White;
            this.lblPay4Name.Text = "Bancolombia - Tarjeta Credito";
            this.lblPay4Name.AutoSize = false;
            //
            // lblPay4Date
            //
            this.lblPay4Date.Location = new System.Drawing.Point(14, 34);
            this.lblPay4Date.Size = new System.Drawing.Size(340, 20);
            this.lblPay4Date.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPay4Date.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblPay4Date.Text = "Vence en 25 dias";
            this.lblPay4Date.AutoSize = false;
            //
            // lblPay4Amount
            //
            this.lblPay4Amount.Location = new System.Drawing.Point(380, 8);
            this.lblPay4Amount.Size = new System.Drawing.Size(199, 26);
            this.lblPay4Amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPay4Amount.ForeColor = System.Drawing.Color.White;
            this.lblPay4Amount.Text = "$1.600.000";
            this.lblPay4Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPay4Amount.AutoSize = false;
            //
            // lblPay4Urgent
            //
            this.lblPay4Urgent.Location = new System.Drawing.Point(380, 36);
            this.lblPay4Urgent.Size = new System.Drawing.Size(199, 18);
            this.lblPay4Urgent.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPay4Urgent.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblPay4Urgent.Text = "Urgente";
            this.lblPay4Urgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPay4Urgent.AutoSize = false;

            this.pnlMain.Controls.Add(this.pnlTopBar);
            this.pnlTopBar.Controls.Add(this.lblLogo);

            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblSubtitle);

            this.pnlMain.Controls.Add(this.pnlAlert1);
            this.pnlAlert1.Controls.Add(this.lblAlert1Icon);
            this.pnlAlert1.Controls.Add(this.lblAlert1Text);

            this.pnlMain.Controls.Add(this.pnlAlert2);
            this.pnlAlert2.Controls.Add(this.lblAlert2Icon);
            this.pnlAlert2.Controls.Add(this.lblAlert2Text);

            this.pnlMain.Controls.Add(this.pnlStat1);
            this.pnlStat1.Controls.Add(this.lblStat1Icon);
            this.pnlStat1.Controls.Add(this.lblStat1Change);
            this.pnlStat1.Controls.Add(this.lblStat1Title);
            this.pnlStat1.Controls.Add(this.lblStat1Value);

            this.pnlMain.Controls.Add(this.pnlStat2);
            this.pnlStat2.Controls.Add(this.lblStat2Icon);
            this.pnlStat2.Controls.Add(this.lblStat2Change);
            this.pnlStat2.Controls.Add(this.lblStat2Title);
            this.pnlStat2.Controls.Add(this.lblStat2Value);

            this.pnlMain.Controls.Add(this.pnlStat3);
            this.pnlStat3.Controls.Add(this.lblStat3Icon);
            this.pnlStat3.Controls.Add(this.lblStat3Change);
            this.pnlStat3.Controls.Add(this.lblStat3Title);
            this.pnlStat3.Controls.Add(this.lblStat3Value);

            this.pnlMain.Controls.Add(this.pnlChartCard);
            this.pnlChartCard.Controls.Add(this.lblChartTitle);
            this.pnlChartCard.Controls.Add(this.donutChart);
            this.pnlChartCard.Controls.Add(this.lblLegend1Swatch);
            this.pnlChartCard.Controls.Add(this.lblLegend1Text);
            this.pnlChartCard.Controls.Add(this.lblLegend2Swatch);
            this.pnlChartCard.Controls.Add(this.lblLegend2Text);
            this.pnlChartCard.Controls.Add(this.lblLegend3Swatch);
            this.pnlChartCard.Controls.Add(this.lblLegend3Text);
            this.pnlChartCard.Controls.Add(this.lblLegend4Swatch);
            this.pnlChartCard.Controls.Add(this.lblLegend4Text);
            this.pnlChartCard.Controls.Add(this.lblLegend5Swatch);
            this.pnlChartCard.Controls.Add(this.lblLegend5Text);
            this.pnlChartCard.Controls.Add(this.lblLegend6Swatch);
            this.pnlChartCard.Controls.Add(this.lblLegend6Text);
            this.pnlChartCard.Controls.Add(this.lblLegend7Swatch);
            this.pnlChartCard.Controls.Add(this.lblLegend7Text);

            this.pnlMain.Controls.Add(this.pnlPaymentsCard);
            this.pnlPaymentsCard.Controls.Add(this.lblPaymentsTitle);
            this.pnlPaymentsCard.Controls.Add(this.pnlPay1);
            this.pnlPay1.Controls.Add(this.lblPay1Name);
            this.pnlPay1.Controls.Add(this.lblPay1Date);
            this.pnlPay1.Controls.Add(this.lblPay1Amount);
            this.pnlPay1.Controls.Add(this.lblPay1Urgent);
            this.pnlPaymentsCard.Controls.Add(this.pnlPay2);
            this.pnlPay2.Controls.Add(this.lblPay2Name);
            this.pnlPay2.Controls.Add(this.lblPay2Date);
            this.pnlPay2.Controls.Add(this.lblPay2Amount);
            this.pnlPay2.Controls.Add(this.lblPay2Urgent);
            this.pnlPaymentsCard.Controls.Add(this.pnlPay3);
            this.pnlPay3.Controls.Add(this.lblPay3Name);
            this.pnlPay3.Controls.Add(this.lblPay3Date);
            this.pnlPay3.Controls.Add(this.lblPay3Amount);
            this.pnlPay3.Controls.Add(this.lblPay3Urgent);
            this.pnlPaymentsCard.Controls.Add(this.pnlPay4);
            this.pnlPay4.Controls.Add(this.lblPay4Name);
            this.pnlPay4.Controls.Add(this.lblPay4Date);
            this.pnlPay4.Controls.Add(this.lblPay4Amount);
            this.pnlPay4.Controls.Add(this.lblPay4Urgent);

            this.pnlSidebar.Controls.Add(this.lblSidebarLogo);
            this.pnlSidebar.Controls.Add(this.lblSidebarSubtitle);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.btnNavTransaction);
            this.pnlSidebar.Controls.Add(this.btnNavHistory);
            this.pnlSidebar.Controls.Add(this.btnNavMemberships);
            this.pnlSidebar.Controls.Add(this.btnNavDebts);
            this.pnlSidebar.Controls.Add(this.btnNavGoals);
            this.pnlSidebar.Controls.Add(this.btnNavBack);

            // Importante: se agrega primero el panel "Fill" y luego el "Left"
            // para que Windows Forms reparta el espacio correctamente.
            this.pnlRoot.Controls.Add(this.pnlMain);
            this.pnlRoot.Controls.Add(this.pnlSidebar);

            this.Controls.Add(this.pnlRoot);
            //
            // DashboardForm
            //
            this.ClientSize = new System.Drawing.Size(1580, 900);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Text = "Capital Control - Dashboard (Vista previa)";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.pnlPay4.ResumeLayout(false);
            this.pnlPay3.ResumeLayout(false);
            this.pnlPay2.ResumeLayout(false);
            this.pnlPay1.ResumeLayout(false);
            this.pnlPaymentsCard.ResumeLayout(false);
            this.pnlChartCard.ResumeLayout(false);
            this.pnlStat3.ResumeLayout(false);
            this.pnlStat2.ResumeLayout(false);
            this.pnlStat1.ResumeLayout(false);
            this.pnlAlert2.ResumeLayout(false);
            this.pnlAlert1.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlRoot.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlRoot;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarLogo;
        private System.Windows.Forms.Label lblSidebarSubtitle;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavTransaction;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnNavMemberships;
        private System.Windows.Forms.Button btnNavDebts;
        private System.Windows.Forms.Button btnNavGoals;
        private System.Windows.Forms.Button btnNavBack;

        private System.Windows.Forms.Panel pnlMain;

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblLogo;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlAlert1;
        private System.Windows.Forms.Label lblAlert1Icon;
        private System.Windows.Forms.Label lblAlert1Text;

        private System.Windows.Forms.Panel pnlAlert2;
        private System.Windows.Forms.Label lblAlert2Icon;
        private System.Windows.Forms.Label lblAlert2Text;

        private System.Windows.Forms.Panel pnlStat1;
        private System.Windows.Forms.Label lblStat1Icon;
        private System.Windows.Forms.Label lblStat1Change;
        private System.Windows.Forms.Label lblStat1Title;
        private System.Windows.Forms.Label lblStat1Value;

        private System.Windows.Forms.Panel pnlStat2;
        private System.Windows.Forms.Label lblStat2Icon;
        private System.Windows.Forms.Label lblStat2Change;
        private System.Windows.Forms.Label lblStat2Title;
        private System.Windows.Forms.Label lblStat2Value;

        private System.Windows.Forms.Panel pnlStat3;
        private System.Windows.Forms.Label lblStat3Icon;
        private System.Windows.Forms.Label lblStat3Change;
        private System.Windows.Forms.Label lblStat3Title;
        private System.Windows.Forms.Label lblStat3Value;

        private System.Windows.Forms.Panel pnlChartCard;
        private System.Windows.Forms.Label lblChartTitle;
        private CapitalControl.Controls.DashboardDonut donutChart;
        private System.Windows.Forms.Label lblLegend1Swatch;
        private System.Windows.Forms.Label lblLegend1Text;
        private System.Windows.Forms.Label lblLegend2Swatch;
        private System.Windows.Forms.Label lblLegend2Text;
        private System.Windows.Forms.Label lblLegend3Swatch;
        private System.Windows.Forms.Label lblLegend3Text;
        private System.Windows.Forms.Label lblLegend4Swatch;
        private System.Windows.Forms.Label lblLegend4Text;
        private System.Windows.Forms.Label lblLegend5Swatch;
        private System.Windows.Forms.Label lblLegend5Text;
        private System.Windows.Forms.Label lblLegend6Swatch;
        private System.Windows.Forms.Label lblLegend6Text;
        private System.Windows.Forms.Label lblLegend7Swatch;
        private System.Windows.Forms.Label lblLegend7Text;

        private System.Windows.Forms.Panel pnlPaymentsCard;
        private System.Windows.Forms.Label lblPaymentsTitle;

        private System.Windows.Forms.Panel pnlPay1;
        private System.Windows.Forms.Label lblPay1Name;
        private System.Windows.Forms.Label lblPay1Date;
        private System.Windows.Forms.Label lblPay1Amount;
        private System.Windows.Forms.Label lblPay1Urgent;

        private System.Windows.Forms.Panel pnlPay2;
        private System.Windows.Forms.Label lblPay2Name;
        private System.Windows.Forms.Label lblPay2Date;
        private System.Windows.Forms.Label lblPay2Amount;
        private System.Windows.Forms.Label lblPay2Urgent;

        private System.Windows.Forms.Panel pnlPay3;
        private System.Windows.Forms.Label lblPay3Name;
        private System.Windows.Forms.Label lblPay3Date;
        private System.Windows.Forms.Label lblPay3Amount;
        private System.Windows.Forms.Label lblPay3Urgent;

        private System.Windows.Forms.Panel pnlPay4;
        private System.Windows.Forms.Label lblPay4Name;
        private System.Windows.Forms.Label lblPay4Date;
        private System.Windows.Forms.Label lblPay4Amount;
        private System.Windows.Forms.Label lblPay4Urgent;
    }
}
