namespace CapitalControl
{
    partial class MembershipsForm
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

            // ---- Barra lateral de navegacion ----
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

            // ---- Contenido principal ----
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();

            // ---- Tarjetas de resumen ----
            this.pnlSummaryActive = new System.Windows.Forms.Panel();
            this.lblSummaryActiveIcon = new System.Windows.Forms.Label();
            this.lblSummaryActiveTitle = new System.Windows.Forms.Label();
            this.lblSummaryActiveValue = new System.Windows.Forms.Label();

            this.pnlSummaryMonthly = new System.Windows.Forms.Panel();
            this.lblSummaryMonthlyIcon = new System.Windows.Forms.Label();
            this.lblSummaryMonthlyTitle = new System.Windows.Forms.Label();
            this.lblSummaryMonthlyValue = new System.Windows.Forms.Label();

            this.pnlSummaryAnnual = new System.Windows.Forms.Panel();
            this.lblSummaryAnnualIcon = new System.Windows.Forms.Label();
            this.lblSummaryAnnualTitle = new System.Windows.Forms.Label();
            this.lblSummaryAnnualValue = new System.Windows.Forms.Label();

            // ---- Proyeccion de costos ----
            this.pnlProjection = new System.Windows.Forms.Panel();
            this.lblProjectionTitle = new System.Windows.Forms.Label();
            this.lblProjMonthlyTitle = new System.Windows.Forms.Label();
            this.lblProjMonthlyValue = new System.Windows.Forms.Label();
            this.lblProjQuarterlyTitle = new System.Windows.Forms.Label();
            this.lblProjQuarterlyValue = new System.Windows.Forms.Label();
            this.lblProjSemiannualTitle = new System.Windows.Forms.Label();
            this.lblProjSemiannualValue = new System.Windows.Forms.Label();
            this.lblProjAnnualTitle = new System.Windows.Forms.Label();
            this.lblProjAnnualValue = new System.Windows.Forms.Label();

