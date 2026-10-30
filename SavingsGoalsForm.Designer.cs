namespace CapitalControl
{
    partial class SavingsGoalsForm
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
            this.pnlSummaryTarget = new System.Windows.Forms.Panel();
            this.lblSummaryTargetIcon = new System.Windows.Forms.Label();
            this.lblSummaryTargetTitle = new System.Windows.Forms.Label();
            this.lblSummaryTargetValue = new System.Windows.Forms.Label();

            this.pnlSummaryCurrent = new System.Windows.Forms.Panel();
            this.lblSummaryCurrentIcon = new System.Windows.Forms.Label();
            this.lblSummaryCurrentTitle = new System.Windows.Forms.Label();
            this.lblSummaryCurrentValue = new System.Windows.Forms.Label();

            this.pnlSummaryRemaining = new System.Windows.Forms.Panel();
            this.lblSummaryRemainingIcon = new System.Windows.Forms.Label();
            this.lblSummaryRemainingTitle = new System.Windows.Forms.Label();
            this.lblSummaryRemainingValue = new System.Windows.Forms.Label();

            this.pnlSummaryCount = new System.Windows.Forms.Panel();
            this.lblSummaryCountIcon = new System.Windows.Forms.Label();
            this.lblSummaryCountTitle = new System.Windows.Forms.Label();
            this.lblSummaryCountValue = new System.Windows.Forms.Label();

            // ---- Seccion Metas ----
            this.pnlGoalsCard = new System.Windows.Forms.Panel();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.gridGoals = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTargetDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonthly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();

            this.pnlRoot.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSummaryTarget.SuspendLayout();
            this.pnlSummaryCurrent.SuspendLayout();
            this.pnlSummaryRemaining.SuspendLayout();
            this.pnlSummaryCount.SuspendLayout();
            this.pnlGoalsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGoals)).BeginInit();
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
            this.btnNavGoals.BackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.btnNavGoals.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
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
            this.pnlMain.AutoScrollMinSize = new System.Drawing.Size(900, 700);
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlMain.Name = "pnlMain";
            //
            // lblTitle
            //
            this.lblTitle.Location = new System.Drawing.Point(28, 26);
            this.lblTitle.Size = new System.Drawing.Size(500, 34);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Metas de Ahorro";
            this.lblTitle.AutoSize = false;
            //
            // lblSubtitle
            //
            this.lblSubtitle.Location = new System.Drawing.Point(28, 60);
            this.lblSubtitle.Size = new System.Drawing.Size(560, 22);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSubtitle.Text = "Define objetivos de ahorro y sigue tu progreso";
            this.lblSubtitle.AutoSize = false;
            //
            // pnlSummaryTarget
            //
            this.pnlSummaryTarget.Location = new System.Drawing.Point(28, 96);
            this.pnlSummaryTarget.Size = new System.Drawing.Size(200, 90);
            this.pnlSummaryTarget.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlSummaryTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryTarget.Name = "pnlSummaryTarget";
            //
            // lblSummaryTargetIcon
            //
            this.lblSummaryTargetIcon.Location = new System.Drawing.Point(14, 12);
            this.lblSummaryTargetIcon.Size = new System.Drawing.Size(32, 28);
            this.lblSummaryTargetIcon.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSummaryTargetIcon.BackColor = System.Drawing.Color.FromArgb(20, 35, 55);
            this.lblSummaryTargetIcon.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.lblSummaryTargetIcon.Text = "\U0001F3AF";
            this.lblSummaryTargetIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSummaryTargetIcon.AutoSize = false;
            //
            // lblSummaryTargetTitle
            //
            this.lblSummaryTargetTitle.Location = new System.Drawing.Point(14, 44);
            this.lblSummaryTargetTitle.Size = new System.Drawing.Size(172, 18);
            this.lblSummaryTargetTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSummaryTargetTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryTargetTitle.Text = "Meta Total";
            this.lblSummaryTargetTitle.AutoSize = false;
            //
            // lblSummaryTargetValue
            //
            this.lblSummaryTargetValue.Location = new System.Drawing.Point(14, 60);
            this.lblSummaryTargetValue.Size = new System.Drawing.Size(172, 24);
            this.lblSummaryTargetValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTargetValue.ForeColor = System.Drawing.Color.White;
            this.lblSummaryTargetValue.Text = "$0";
            this.lblSummaryTargetValue.AutoSize = false;
            //
            // pnlSummaryCurrent
            //
            this.pnlSummaryCurrent.Location = new System.Drawing.Point(240, 96);
            this.pnlSummaryCurrent.Size = new System.Drawing.Size(200, 90);
            this.pnlSummaryCurrent.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlSummaryCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryCurrent.Name = "pnlSummaryCurrent";
            //
            // lblSummaryCurrentIcon
            //
            this.lblSummaryCurrentIcon.Location = new System.Drawing.Point(14, 12);
            this.lblSummaryCurrentIcon.Size = new System.Drawing.Size(32, 28);
            this.lblSummaryCurrentIcon.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSummaryCurrentIcon.BackColor = System.Drawing.Color.FromArgb(20, 45, 35);
            this.lblSummaryCurrentIcon.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblSummaryCurrentIcon.Text = "\u2714";
            this.lblSummaryCurrentIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSummaryCurrentIcon.AutoSize = false;
            //
            // lblSummaryCurrentTitle
            //
            this.lblSummaryCurrentTitle.Location = new System.Drawing.Point(14, 44);
            this.lblSummaryCurrentTitle.Size = new System.Drawing.Size(172, 18);
            this.lblSummaryCurrentTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSummaryCurrentTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryCurrentTitle.Text = "Total Ahorrado";
            this.lblSummaryCurrentTitle.AutoSize = false;
            //
            // lblSummaryCurrentValue
            //
            this.lblSummaryCurrentValue.Location = new System.Drawing.Point(14, 60);
            this.lblSummaryCurrentValue.Size = new System.Drawing.Size(172, 24);
            this.lblSummaryCurrentValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryCurrentValue.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblSummaryCurrentValue.Text = "$0";
            this.lblSummaryCurrentValue.AutoSize = false;
            //
            // pnlSummaryRemaining
            //
            this.pnlSummaryRemaining.Location = new System.Drawing.Point(452, 96);
            this.pnlSummaryRemaining.Size = new System.Drawing.Size(200, 90);
            this.pnlSummaryRemaining.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlSummaryRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryRemaining.Name = "pnlSummaryRemaining";
            //
            // lblSummaryRemainingIcon
            //
            this.lblSummaryRemainingIcon.Location = new System.Drawing.Point(14, 12);
            this.lblSummaryRemainingIcon.Size = new System.Drawing.Size(32, 28);
            this.lblSummaryRemainingIcon.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblSummaryRemainingIcon.BackColor = System.Drawing.Color.FromArgb(58, 47, 22);
            this.lblSummaryRemainingIcon.ForeColor = System.Drawing.Color.FromArgb(234, 179, 8);
            this.lblSummaryRemainingIcon.Text = "\u23F3";
            this.lblSummaryRemainingIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSummaryRemainingIcon.AutoSize = false;
            //
            // lblSummaryRemainingTitle
            //
            this.lblSummaryRemainingTitle.Location = new System.Drawing.Point(14, 44);
            this.lblSummaryRemainingTitle.Size = new System.Drawing.Size(172, 18);
            this.lblSummaryRemainingTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSummaryRemainingTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryRemainingTitle.Text = "Falta por Ahorrar";
            this.lblSummaryRemainingTitle.AutoSize = false;
            //
            // lblSummaryRemainingValue
            //
            this.lblSummaryRemainingValue.Location = new System.Drawing.Point(14, 60);
            this.lblSummaryRemainingValue.Size = new System.Drawing.Size(172, 24);
            this.lblSummaryRemainingValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryRemainingValue.ForeColor = System.Drawing.Color.FromArgb(234, 179, 8);
            this.lblSummaryRemainingValue.Text = "$0";
            this.lblSummaryRemainingValue.AutoSize = false;
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
            this.lblSummaryCountIcon.BackColor = System.Drawing.Color.FromArgb(42, 30, 58);
            this.lblSummaryCountIcon.ForeColor = System.Drawing.Color.FromArgb(168, 85, 247);
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
            this.lblSummaryCountTitle.Text = "Metas Activas";
            this.lblSummaryCountTitle.AutoSize = false;
            //
            // lblSummaryCountValue
            //
            this.lblSummaryCountValue.Location = new System.Drawing.Point(14, 60);
            this.lblSummaryCountValue.Size = new System.Drawing.Size(172, 24);
            this.lblSummaryCountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryCountValue.ForeColor = System.Drawing.Color.FromArgb(168, 85, 247);
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
            this.btnAdd.Text = "\u2795 Agregar Nueva Meta";
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Name = "btnAdd";
            //
            // pnlGoalsCard
            //
            this.pnlGoalsCard.Location = new System.Drawing.Point(28, 264);
            this.pnlGoalsCard.Size = new System.Drawing.Size(852, 400);
            this.pnlGoalsCard.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlGoalsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGoalsCard.Name = "pnlGoalsCard";
            //
            // lblEmpty
            //
            this.lblEmpty.Location = new System.Drawing.Point(0, 180);
            this.lblEmpty.Size = new System.Drawing.Size(850, 30);
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblEmpty.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblEmpty.Text = "No tienes metas de ahorro registradas";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpty.Visible = false;
            this.lblEmpty.AutoSize = false;
            //
            // gridGoals
            //
            this.gridGoals.Location = new System.Drawing.Point(1, 1);
            this.gridGoals.Size = new System.Drawing.Size(848, 396);
            this.gridGoals.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.gridGoals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridGoals.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.gridGoals.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridGoals.AllowUserToAddRows = false;
            this.gridGoals.AllowUserToDeleteRows = false;
            this.gridGoals.AllowUserToResizeRows = false;
            this.gridGoals.RowHeadersVisible = false;
            this.gridGoals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGoals.MultiSelect = false;
            this.gridGoals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridGoals.ColumnHeadersHeight = 34;
            this.gridGoals.RowTemplate.Height = 36;
            this.gridGoals.EnableHeadersVisualStyles = false;
            this.gridGoals.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.gridGoals.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.gridGoals.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.gridGoals.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridGoals.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.gridGoals.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.gridGoals.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.gridGoals.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridGoals.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(42, 42, 44);
            this.gridGoals.Name = "gridGoals";
            //
            // colName
            //
            this.colName.HeaderText = "Meta";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.FillWeight = 150;
            //
            // colCategory
            //
            this.colCategory.HeaderText = "Categoria";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.FillWeight = 110;
            //
            // colProgress
            //
            this.colProgress.HeaderText = "Progreso";
            this.colProgress.Name = "colProgress";
            this.colProgress.ReadOnly = true;
            this.colProgress.FillWeight = 80;
            //
            // colTarget
            //
            this.colTarget.HeaderText = "Meta";
            this.colTarget.Name = "colTarget";
            this.colTarget.ReadOnly = true;
            this.colTarget.FillWeight = 100;
            //
            // colCurrent
            //
            this.colCurrent.HeaderText = "Ahorrado";
            this.colCurrent.Name = "colCurrent";
            this.colCurrent.ReadOnly = true;
            this.colCurrent.FillWeight = 100;
            //
            // colRemaining
            //
            this.colRemaining.HeaderText = "Restante";
            this.colRemaining.Name = "colRemaining";
            this.colRemaining.ReadOnly = true;
            this.colRemaining.FillWeight = 100;
            //
            // colTargetDate
            //
            this.colTargetDate.HeaderText = "Fecha Meta";
            this.colTargetDate.Name = "colTargetDate";
            this.colTargetDate.ReadOnly = true;
            this.colTargetDate.FillWeight = 110;
            //
            // colMonthly
            //
            this.colMonthly.HeaderText = "Mensual Req.";
            this.colMonthly.Name = "colMonthly";
            this.colMonthly.ReadOnly = true;
            this.colMonthly.FillWeight = 110;
            //
            // colAction
            //
            this.colAction.HeaderText = "";
            this.colAction.Name = "colAction";
            this.colAction.Text = "Abonar / Editar";
            this.colAction.UseColumnTextForButtonValue = true;
            this.colAction.FillWeight = 150;
            this.colAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.gridGoals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colName,
                this.colCategory,
                this.colProgress,
                this.colTarget,
                this.colCurrent,
                this.colRemaining,
                this.colTargetDate,
                this.colMonthly,
                this.colAction});

            // ---- Composicion de controles ----
            this.pnlSummaryTarget.Controls.Add(this.lblSummaryTargetIcon);
            this.pnlSummaryTarget.Controls.Add(this.lblSummaryTargetTitle);
            this.pnlSummaryTarget.Controls.Add(this.lblSummaryTargetValue);

            this.pnlSummaryCurrent.Controls.Add(this.lblSummaryCurrentIcon);
            this.pnlSummaryCurrent.Controls.Add(this.lblSummaryCurrentTitle);
            this.pnlSummaryCurrent.Controls.Add(this.lblSummaryCurrentValue);

            this.pnlSummaryRemaining.Controls.Add(this.lblSummaryRemainingIcon);
            this.pnlSummaryRemaining.Controls.Add(this.lblSummaryRemainingTitle);
            this.pnlSummaryRemaining.Controls.Add(this.lblSummaryRemainingValue);

            this.pnlSummaryCount.Controls.Add(this.lblSummaryCountIcon);
            this.pnlSummaryCount.Controls.Add(this.lblSummaryCountTitle);
            this.pnlSummaryCount.Controls.Add(this.lblSummaryCountValue);

            this.pnlGoalsCard.Controls.Add(this.gridGoals);
            this.pnlGoalsCard.Controls.Add(this.lblEmpty);

            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblSubtitle);
            this.pnlMain.Controls.Add(this.pnlSummaryTarget);
            this.pnlMain.Controls.Add(this.pnlSummaryCurrent);
            this.pnlMain.Controls.Add(this.pnlSummaryRemaining);
            this.pnlMain.Controls.Add(this.pnlSummaryCount);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.pnlGoalsCard);

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
            // SavingsGoalsForm
            //
            this.ClientSize = new System.Drawing.Size(1580, 780);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Text = "Capital Control - Metas de Ahorro (Vista previa)";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            ((System.ComponentModel.ISupportInitialize)(this.gridGoals)).EndInit();
            this.pnlGoalsCard.ResumeLayout(false);
            this.pnlSummaryCount.ResumeLayout(false);
            this.pnlSummaryRemaining.ResumeLayout(false);
            this.pnlSummaryCurrent.ResumeLayout(false);
            this.pnlSummaryTarget.ResumeLayout(false);
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

        private System.Windows.Forms.Panel pnlSummaryTarget;
        private System.Windows.Forms.Label lblSummaryTargetIcon;
        private System.Windows.Forms.Label lblSummaryTargetTitle;
        private System.Windows.Forms.Label lblSummaryTargetValue;

        private System.Windows.Forms.Panel pnlSummaryCurrent;
        private System.Windows.Forms.Label lblSummaryCurrentIcon;
        private System.Windows.Forms.Label lblSummaryCurrentTitle;
        private System.Windows.Forms.Label lblSummaryCurrentValue;

        private System.Windows.Forms.Panel pnlSummaryRemaining;
        private System.Windows.Forms.Label lblSummaryRemainingIcon;
        private System.Windows.Forms.Label lblSummaryRemainingTitle;
        private System.Windows.Forms.Label lblSummaryRemainingValue;

        private System.Windows.Forms.Panel pnlSummaryCount;
        private System.Windows.Forms.Label lblSummaryCountIcon;
        private System.Windows.Forms.Label lblSummaryCountTitle;
        private System.Windows.Forms.Label lblSummaryCountValue;

        private System.Windows.Forms.Panel pnlGoalsCard;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.DataGridView gridGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTargetDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonthly;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}
