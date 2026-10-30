namespace CapitalControl
{
    partial class DebtsCreditsForm
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
            this.pnlSummaryTotal = new System.Windows.Forms.Panel();
            this.lblSummaryTotalIcon = new System.Windows.Forms.Label();
            this.lblSummaryTotalTitle = new System.Windows.Forms.Label();
            this.lblSummaryTotalValue = new System.Windows.Forms.Label();

            this.pnlSummaryPaid = new System.Windows.Forms.Panel();
            this.lblSummaryPaidIcon = new System.Windows.Forms.Label();
            this.lblSummaryPaidTitle = new System.Windows.Forms.Label();
            this.lblSummaryPaidValue = new System.Windows.Forms.Label();

            this.pnlSummaryPending = new System.Windows.Forms.Panel();
            this.lblSummaryPendingIcon = new System.Windows.Forms.Label();
            this.lblSummaryPendingTitle = new System.Windows.Forms.Label();
            this.lblSummaryPendingValue = new System.Windows.Forms.Label();

            this.pnlSummaryCount = new System.Windows.Forms.Panel();
            this.lblSummaryCountIcon = new System.Windows.Forms.Label();
            this.lblSummaryCountTitle = new System.Windows.Forms.Label();
            this.lblSummaryCountValue = new System.Windows.Forms.Label();

            // ---- Seccion Deudas Bancarias ----
            this.lblBankTitle = new System.Windows.Forms.Label();
            this.lblBankCountChip = new System.Windows.Forms.Label();
            this.pnlBankCard = new System.Windows.Forms.Panel();
            this.lblBankEmpty = new System.Windows.Forms.Label();
            this.gridBank = new System.Windows.Forms.DataGridView();
            this.colBankIcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankCreditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAction = new System.Windows.Forms.DataGridViewButtonColumn();

            // ---- Seccion Deudas Personales ----
            this.lblPersonalTitle = new System.Windows.Forms.Label();
            this.lblPersonalCountChip = new System.Windows.Forms.Label();
            this.pnlPersonalCard = new System.Windows.Forms.Panel();
            this.lblPersonalEmpty = new System.Windows.Forms.Label();
            this.gridPersonal = new System.Windows.Forms.DataGridView();
            this.colPersonalIcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonalCreditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonalProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonalTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonalRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonalDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonalAction = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlRoot.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSummaryTotal.SuspendLayout();
            this.pnlSummaryPaid.SuspendLayout();
            this.pnlSummaryPending.SuspendLayout();
            this.pnlSummaryCount.SuspendLayout();
            this.pnlBankCard.SuspendLayout();
            this.pnlPersonalCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonal)).BeginInit();
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
            this.btnNavDebts.BackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.btnNavDebts.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
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
            this.pnlMain.AutoScrollMinSize = new System.Drawing.Size(900, 900);
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlMain.Name = "pnlMain";
            //
            // lblTitle
            //
            this.lblTitle.Location = new System.Drawing.Point(28, 26);
            this.lblTitle.Size = new System.Drawing.Size(500, 34);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Deudas y Creditos";
            this.lblTitle.AutoSize = false;
            //
            // lblSubtitle
            //
            this.lblSubtitle.Location = new System.Drawing.Point(28, 60);
            this.lblSubtitle.Size = new System.Drawing.Size(560, 22);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSubtitle.Text = "Controla tus obligaciones financieras y su progreso de pago";
            this.lblSubtitle.AutoSize = false;
            //
            // pnlSummaryTotal
            //
            this.pnlSummaryTotal.Location = new System.Drawing.Point(28, 96);
            this.pnlSummaryTotal.Size = new System.Drawing.Size(200, 90);
            this.pnlSummaryTotal.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlSummaryTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryTotal.Name = "pnlSummaryTotal";
            //
            // lblSummaryTotalIcon
            //
            this.lblSummaryTotalIcon.Location = new System.Drawing.Point(14, 12);
            this.lblSummaryTotalIcon.Size = new System.Drawing.Size(32, 28);
            this.lblSummaryTotalIcon.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSummaryTotalIcon.BackColor = System.Drawing.Color.FromArgb(58, 30, 30);
            this.lblSummaryTotalIcon.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblSummaryTotalIcon.Text = "\U0001F4C9";
            this.lblSummaryTotalIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSummaryTotalIcon.AutoSize = false;
            //
            // lblSummaryTotalTitle
            //
            this.lblSummaryTotalTitle.Location = new System.Drawing.Point(14, 44);
            this.lblSummaryTotalTitle.Size = new System.Drawing.Size(172, 18);
            this.lblSummaryTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSummaryTotalTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryTotalTitle.Text = "Deuda Total";
            this.lblSummaryTotalTitle.AutoSize = false;
            //
            // lblSummaryTotalValue
            //
            this.lblSummaryTotalValue.Location = new System.Drawing.Point(14, 60);
            this.lblSummaryTotalValue.Size = new System.Drawing.Size(172, 24);
            this.lblSummaryTotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTotalValue.ForeColor = System.Drawing.Color.White;
            this.lblSummaryTotalValue.Text = "$0";
            this.lblSummaryTotalValue.AutoSize = false;
            //
            // pnlSummaryPaid
            //
            this.pnlSummaryPaid.Location = new System.Drawing.Point(240, 96);
            this.pnlSummaryPaid.Size = new System.Drawing.Size(200, 90);
            this.pnlSummaryPaid.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlSummaryPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryPaid.Name = "pnlSummaryPaid";
            //
            // lblSummaryPaidIcon
            //
            this.lblSummaryPaidIcon.Location = new System.Drawing.Point(14, 12);
            this.lblSummaryPaidIcon.Size = new System.Drawing.Size(32, 28);
            this.lblSummaryPaidIcon.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSummaryPaidIcon.BackColor = System.Drawing.Color.FromArgb(20, 45, 35);
            this.lblSummaryPaidIcon.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblSummaryPaidIcon.Text = "\u2714";
            this.lblSummaryPaidIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSummaryPaidIcon.AutoSize = false;
            //
            // lblSummaryPaidTitle
            //
            this.lblSummaryPaidTitle.Location = new System.Drawing.Point(14, 44);
            this.lblSummaryPaidTitle.Size = new System.Drawing.Size(172, 18);
            this.lblSummaryPaidTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSummaryPaidTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryPaidTitle.Text = "Total Pagado";
            this.lblSummaryPaidTitle.AutoSize = false;
            //
            // lblSummaryPaidValue
            //
            this.lblSummaryPaidValue.Location = new System.Drawing.Point(14, 60);
            this.lblSummaryPaidValue.Size = new System.Drawing.Size(172, 24);
            this.lblSummaryPaidValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryPaidValue.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblSummaryPaidValue.Text = "$0";
            this.lblSummaryPaidValue.AutoSize = false;
            //
            // pnlSummaryPending
            //
            this.pnlSummaryPending.Location = new System.Drawing.Point(452, 96);
            this.pnlSummaryPending.Size = new System.Drawing.Size(200, 90);
            this.pnlSummaryPending.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlSummaryPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryPending.Name = "pnlSummaryPending";
            //
            // lblSummaryPendingIcon
            //
            this.lblSummaryPendingIcon.Location = new System.Drawing.Point(14, 12);
            this.lblSummaryPendingIcon.Size = new System.Drawing.Size(32, 28);
            this.lblSummaryPendingIcon.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSummaryPendingIcon.BackColor = System.Drawing.Color.FromArgb(58, 47, 22);
            this.lblSummaryPendingIcon.ForeColor = System.Drawing.Color.FromArgb(234, 179, 8);
            this.lblSummaryPendingIcon.Text = "\u26A0";
            this.lblSummaryPendingIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSummaryPendingIcon.AutoSize = false;
            //
            // lblSummaryPendingTitle
            //
            this.lblSummaryPendingTitle.Location = new System.Drawing.Point(14, 44);
            this.lblSummaryPendingTitle.Size = new System.Drawing.Size(172, 18);
            this.lblSummaryPendingTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSummaryPendingTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryPendingTitle.Text = "Saldo Pendiente";
            this.lblSummaryPendingTitle.AutoSize = false;
            //
            // lblSummaryPendingValue
            //
            this.lblSummaryPendingValue.Location = new System.Drawing.Point(14, 60);
            this.lblSummaryPendingValue.Size = new System.Drawing.Size(172, 24);
            this.lblSummaryPendingValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryPendingValue.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblSummaryPendingValue.Text = "$0";
            this.lblSummaryPendingValue.AutoSize = false;
            //
            // pnlSummaryCount
            //
            this.pnlSummaryCount.Location = new System.Drawing.Point(664, 96);
            this.pnlSummaryCount.Size = new System.Drawing.Size(200, 90);
            this.pnlSummaryCount.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlSummaryCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryCount.Name = "pnlSummaryCount";
            //
            // lblSummaryCountIcon
            //
            this.lblSummaryCountIcon.Location = new System.Drawing.Point(14, 12);
            this.lblSummaryCountIcon.Size = new System.Drawing.Size(32, 28);
            this.lblSummaryCountIcon.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSummaryCountIcon.BackColor = System.Drawing.Color.FromArgb(20, 35, 55);
            this.lblSummaryCountIcon.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.lblSummaryCountIcon.Text = "\U0001F4CB";
            this.lblSummaryCountIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSummaryCountIcon.AutoSize = false;
            //
            // lblSummaryCountTitle
            //
            this.lblSummaryCountTitle.Location = new System.Drawing.Point(14, 44);
            this.lblSummaryCountTitle.Size = new System.Drawing.Size(172, 18);
            this.lblSummaryCountTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSummaryCountTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryCountTitle.Text = "Obligaciones";
            this.lblSummaryCountTitle.AutoSize = false;
            //
            // lblSummaryCountValue
            //
            this.lblSummaryCountValue.Location = new System.Drawing.Point(14, 60);
            this.lblSummaryCountValue.Size = new System.Drawing.Size(172, 24);
            this.lblSummaryCountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryCountValue.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.lblSummaryCountValue.Text = "0";
            this.lblSummaryCountValue.AutoSize = false;
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(28, 206);
            this.btnAdd.Size = new System.Drawing.Size(240, 40);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 184, 107);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Text = "\u2795 Agregar Nueva Deuda";
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Name = "btnAdd";
            //
            // lblBankTitle
            //
            this.lblBankTitle.Location = new System.Drawing.Point(28, 264);
            this.lblBankTitle.Size = new System.Drawing.Size(190, 26);
            this.lblBankTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBankTitle.ForeColor = System.Drawing.Color.White;
            this.lblBankTitle.Text = "Deudas Bancarias";
            this.lblBankTitle.AutoSize = false;
            //
            // lblBankCountChip
            //
            this.lblBankCountChip.Location = new System.Drawing.Point(220, 266);
            this.lblBankCountChip.Size = new System.Drawing.Size(36, 22);
            this.lblBankCountChip.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblBankCountChip.BackColor = System.Drawing.Color.FromArgb(20, 35, 55);
            this.lblBankCountChip.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.lblBankCountChip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBankCountChip.Text = "0";
            this.lblBankCountChip.AutoSize = false;
            //
            // pnlBankCard
            //
            this.pnlBankCard.Location = new System.Drawing.Point(28, 298);
            this.pnlBankCard.Size = new System.Drawing.Size(852, 230);
            this.pnlBankCard.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlBankCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBankCard.Name = "pnlBankCard";
            //
            // lblBankEmpty
            //
            this.lblBankEmpty.Location = new System.Drawing.Point(0, 100);
            this.lblBankEmpty.Size = new System.Drawing.Size(850, 30);
            this.lblBankEmpty.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblBankEmpty.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblBankEmpty.Text = "No tienes deudas bancarias registradas";
            this.lblBankEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBankEmpty.Visible = false;
            this.lblBankEmpty.AutoSize = false;
            //
            // gridBank
            //
            this.gridBank.Location = new System.Drawing.Point(1, 1);
            this.gridBank.Size = new System.Drawing.Size(848, 226);
            this.gridBank.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.gridBank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBank.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.gridBank.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridBank.AllowUserToAddRows = false;
            this.gridBank.AllowUserToDeleteRows = false;
            this.gridBank.AllowUserToResizeRows = false;
            this.gridBank.RowHeadersVisible = false;
            this.gridBank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBank.MultiSelect = false;
            this.gridBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridBank.ColumnHeadersHeight = 34;
            this.gridBank.RowTemplate.Height = 36;
            this.gridBank.EnableHeadersVisualStyles = false;
            this.gridBank.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.gridBank.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.gridBank.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.gridBank.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridBank.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.gridBank.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.gridBank.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.gridBank.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridBank.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(42, 42, 44);
            this.gridBank.Name = "gridBank";
            //
            // colBankIcon
            //
            this.colBankIcon.HeaderText = "";
            this.colBankIcon.Name = "colBankIcon";
            this.colBankIcon.ReadOnly = true;
            this.colBankIcon.FillWeight = 30;
            //
            // colBankCreditor
            //
            this.colBankCreditor.HeaderText = "Acreedor";
            this.colBankCreditor.Name = "colBankCreditor";
            this.colBankCreditor.ReadOnly = true;
            this.colBankCreditor.FillWeight = 190;
            //
            // colBankProgress
            //
            this.colBankProgress.HeaderText = "Progreso";
            this.colBankProgress.Name = "colBankProgress";
            this.colBankProgress.ReadOnly = true;
            this.colBankProgress.FillWeight = 90;
            //
            // colBankTotal
            //
            this.colBankTotal.HeaderText = "Total";
            this.colBankTotal.Name = "colBankTotal";
            this.colBankTotal.ReadOnly = true;
            this.colBankTotal.FillWeight = 120;
            //
            // colBankPaid
            //
            this.colBankPaid.HeaderText = "Pagado";
            this.colBankPaid.Name = "colBankPaid";
            this.colBankPaid.ReadOnly = true;
            this.colBankPaid.FillWeight = 120;
            //
            // colBankRemaining
            //
            this.colBankRemaining.HeaderText = "Restante";
            this.colBankRemaining.Name = "colBankRemaining";
            this.colBankRemaining.ReadOnly = true;
            this.colBankRemaining.FillWeight = 120;
            //
            // colBankDue
            //
            this.colBankDue.HeaderText = "Vencimiento";
            this.colBankDue.Name = "colBankDue";
            this.colBankDue.ReadOnly = true;
            this.colBankDue.FillWeight = 120;
            //
            // colBankAction
            //
            this.colBankAction.HeaderText = "";
            this.colBankAction.Name = "colBankAction";
            this.colBankAction.Text = "Pagar / Editar";
            this.colBankAction.UseColumnTextForButtonValue = true;
            this.colBankAction.FillWeight = 160;
            this.colBankAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.gridBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colBankIcon,
                this.colBankCreditor,
                this.colBankProgress,
                this.colBankTotal,
                this.colBankPaid,
                this.colBankRemaining,
                this.colBankDue,
                this.colBankAction});
            //
            // lblPersonalTitle
            //
            this.lblPersonalTitle.Location = new System.Drawing.Point(28, 542);
            this.lblPersonalTitle.Size = new System.Drawing.Size(190, 26);
            this.lblPersonalTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPersonalTitle.ForeColor = System.Drawing.Color.White;
            this.lblPersonalTitle.Text = "Deudas Personales";
            this.lblPersonalTitle.AutoSize = false;
            //
            // lblPersonalCountChip
            //
            this.lblPersonalCountChip.Location = new System.Drawing.Point(224, 544);
            this.lblPersonalCountChip.Size = new System.Drawing.Size(36, 22);
            this.lblPersonalCountChip.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPersonalCountChip.BackColor = System.Drawing.Color.FromArgb(42, 30, 58);
            this.lblPersonalCountChip.ForeColor = System.Drawing.Color.FromArgb(168, 85, 247);
            this.lblPersonalCountChip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPersonalCountChip.Text = "0";
            this.lblPersonalCountChip.AutoSize = false;
            //
            // pnlPersonalCard
            //
            this.pnlPersonalCard.Location = new System.Drawing.Point(28, 576);
            this.pnlPersonalCard.Size = new System.Drawing.Size(852, 230);
            this.pnlPersonalCard.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlPersonalCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPersonalCard.Name = "pnlPersonalCard";
            //
            // lblPersonalEmpty
            //
            this.lblPersonalEmpty.Location = new System.Drawing.Point(0, 100);
            this.lblPersonalEmpty.Size = new System.Drawing.Size(850, 30);
            this.lblPersonalEmpty.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblPersonalEmpty.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblPersonalEmpty.Text = "No tienes deudas personales registradas";
            this.lblPersonalEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPersonalEmpty.Visible = false;
            this.lblPersonalEmpty.AutoSize = false;
            //
            // gridPersonal
            //
            this.gridPersonal.Location = new System.Drawing.Point(1, 1);
            this.gridPersonal.Size = new System.Drawing.Size(848, 226);
            this.gridPersonal.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.gridPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPersonal.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.gridPersonal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridPersonal.AllowUserToAddRows = false;
            this.gridPersonal.AllowUserToDeleteRows = false;
            this.gridPersonal.AllowUserToResizeRows = false;
            this.gridPersonal.RowHeadersVisible = false;
            this.gridPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonal.MultiSelect = false;
            this.gridPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPersonal.ColumnHeadersHeight = 34;
            this.gridPersonal.RowTemplate.Height = 36;
            this.gridPersonal.EnableHeadersVisualStyles = false;
            this.gridPersonal.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.gridPersonal.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.gridPersonal.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.gridPersonal.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridPersonal.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.gridPersonal.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.gridPersonal.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.gridPersonal.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridPersonal.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(42, 42, 44);
            this.gridPersonal.Name = "gridPersonal";
            //
            // colPersonalIcon
            //
            this.colPersonalIcon.HeaderText = "";
            this.colPersonalIcon.Name = "colPersonalIcon";
            this.colPersonalIcon.ReadOnly = true;
            this.colPersonalIcon.FillWeight = 30;
            //
            // colPersonalCreditor
            //
            this.colPersonalCreditor.HeaderText = "Acreedor";
            this.colPersonalCreditor.Name = "colPersonalCreditor";
            this.colPersonalCreditor.ReadOnly = true;
            this.colPersonalCreditor.FillWeight = 190;
            //
            // colPersonalProgress
            //
            this.colPersonalProgress.HeaderText = "Progreso";
            this.colPersonalProgress.Name = "colPersonalProgress";
            this.colPersonalProgress.ReadOnly = true;
            this.colPersonalProgress.FillWeight = 90;
            //
            // colPersonalTotal
            //
            this.colPersonalTotal.HeaderText = "Total";
            this.colPersonalTotal.Name = "colPersonalTotal";
            this.colPersonalTotal.ReadOnly = true;
            this.colPersonalTotal.FillWeight = 120;
            //
            // colPersonalPaid
            //
            this.colPersonalPaid.HeaderText = "Pagado";
            this.colPersonalPaid.Name = "colPersonalPaid";
            this.colPersonalPaid.ReadOnly = true;
            this.colPersonalPaid.FillWeight = 120;
            //
            // colPersonalRemaining
            //
            this.colPersonalRemaining.HeaderText = "Restante";
            this.colPersonalRemaining.Name = "colPersonalRemaining";
            this.colPersonalRemaining.ReadOnly = true;
            this.colPersonalRemaining.FillWeight = 120;
            //
            // colPersonalDue
            //
            this.colPersonalDue.HeaderText = "Vencimiento";
            this.colPersonalDue.Name = "colPersonalDue";
            this.colPersonalDue.ReadOnly = true;
            this.colPersonalDue.FillWeight = 120;
            //
            // colPersonalAction
            //
            this.colPersonalAction.HeaderText = "";
            this.colPersonalAction.Name = "colPersonalAction";
            this.colPersonalAction.Text = "Pagar / Editar";
            this.colPersonalAction.UseColumnTextForButtonValue = true;
            this.colPersonalAction.FillWeight = 160;
            this.colPersonalAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.gridPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colPersonalIcon,
                this.colPersonalCreditor,
                this.colPersonalProgress,
                this.colPersonalTotal,
                this.colPersonalPaid,
                this.colPersonalRemaining,
                this.colPersonalDue,
                this.colPersonalAction});

            // ---- Composicion de controles ----
            this.pnlSummaryTotal.Controls.Add(this.lblSummaryTotalIcon);
            this.pnlSummaryTotal.Controls.Add(this.lblSummaryTotalTitle);
            this.pnlSummaryTotal.Controls.Add(this.lblSummaryTotalValue);

            this.pnlSummaryPaid.Controls.Add(this.lblSummaryPaidIcon);
            this.pnlSummaryPaid.Controls.Add(this.lblSummaryPaidTitle);
            this.pnlSummaryPaid.Controls.Add(this.lblSummaryPaidValue);

            this.pnlSummaryPending.Controls.Add(this.lblSummaryPendingIcon);
            this.pnlSummaryPending.Controls.Add(this.lblSummaryPendingTitle);
            this.pnlSummaryPending.Controls.Add(this.lblSummaryPendingValue);

            this.pnlSummaryCount.Controls.Add(this.lblSummaryCountIcon);
            this.pnlSummaryCount.Controls.Add(this.lblSummaryCountTitle);
            this.pnlSummaryCount.Controls.Add(this.lblSummaryCountValue);

            this.pnlBankCard.Controls.Add(this.gridBank);
            this.pnlBankCard.Controls.Add(this.lblBankEmpty);

            this.pnlPersonalCard.Controls.Add(this.gridPersonal);
            this.pnlPersonalCard.Controls.Add(this.lblPersonalEmpty);

            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblSubtitle);
            this.pnlMain.Controls.Add(this.pnlSummaryTotal);
            this.pnlMain.Controls.Add(this.pnlSummaryPaid);
            this.pnlMain.Controls.Add(this.pnlSummaryPending);
            this.pnlMain.Controls.Add(this.pnlSummaryCount);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.lblBankTitle);
            this.pnlMain.Controls.Add(this.lblBankCountChip);
            this.pnlMain.Controls.Add(this.pnlBankCard);
            this.pnlMain.Controls.Add(this.lblPersonalTitle);
            this.pnlMain.Controls.Add(this.lblPersonalCountChip);
            this.pnlMain.Controls.Add(this.pnlPersonalCard);

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
            // DebtsCreditsForm
            //
            this.ClientSize = new System.Drawing.Size(1580, 900);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Text = "Capital Control - Deudas y Creditos (Vista previa)";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            ((System.ComponentModel.ISupportInitialize)(this.gridBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonal)).EndInit();
            this.pnlPersonalCard.ResumeLayout(false);
            this.pnlBankCard.ResumeLayout(false);
            this.pnlSummaryCount.ResumeLayout(false);
            this.pnlSummaryPending.ResumeLayout(false);
            this.pnlSummaryPaid.ResumeLayout(false);
            this.pnlSummaryTotal.ResumeLayout(false);
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

        private System.Windows.Forms.Panel pnlSummaryTotal;
        private System.Windows.Forms.Label lblSummaryTotalIcon;
        private System.Windows.Forms.Label lblSummaryTotalTitle;
        private System.Windows.Forms.Label lblSummaryTotalValue;

        private System.Windows.Forms.Panel pnlSummaryPaid;
        private System.Windows.Forms.Label lblSummaryPaidIcon;
        private System.Windows.Forms.Label lblSummaryPaidTitle;
        private System.Windows.Forms.Label lblSummaryPaidValue;

        private System.Windows.Forms.Panel pnlSummaryPending;
        private System.Windows.Forms.Label lblSummaryPendingIcon;
        private System.Windows.Forms.Label lblSummaryPendingTitle;
        private System.Windows.Forms.Label lblSummaryPendingValue;

        private System.Windows.Forms.Panel pnlSummaryCount;
        private System.Windows.Forms.Label lblSummaryCountIcon;
        private System.Windows.Forms.Label lblSummaryCountTitle;
        private System.Windows.Forms.Label lblSummaryCountValue;

        private System.Windows.Forms.Label lblBankTitle;
        private System.Windows.Forms.Label lblBankCountChip;
        private System.Windows.Forms.Panel pnlBankCard;
        private System.Windows.Forms.Label lblBankEmpty;
        private System.Windows.Forms.DataGridView gridBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankCreditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankDue;
        private System.Windows.Forms.DataGridViewButtonColumn colBankAction;

        private System.Windows.Forms.Label lblPersonalTitle;
        private System.Windows.Forms.Label lblPersonalCountChip;
        private System.Windows.Forms.Panel pnlPersonalCard;
        private System.Windows.Forms.Label lblPersonalEmpty;
        private System.Windows.Forms.DataGridView gridPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonalIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonalCreditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonalProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonalTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonalPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonalRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonalDue;
        private System.Windows.Forms.DataGridViewButtonColumn colPersonalAction;
    }
}