            // ---- Tabla de membresias ----
            this.pnlListCard = new System.Windows.Forms.Panel();
            this.lblEmptyBox = new System.Windows.Forms.Label();
            this.gridMemberships = new System.Windows.Forms.DataGridView();
            this.colLogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlRoot.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSummaryActive.SuspendLayout();
            this.pnlSummaryMonthly.SuspendLayout();
            this.pnlSummaryAnnual.SuspendLayout();
            this.pnlProjection.SuspendLayout();
            this.pnlListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMemberships)).BeginInit();
            this.SuspendLayout();
            //
            // pnlRoot
            //
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlRoot.Name = "pnlRoot";
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
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
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
            this.btnNavMemberships.BackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.btnNavMemberships.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
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
            this.pnlMain.AutoScrollMinSize = new System.Drawing.Size(900, 1000);
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlMain.Name = "pnlMain";
            //
            // lblTitle
            //
            this.lblTitle.Location = new System.Drawing.Point(28, 26);
            this.lblTitle.Size = new System.Drawing.Size(500, 34);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Membresias y Suscripciones";
            this.lblTitle.AutoSize = false;
            //
            // lblSubtitle
            //
            this.lblSubtitle.Location = new System.Drawing.Point(28, 60);
            this.lblSubtitle.Size = new System.Drawing.Size(500, 22);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSubtitle.Text = "Controla tus pagos recurrentes";
            this.lblSubtitle.AutoSize = false;
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(700, 28);
            this.btnAdd.Size = new System.Drawing.Size(180, 40);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 184, 107);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Text = "\u2795 Nueva Membresia";
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Name = "btnAdd";
            //
            // pnlSummaryActive
            //
            this.pnlSummaryActive.Location = new System.Drawing.Point(28, 96);
            this.pnlSummaryActive.Size = new System.Drawing.Size(276, 90);
            this.pnlSummaryActive.BackColor = System.Drawing.Color.FromArgb(26, 35, 50);
            this.pnlSummaryActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryActive.Name = "pnlSummaryActive";
            //
            // lblSummaryActiveIcon
            //
            this.lblSummaryActiveIcon.Location = new System.Drawing.Point(16, 14);
            this.lblSummaryActiveIcon.Size = new System.Drawing.Size(34, 30);
            this.lblSummaryActiveIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSummaryActiveIcon.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.lblSummaryActiveIcon.Text = "\U0001F4B3";
            this.lblSummaryActiveIcon.AutoSize = false;
            //
            // lblSummaryActiveTitle
            //
            this.lblSummaryActiveTitle.Location = new System.Drawing.Point(16, 46);
            this.lblSummaryActiveTitle.Size = new System.Drawing.Size(240, 18);
            this.lblSummaryActiveTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSummaryActiveTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryActiveTitle.Text = "Membresias Activas";
            this.lblSummaryActiveTitle.AutoSize = false;
            //
            // lblSummaryActiveValue
            //
            this.lblSummaryActiveValue.Location = new System.Drawing.Point(16, 62);
            this.lblSummaryActiveValue.Size = new System.Drawing.Size(240, 24);
            this.lblSummaryActiveValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSummaryActiveValue.ForeColor = System.Drawing.Color.White;
            this.lblSummaryActiveValue.Text = "0";
            this.lblSummaryActiveValue.AutoSize = false;
            //
            // pnlSummaryMonthly
            //
            this.pnlSummaryMonthly.Location = new System.Drawing.Point(316, 96);
            this.pnlSummaryMonthly.Size = new System.Drawing.Size(276, 90);
            this.pnlSummaryMonthly.BackColor = System.Drawing.Color.FromArgb(42, 30, 58);
            this.pnlSummaryMonthly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryMonthly.Name = "pnlSummaryMonthly";
            //
            // lblSummaryMonthlyIcon
            //
            this.lblSummaryMonthlyIcon.Location = new System.Drawing.Point(16, 14);
            this.lblSummaryMonthlyIcon.Size = new System.Drawing.Size(34, 30);
            this.lblSummaryMonthlyIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSummaryMonthlyIcon.ForeColor = System.Drawing.Color.FromArgb(168, 85, 247);
            this.lblSummaryMonthlyIcon.Text = "\U0001F4C5";
            this.lblSummaryMonthlyIcon.AutoSize = false;
            //
            // lblSummaryMonthlyTitle
            //
            this.lblSummaryMonthlyTitle.Location = new System.Drawing.Point(16, 46);
            this.lblSummaryMonthlyTitle.Size = new System.Drawing.Size(240, 18);
            this.lblSummaryMonthlyTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSummaryMonthlyTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryMonthlyTitle.Text = "Gasto Mensual";
            this.lblSummaryMonthlyTitle.AutoSize = false;
            //
            // lblSummaryMonthlyValue
            //
            this.lblSummaryMonthlyValue.Location = new System.Drawing.Point(16, 62);
            this.lblSummaryMonthlyValue.Size = new System.Drawing.Size(240, 24);
            this.lblSummaryMonthlyValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSummaryMonthlyValue.ForeColor = System.Drawing.Color.FromArgb(168, 85, 247);
            this.lblSummaryMonthlyValue.Text = "$0";
            this.lblSummaryMonthlyValue.AutoSize = false;
            //
            // pnlSummaryAnnual
            //
            this.pnlSummaryAnnual.Location = new System.Drawing.Point(604, 96);
            this.pnlSummaryAnnual.Size = new System.Drawing.Size(276, 90);
            this.pnlSummaryAnnual.BackColor = System.Drawing.Color.FromArgb(58, 47, 22);
            this.pnlSummaryAnnual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryAnnual.Name = "pnlSummaryAnnual";
            //
            // lblSummaryAnnualIcon
            //
            this.lblSummaryAnnualIcon.Location = new System.Drawing.Point(16, 14);
            this.lblSummaryAnnualIcon.Size = new System.Drawing.Size(34, 30);
            this.lblSummaryAnnualIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSummaryAnnualIcon.ForeColor = System.Drawing.Color.FromArgb(234, 179, 8);
            this.lblSummaryAnnualIcon.Text = "\u26A0";
            this.lblSummaryAnnualIcon.AutoSize = false;
            //
            // lblSummaryAnnualTitle
            //
            this.lblSummaryAnnualTitle.Location = new System.Drawing.Point(16, 46);
            this.lblSummaryAnnualTitle.Size = new System.Drawing.Size(240, 18);
            this.lblSummaryAnnualTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSummaryAnnualTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryAnnualTitle.Text = "Gasto Anual";
            this.lblSummaryAnnualTitle.AutoSize = false;
            //
            // lblSummaryAnnualValue
            //
            this.lblSummaryAnnualValue.Location = new System.Drawing.Point(16, 62);
            this.lblSummaryAnnualValue.Size = new System.Drawing.Size(240, 24);
            this.lblSummaryAnnualValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSummaryAnnualValue.ForeColor = System.Drawing.Color.FromArgb(234, 179, 8);
            this.lblSummaryAnnualValue.Text = "$0";
            this.lblSummaryAnnualValue.AutoSize = false;
            //
            // pnlProjection
            //
            this.pnlProjection.Location = new System.Drawing.Point(28, 200);
            this.pnlProjection.Size = new System.Drawing.Size(852, 110);
            this.pnlProjection.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlProjection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProjection.Name = "pnlProjection";
            //
            // lblProjectionTitle
            //
            this.lblProjectionTitle.Location = new System.Drawing.Point(16, 12);
            this.lblProjectionTitle.Size = new System.Drawing.Size(400, 20);
            this.lblProjectionTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblProjectionTitle.ForeColor = System.Drawing.Color.White;
            this.lblProjectionTitle.Text = "Proyeccion de Costos";
            this.lblProjectionTitle.AutoSize = false;
            //
            // lblProjMonthlyTitle
            //
            this.lblProjMonthlyTitle.Location = new System.Drawing.Point(16, 46);
            this.lblProjMonthlyTitle.Size = new System.Drawing.Size(196, 18);
            this.lblProjMonthlyTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProjMonthlyTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblProjMonthlyTitle.Text = "Costo Mensual";
            this.lblProjMonthlyTitle.AutoSize = false;
            //
            // lblProjMonthlyValue
            //
            this.lblProjMonthlyValue.Location = new System.Drawing.Point(16, 66);
            this.lblProjMonthlyValue.Size = new System.Drawing.Size(196, 26);
            this.lblProjMonthlyValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProjMonthlyValue.ForeColor = System.Drawing.Color.White;
            this.lblProjMonthlyValue.Text = "$0";
            this.lblProjMonthlyValue.AutoSize = false;
            //
            // lblProjQuarterlyTitle
            //
            this.lblProjQuarterlyTitle.Location = new System.Drawing.Point(228, 46);
            this.lblProjQuarterlyTitle.Size = new System.Drawing.Size(196, 18);
            this.lblProjQuarterlyTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProjQuarterlyTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblProjQuarterlyTitle.Text = "Costo Trimestral";
            this.lblProjQuarterlyTitle.AutoSize = false;
            //
            // lblProjQuarterlyValue
            //
            this.lblProjQuarterlyValue.Location = new System.Drawing.Point(228, 66);
            this.lblProjQuarterlyValue.Size = new System.Drawing.Size(196, 26);
            this.lblProjQuarterlyValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProjQuarterlyValue.ForeColor = System.Drawing.Color.White;
            this.lblProjQuarterlyValue.Text = "$0";
            this.lblProjQuarterlyValue.AutoSize = false;
            //
            // lblProjSemiannualTitle
            //
            this.lblProjSemiannualTitle.Location = new System.Drawing.Point(440, 46);
            this.lblProjSemiannualTitle.Size = new System.Drawing.Size(196, 18);
            this.lblProjSemiannualTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProjSemiannualTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblProjSemiannualTitle.Text = "Costo Semestral";
            this.lblProjSemiannualTitle.AutoSize = false;
            //
            // lblProjSemiannualValue
            //
            this.lblProjSemiannualValue.Location = new System.Drawing.Point(440, 66);
            this.lblProjSemiannualValue.Size = new System.Drawing.Size(196, 26);
            this.lblProjSemiannualValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProjSemiannualValue.ForeColor = System.Drawing.Color.White;
            this.lblProjSemiannualValue.Text = "$0";
            this.lblProjSemiannualValue.AutoSize = false;
            //
            // lblProjAnnualTitle
            //
            this.lblProjAnnualTitle.Location = new System.Drawing.Point(652, 46);
            this.lblProjAnnualTitle.Size = new System.Drawing.Size(184, 18);
            this.lblProjAnnualTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProjAnnualTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblProjAnnualTitle.Text = "Costo Anual";
            this.lblProjAnnualTitle.AutoSize = false;
            //
            // lblProjAnnualValue
            //
            this.lblProjAnnualValue.Location = new System.Drawing.Point(652, 66);
            this.lblProjAnnualValue.Size = new System.Drawing.Size(184, 26);
            this.lblProjAnnualValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProjAnnualValue.ForeColor = System.Drawing.Color.White;
            this.lblProjAnnualValue.Text = "$0";
            this.lblProjAnnualValue.AutoSize = false;
            //
            // pnlListCard
            //
            this.pnlListCard.Location = new System.Drawing.Point(28, 326);
            this.pnlListCard.Size = new System.Drawing.Size(852, 460);
            this.pnlListCard.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlListCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListCard.Name = "pnlListCard";
            //
            // lblEmptyBox
            //
            this.lblEmptyBox.Location = new System.Drawing.Point(0, 200);
            this.lblEmptyBox.Size = new System.Drawing.Size(850, 60);
            this.lblEmptyBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmptyBox.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblEmptyBox.Text = "No tienes membresias registradas";
            this.lblEmptyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyBox.Visible = false;
            this.lblEmptyBox.AutoSize = false;
            //
            // gridMemberships
            //
            this.gridMemberships.Location = new System.Drawing.Point(1, 1);
            this.gridMemberships.Size = new System.Drawing.Size(848, 456);
            this.gridMemberships.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.gridMemberships.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMemberships.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.gridMemberships.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gridMemberships.AllowUserToAddRows = false;
            this.gridMemberships.AllowUserToDeleteRows = false;
            this.gridMemberships.AllowUserToResizeRows = false;
            this.gridMemberships.RowHeadersVisible = false;
            this.gridMemberships.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMemberships.MultiSelect = false;
            this.gridMemberships.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMemberships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMemberships.ColumnHeadersHeight = 36;
            this.gridMemberships.RowTemplate.Height = 38;
            this.gridMemberships.EnableHeadersVisualStyles = false;
            this.gridMemberships.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.gridMemberships.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.gridMemberships.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.gridMemberships.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridMemberships.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.gridMemberships.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.gridMemberships.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.gridMemberships.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridMemberships.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(42, 42, 44);
            this.gridMemberships.Name = "gridMemberships";
            //
            // colLogo
            //
            this.colLogo.HeaderText = "";
            this.colLogo.Name = "colLogo";
            this.colLogo.ReadOnly = true;
            this.colLogo.FillWeight = 40;
            //
            // colName
            //
            this.colName.HeaderText = "Nombre";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.FillWeight = 160;
            //
            // colCost
            //
            this.colCost.HeaderText = "Costo Mensual";
            this.colCost.Name = "colCost";
            this.colCost.ReadOnly = true;
            this.colCost.FillWeight = 120;
            //
            // colBilling
            //
            this.colBilling.HeaderText = "Cobro";
            this.colBilling.Name = "colBilling";
            this.colBilling.ReadOnly = true;
            this.colBilling.FillWeight = 130;
            //
            // colStatus
            //
            this.colStatus.HeaderText = "Estado";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.FillWeight = 100;
            //
            // colAction
            //
            this.colAction.HeaderText = "";
            this.colAction.Name = "colAction";
            this.colAction.Text = "Editar";
            this.colAction.UseColumnTextForButtonValue = false;
            this.colAction.FillWeight = 200;
            this.colAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.gridMemberships.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colLogo,
                this.colName,
                this.colCost,
                this.colBilling,
                this.colStatus,
                this.colAction});

            // ---- Composicion de controles ----
            this.pnlSummaryActive.Controls.Add(this.lblSummaryActiveIcon);
            this.pnlSummaryActive.Controls.Add(this.lblSummaryActiveTitle);
            this.pnlSummaryActive.Controls.Add(this.lblSummaryActiveValue);

            this.pnlSummaryMonthly.Controls.Add(this.lblSummaryMonthlyIcon);
            this.pnlSummaryMonthly.Controls.Add(this.lblSummaryMonthlyTitle);
            this.pnlSummaryMonthly.Controls.Add(this.lblSummaryMonthlyValue);

            this.pnlSummaryAnnual.Controls.Add(this.lblSummaryAnnualIcon);
            this.pnlSummaryAnnual.Controls.Add(this.lblSummaryAnnualTitle);
            this.pnlSummaryAnnual.Controls.Add(this.lblSummaryAnnualValue);

            this.pnlProjection.Controls.Add(this.lblProjectionTitle);
            this.pnlProjection.Controls.Add(this.lblProjMonthlyTitle);
            this.pnlProjection.Controls.Add(this.lblProjMonthlyValue);
            this.pnlProjection.Controls.Add(this.lblProjQuarterlyTitle);
            this.pnlProjection.Controls.Add(this.lblProjQuarterlyValue);
            this.pnlProjection.Controls.Add(this.lblProjSemiannualTitle);
            this.pnlProjection.Controls.Add(this.lblProjSemiannualValue);
            this.pnlProjection.Controls.Add(this.lblProjAnnualTitle);
            this.pnlProjection.Controls.Add(this.lblProjAnnualValue);

            this.pnlListCard.Controls.Add(this.gridMemberships);
            this.pnlListCard.Controls.Add(this.lblEmptyBox);

            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblSubtitle);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.pnlSummaryActive);
            this.pnlMain.Controls.Add(this.pnlSummaryMonthly);
            this.pnlMain.Controls.Add(this.pnlSummaryAnnual);
            this.pnlMain.Controls.Add(this.pnlProjection);
            this.pnlMain.Controls.Add(this.pnlListCard);

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
            // MembershipsForm
            //
            this.ClientSize = new System.Drawing.Size(1580, 900);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Text = "Capital Control - Membresias (Vista previa)";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            ((System.ComponentModel.ISupportInitialize)(this.gridMemberships)).EndInit();
            this.pnlListCard.ResumeLayout(false);
            this.pnlProjection.ResumeLayout(false);
            this.pnlSummaryAnnual.ResumeLayout(false);
            this.pnlSummaryMonthly.ResumeLayout(false);
            this.pnlSummaryActive.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Panel pnlSummaryActive;
        private System.Windows.Forms.Label lblSummaryActiveIcon;
        private System.Windows.Forms.Label lblSummaryActiveTitle;
        private System.Windows.Forms.Label lblSummaryActiveValue;

        private System.Windows.Forms.Panel pnlSummaryMonthly;
        private System.Windows.Forms.Label lblSummaryMonthlyIcon;
        private System.Windows.Forms.Label lblSummaryMonthlyTitle;
        private System.Windows.Forms.Label lblSummaryMonthlyValue;

        private System.Windows.Forms.Panel pnlSummaryAnnual;
        private System.Windows.Forms.Label lblSummaryAnnualIcon;
        private System.Windows.Forms.Label lblSummaryAnnualTitle;
        private System.Windows.Forms.Label lblSummaryAnnualValue;

        private System.Windows.Forms.Panel pnlProjection;
        private System.Windows.Forms.Label lblProjectionTitle;
        private System.Windows.Forms.Label lblProjMonthlyTitle;
        private System.Windows.Forms.Label lblProjMonthlyValue;
        private System.Windows.Forms.Label lblProjQuarterlyTitle;
        private System.Windows.Forms.Label lblProjQuarterlyValue;
        private System.Windows.Forms.Label lblProjSemiannualTitle;
        private System.Windows.Forms.Label lblProjSemiannualValue;
        private System.Windows.Forms.Label lblProjAnnualTitle;
        private System.Windows.Forms.Label lblProjAnnualValue;

        private System.Windows.Forms.Panel pnlListCard;
        private System.Windows.Forms.Label lblEmptyBox;
        private System.Windows.Forms.DataGridView gridMemberships;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}
