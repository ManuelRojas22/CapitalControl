namespace CapitalControl
{
    partial class HistoryForm
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

            // ---- Tarjetas de resumen ----
            this.pnlSummaryIncome = new System.Windows.Forms.Panel();
            this.lblSummaryIncomeIcon = new System.Windows.Forms.Label();
            this.lblSummaryIncomeTitle = new System.Windows.Forms.Label();
            this.lblSummaryIncomeValue = new System.Windows.Forms.Label();

            this.pnlSummaryExpenses = new System.Windows.Forms.Panel();
            this.lblSummaryExpensesIcon = new System.Windows.Forms.Label();
            this.lblSummaryExpensesTitle = new System.Windows.Forms.Label();
            this.lblSummaryExpensesValue = new System.Windows.Forms.Label();

            this.pnlSummaryCount = new System.Windows.Forms.Panel();
            this.lblSummaryCountIcon = new System.Windows.Forms.Label();
            this.lblSummaryCountTitle = new System.Windows.Forms.Label();
            this.lblSummaryCountValue = new System.Windows.Forms.Label();

            // ---- Filtros ----
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTypeFilterLabel = new System.Windows.Forms.Label();
            this.cmbTypeFilter = new System.Windows.Forms.ComboBox();
            this.lblCategoryFilterLabel = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();

            // ---- Tabla de transacciones ----
            this.pnlListCard = new System.Windows.Forms.Panel();
            this.lblEmptyBox = new System.Windows.Forms.Label();
            this.gridTransactions = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlRoot.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSummaryIncome.SuspendLayout();
            this.pnlSummaryExpenses.SuspendLayout();
            this.pnlSummaryCount.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).BeginInit();
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
            this.btnNavHistory.BackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.btnNavHistory.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
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
            this.lblTitle.Text = "Historial de Transacciones";
            this.lblTitle.AutoSize = false;
            //
            // lblSubtitle
            //
            this.lblSubtitle.Location = new System.Drawing.Point(28, 60);
            this.lblSubtitle.Size = new System.Drawing.Size(500, 22);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSubtitle.Text = "Consulta y filtra todos tus movimientos";
            this.lblSubtitle.AutoSize = false;
            //
            // pnlSummaryIncome
            //
            this.pnlSummaryIncome.Location = new System.Drawing.Point(28, 96);
            this.pnlSummaryIncome.Size = new System.Drawing.Size(276, 90);
            this.pnlSummaryIncome.BackColor = System.Drawing.Color.FromArgb(31, 46, 40);
            this.pnlSummaryIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryIncome.Name = "pnlSummaryIncome";
            //
            // lblSummaryIncomeIcon
            //
            this.lblSummaryIncomeIcon.Location = new System.Drawing.Point(16, 14);
            this.lblSummaryIncomeIcon.Size = new System.Drawing.Size(34, 30);
            this.lblSummaryIncomeIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSummaryIncomeIcon.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblSummaryIncomeIcon.Text = "\U0001F4C8";
            this.lblSummaryIncomeIcon.AutoSize = false;
            //
            // lblSummaryIncomeTitle
            //
            this.lblSummaryIncomeTitle.Location = new System.Drawing.Point(16, 46);
            this.lblSummaryIncomeTitle.Size = new System.Drawing.Size(240, 18);
            this.lblSummaryIncomeTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSummaryIncomeTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryIncomeTitle.Text = "Total Ingresos";
            this.lblSummaryIncomeTitle.AutoSize = false;
            //
            // lblSummaryIncomeValue
            //
            this.lblSummaryIncomeValue.Location = new System.Drawing.Point(16, 62);
            this.lblSummaryIncomeValue.Size = new System.Drawing.Size(240, 24);
            this.lblSummaryIncomeValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSummaryIncomeValue.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblSummaryIncomeValue.Text = "$0";
            this.lblSummaryIncomeValue.AutoSize = false;
            //
            // pnlSummaryExpenses
            //
            this.pnlSummaryExpenses.Location = new System.Drawing.Point(316, 96);
            this.pnlSummaryExpenses.Size = new System.Drawing.Size(276, 90);
            this.pnlSummaryExpenses.BackColor = System.Drawing.Color.FromArgb(53, 33, 33);
            this.pnlSummaryExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryExpenses.Name = "pnlSummaryExpenses";
            //
            // lblSummaryExpensesIcon
            //
            this.lblSummaryExpensesIcon.Location = new System.Drawing.Point(16, 14);
            this.lblSummaryExpensesIcon.Size = new System.Drawing.Size(34, 30);
            this.lblSummaryExpensesIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSummaryExpensesIcon.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblSummaryExpensesIcon.Text = "\U0001F4C9";
            this.lblSummaryExpensesIcon.AutoSize = false;
            //
            // lblSummaryExpensesTitle
            //
            this.lblSummaryExpensesTitle.Location = new System.Drawing.Point(16, 46);
            this.lblSummaryExpensesTitle.Size = new System.Drawing.Size(240, 18);
            this.lblSummaryExpensesTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSummaryExpensesTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryExpensesTitle.Text = "Total Gastos";
            this.lblSummaryExpensesTitle.AutoSize = false;
            //
            // lblSummaryExpensesValue
            //
            this.lblSummaryExpensesValue.Location = new System.Drawing.Point(16, 62);
            this.lblSummaryExpensesValue.Size = new System.Drawing.Size(240, 24);
            this.lblSummaryExpensesValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSummaryExpensesValue.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblSummaryExpensesValue.Text = "$0";
            this.lblSummaryExpensesValue.AutoSize = false;
            //
            // pnlSummaryCount
            //
            this.pnlSummaryCount.Location = new System.Drawing.Point(604, 96);
            this.pnlSummaryCount.Size = new System.Drawing.Size(276, 90);
            this.pnlSummaryCount.BackColor = System.Drawing.Color.FromArgb(26, 35, 50);
            this.pnlSummaryCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummaryCount.Name = "pnlSummaryCount";
            //
            // lblSummaryCountIcon
            //
            this.lblSummaryCountIcon.Location = new System.Drawing.Point(16, 14);
            this.lblSummaryCountIcon.Size = new System.Drawing.Size(34, 30);
            this.lblSummaryCountIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSummaryCountIcon.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.lblSummaryCountIcon.Text = "\U0001F501";
            this.lblSummaryCountIcon.AutoSize = false;
            //
            // lblSummaryCountTitle
            //
            this.lblSummaryCountTitle.Location = new System.Drawing.Point(16, 46);
            this.lblSummaryCountTitle.Size = new System.Drawing.Size(240, 18);
            this.lblSummaryCountTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSummaryCountTitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSummaryCountTitle.Text = "Transacciones";
            this.lblSummaryCountTitle.AutoSize = false;
            //
            // lblSummaryCountValue
            //
            this.lblSummaryCountValue.Location = new System.Drawing.Point(16, 62);
            this.lblSummaryCountValue.Size = new System.Drawing.Size(240, 24);
            this.lblSummaryCountValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSummaryCountValue.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.lblSummaryCountValue.Text = "0";
            this.lblSummaryCountValue.AutoSize = false;
            //
            // pnlFilters
            //
            this.pnlFilters.Location = new System.Drawing.Point(28, 200);
            this.pnlFilters.Size = new System.Drawing.Size(852, 84);
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Name = "pnlFilters";
            //
            // lblSearchLabel
            //
            this.lblSearchLabel.Location = new System.Drawing.Point(16, 10);
            this.lblSearchLabel.Size = new System.Drawing.Size(300, 18);
            this.lblSearchLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSearchLabel.Text = "Buscar";
            this.lblSearchLabel.AutoSize = false;
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(16, 30);
            this.txtSearch.Size = new System.Drawing.Size(360, 30);
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Name = "txtSearch";
            //
            // lblTypeFilterLabel
            //
            this.lblTypeFilterLabel.Location = new System.Drawing.Point(392, 10);
            this.lblTypeFilterLabel.Size = new System.Drawing.Size(200, 18);
            this.lblTypeFilterLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTypeFilterLabel.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblTypeFilterLabel.Text = "Tipo";
            this.lblTypeFilterLabel.AutoSize = false;
            //
            // cmbTypeFilter
            //
            this.cmbTypeFilter.Location = new System.Drawing.Point(392, 30);
            this.cmbTypeFilter.Size = new System.Drawing.Size(210, 30);
            this.cmbTypeFilter.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.cmbTypeFilter.ForeColor = System.Drawing.Color.White;
            this.cmbTypeFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTypeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeFilter.Name = "cmbTypeFilter";
            //
            // lblCategoryFilterLabel
            //
            this.lblCategoryFilterLabel.Location = new System.Drawing.Point(618, 10);
            this.lblCategoryFilterLabel.Size = new System.Drawing.Size(220, 18);
            this.lblCategoryFilterLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCategoryFilterLabel.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblCategoryFilterLabel.Text = "Categoria";
            this.lblCategoryFilterLabel.AutoSize = false;
            //
            // cmbCategoryFilter
            //
            this.cmbCategoryFilter.Location = new System.Drawing.Point(618, 30);
            this.cmbCategoryFilter.Size = new System.Drawing.Size(218, 30);
            this.cmbCategoryFilter.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.cmbCategoryFilter.ForeColor = System.Drawing.Color.White;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            //
            // pnlListCard
            //
            this.pnlListCard.Location = new System.Drawing.Point(28, 296);
            this.pnlListCard.Size = new System.Drawing.Size(852, 560);
            this.pnlListCard.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlListCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListCard.Name = "pnlListCard";
            //
            // lblEmptyBox
            //
            this.lblEmptyBox.Location = new System.Drawing.Point(0, 240);
            this.lblEmptyBox.Size = new System.Drawing.Size(850, 60);
            this.lblEmptyBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmptyBox.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblEmptyBox.Text = "No se encontraron transacciones con esos filtros";
            this.lblEmptyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyBox.Visible = false;
            this.lblEmptyBox.AutoSize = false;
            //
            // gridTransactions
            //
            this.gridTransactions.Location = new System.Drawing.Point(1, 1);
            this.gridTransactions.Size = new System.Drawing.Size(848, 556);
            this.gridTransactions.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.gridTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTransactions.GridColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.gridTransactions.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.gridTransactions.AllowUserToAddRows = false;
            this.gridTransactions.AllowUserToDeleteRows = false;
            this.gridTransactions.AllowUserToResizeRows = false;
            this.gridTransactions.ReadOnly = true;
            this.gridTransactions.RowHeadersVisible = false;
            this.gridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransactions.MultiSelect = false;
            this.gridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTransactions.ColumnHeadersHeight = 36;
            this.gridTransactions.RowTemplate.Height = 34;
            this.gridTransactions.EnableHeadersVisualStyles = false;
            this.gridTransactions.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.gridTransactions.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.gridTransactions.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.gridTransactions.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridTransactions.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.gridTransactions.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.gridTransactions.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.gridTransactions.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridTransactions.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(42, 42, 44);
            this.gridTransactions.Name = "gridTransactions";
            //
            // colDate
            //
            this.colDate.HeaderText = "Fecha";
            this.colDate.Name = "colDate";
            this.colDate.FillWeight = 90;
            //
            // colType
            //
            this.colType.HeaderText = "Tipo";
            this.colType.Name = "colType";
            this.colType.FillWeight = 80;
            //
            // colDescription
            //
            this.colDescription.HeaderText = "Descripcion";
            this.colDescription.Name = "colDescription";
            this.colDescription.FillWeight = 180;
            //
            // colCategory
            //
            this.colCategory.HeaderText = "Categoria";
            this.colCategory.Name = "colCategory";
            this.colCategory.FillWeight = 120;
            //
            // colAmount
            //
            this.colAmount.HeaderText = "Monto";
            this.colAmount.Name = "colAmount";
            this.colAmount.FillWeight = 100;
            this.colAmount.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            this.gridTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDate,
                this.colType,
                this.colDescription,
                this.colCategory,
                this.colAmount});

            // ---- Composicion de controles ----
            this.pnlSummaryIncome.Controls.Add(this.lblSummaryIncomeIcon);
            this.pnlSummaryIncome.Controls.Add(this.lblSummaryIncomeTitle);
            this.pnlSummaryIncome.Controls.Add(this.lblSummaryIncomeValue);

            this.pnlSummaryExpenses.Controls.Add(this.lblSummaryExpensesIcon);
            this.pnlSummaryExpenses.Controls.Add(this.lblSummaryExpensesTitle);
            this.pnlSummaryExpenses.Controls.Add(this.lblSummaryExpensesValue);

            this.pnlSummaryCount.Controls.Add(this.lblSummaryCountIcon);
            this.pnlSummaryCount.Controls.Add(this.lblSummaryCountTitle);
            this.pnlSummaryCount.Controls.Add(this.lblSummaryCountValue);

            this.pnlFilters.Controls.Add(this.lblSearchLabel);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.lblTypeFilterLabel);
            this.pnlFilters.Controls.Add(this.cmbTypeFilter);
            this.pnlFilters.Controls.Add(this.lblCategoryFilterLabel);
            this.pnlFilters.Controls.Add(this.cmbCategoryFilter);

            this.pnlListCard.Controls.Add(this.gridTransactions);
            this.pnlListCard.Controls.Add(this.lblEmptyBox);

            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblSubtitle);
            this.pnlMain.Controls.Add(this.pnlSummaryIncome);
            this.pnlMain.Controls.Add(this.pnlSummaryExpenses);
            this.pnlMain.Controls.Add(this.pnlSummaryCount);
            this.pnlMain.Controls.Add(this.pnlFilters);
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
            // HistoryForm
            //
            this.ClientSize = new System.Drawing.Size(1580, 900);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Text = "Capital Control - Historial (Vista previa)";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            ((System.ComponentModel.ISupportInitialize)(this.gridTransactions)).EndInit();
            this.pnlListCard.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlSummaryCount.ResumeLayout(false);
            this.pnlSummaryExpenses.ResumeLayout(false);
            this.pnlSummaryIncome.ResumeLayout(false);
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

        private System.Windows.Forms.Panel pnlSummaryIncome;
        private System.Windows.Forms.Label lblSummaryIncomeIcon;
        private System.Windows.Forms.Label lblSummaryIncomeTitle;
        private System.Windows.Forms.Label lblSummaryIncomeValue;

        private System.Windows.Forms.Panel pnlSummaryExpenses;
        private System.Windows.Forms.Label lblSummaryExpensesIcon;
        private System.Windows.Forms.Label lblSummaryExpensesTitle;
        private System.Windows.Forms.Label lblSummaryExpensesValue;

        private System.Windows.Forms.Panel pnlSummaryCount;
        private System.Windows.Forms.Label lblSummaryCountIcon;
        private System.Windows.Forms.Label lblSummaryCountTitle;
        private System.Windows.Forms.Label lblSummaryCountValue;

        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTypeFilterLabel;
        private System.Windows.Forms.ComboBox cmbTypeFilter;
        private System.Windows.Forms.Label lblCategoryFilterLabel;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;

        private System.Windows.Forms.Panel pnlListCard;
        private System.Windows.Forms.Label lblEmptyBox;
        private System.Windows.Forms.DataGridView gridTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}
