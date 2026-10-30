namespace CapitalControl
{
    partial class TransactionForm
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

            this.pnlSuccessBox = new System.Windows.Forms.Panel();
            this.lblSuccessIcon = new System.Windows.Forms.Label();
            this.lblSuccessText = new System.Windows.Forms.Label();

            this.pnlWarningBox = new System.Windows.Forms.Panel();
            this.lblWarningIcon = new System.Windows.Forms.Label();
            this.lblWarningTitle = new System.Windows.Forms.Label();
            this.lblWarningText = new System.Windows.Forms.Label();

            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTypeLabel = new System.Windows.Forms.Label();
            this.btnTypeIncome = new System.Windows.Forms.Button();
            this.btnTypeExpense = new System.Windows.Forms.Button();
            this.btnTypeInvestment = new System.Windows.Forms.Button();
            this.lblAmountLabel = new System.Windows.Forms.Label();
            this.lblDollarSign = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmountError = new System.Windows.Forms.Label();
            this.lblCategoryLabel = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategoryError = new System.Windows.Forms.Label();
            this.lblDescriptionLabel = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescriptionError = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDateError = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.pnlRoot.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSuccessBox.SuspendLayout();
            this.pnlWarningBox.SuspendLayout();
            this.pnlCard.SuspendLayout();
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
            this.btnNavTransaction.BackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.btnNavTransaction.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
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
            this.pnlMain.AutoScrollMinSize = new System.Drawing.Size(700, 700);
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlMain.Name = "pnlMain";
            //
            // lblTitle
            //
            this.lblTitle.Location = new System.Drawing.Point(28, 26);
            this.lblTitle.Size = new System.Drawing.Size(500, 34);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Registrar Transaccion";
            this.lblTitle.AutoSize = false;
            //
            // lblSubtitle
            //
            this.lblSubtitle.Location = new System.Drawing.Point(28, 60);
            this.lblSubtitle.Size = new System.Drawing.Size(500, 22);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSubtitle.Text = "Agrega un nuevo ingreso, gasto o inversion";
            this.lblSubtitle.AutoSize = false;
            //
            // pnlSuccessBox
            //
            this.pnlSuccessBox.Location = new System.Drawing.Point(28, 96);
            this.pnlSuccessBox.Size = new System.Drawing.Size(680, 48);
            this.pnlSuccessBox.BackColor = System.Drawing.Color.FromArgb(31, 46, 40);
            this.pnlSuccessBox.Visible = false;
            this.pnlSuccessBox.Name = "pnlSuccessBox";
            //
            // lblSuccessIcon
            //
            this.lblSuccessIcon.Location = new System.Drawing.Point(14, 13);
            this.lblSuccessIcon.Size = new System.Drawing.Size(24, 22);
            this.lblSuccessIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSuccessIcon.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblSuccessIcon.Text = "\u2714";
            this.lblSuccessIcon.AutoSize = false;
            //
            // lblSuccessText
            //
            this.lblSuccessText.Location = new System.Drawing.Point(42, 13);
            this.lblSuccessText.Size = new System.Drawing.Size(500, 22);
            this.lblSuccessText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSuccessText.ForeColor = System.Drawing.Color.White;
            this.lblSuccessText.Text = "Transaccion registrada exitosamente";
            this.lblSuccessText.AutoSize = false;
            //
            // pnlWarningBox
            //
            this.pnlWarningBox.Location = new System.Drawing.Point(28, 96);
            this.pnlWarningBox.Size = new System.Drawing.Size(680, 64);
            this.pnlWarningBox.BackColor = System.Drawing.Color.FromArgb(53, 33, 33);
            this.pnlWarningBox.Visible = false;
            this.pnlWarningBox.Name = "pnlWarningBox";
            //
            // lblWarningIcon
            //
            this.lblWarningIcon.Location = new System.Drawing.Point(14, 13);
            this.lblWarningIcon.Size = new System.Drawing.Size(24, 22);
            this.lblWarningIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWarningIcon.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblWarningIcon.Text = "\u26A0";
            this.lblWarningIcon.AutoSize = false;
            //
            // lblWarningTitle
            //
            this.lblWarningTitle.Location = new System.Drawing.Point(42, 11);
            this.lblWarningTitle.Size = new System.Drawing.Size(500, 20);
            this.lblWarningTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWarningTitle.ForeColor = System.Drawing.Color.White;
            this.lblWarningTitle.Text = "Advertencia: saldo insuficiente";
            this.lblWarningTitle.AutoSize = false;
            //
            // lblWarningText
            //
            this.lblWarningText.Location = new System.Drawing.Point(42, 33);
            this.lblWarningText.Size = new System.Drawing.Size(600, 22);
            this.lblWarningText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWarningText.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblWarningText.AutoSize = false;
            //
            // pnlCard
            //
            this.pnlCard.Location = new System.Drawing.Point(28, 96);
            this.pnlCard.Size = new System.Drawing.Size(680, 590);
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Name = "pnlCard";
            //
            // lblTypeLabel
            //
            this.lblTypeLabel.Location = new System.Drawing.Point(20, 20);
            this.lblTypeLabel.Size = new System.Drawing.Size(300, 20);
            this.lblTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTypeLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblTypeLabel.Text = "Tipo de Transaccion";
            this.lblTypeLabel.AutoSize = false;
            //
            // btnTypeIncome
            //
            this.btnTypeIncome.Location = new System.Drawing.Point(20, 50);
            this.btnTypeIncome.Size = new System.Drawing.Size(207, 42);
            this.btnTypeIncome.BackColor = System.Drawing.Color.Transparent;
            this.btnTypeIncome.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.btnTypeIncome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTypeIncome.Text = "Ingreso";
            this.btnTypeIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeIncome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnTypeIncome.FlatAppearance.BorderSize = 2;
            this.btnTypeIncome.UseVisualStyleBackColor = false;
            this.btnTypeIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypeIncome.Name = "btnTypeIncome";
            this.btnTypeIncome.Tag = "Ingreso";
            //
            // btnTypeExpense
            //
            this.btnTypeExpense.Location = new System.Drawing.Point(237, 50);
            this.btnTypeExpense.Size = new System.Drawing.Size(207, 42);
            this.btnTypeExpense.BackColor = System.Drawing.Color.FromArgb(38, 55, 82);
            this.btnTypeExpense.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.btnTypeExpense.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTypeExpense.Text = "Gasto";
            this.btnTypeExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeExpense.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(55, 148, 255);
            this.btnTypeExpense.FlatAppearance.BorderSize = 2;
            this.btnTypeExpense.UseVisualStyleBackColor = false;
            this.btnTypeExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypeExpense.Name = "btnTypeExpense";
            this.btnTypeExpense.Tag = "Gasto";
            //
            // btnTypeInvestment
            //
            this.btnTypeInvestment.Location = new System.Drawing.Point(454, 50);
            this.btnTypeInvestment.Size = new System.Drawing.Size(206, 42);
            this.btnTypeInvestment.BackColor = System.Drawing.Color.Transparent;
            this.btnTypeInvestment.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.btnTypeInvestment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTypeInvestment.Text = "Inversion";
            this.btnTypeInvestment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeInvestment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnTypeInvestment.FlatAppearance.BorderSize = 2;
            this.btnTypeInvestment.UseVisualStyleBackColor = false;
            this.btnTypeInvestment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypeInvestment.Name = "btnTypeInvestment";
            this.btnTypeInvestment.Tag = "Inversion";
            //
            // lblAmountLabel
            //
            this.lblAmountLabel.Location = new System.Drawing.Point(20, 110);
            this.lblAmountLabel.Size = new System.Drawing.Size(300, 20);
            this.lblAmountLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAmountLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblAmountLabel.Text = "Monto *";
            this.lblAmountLabel.AutoSize = false;
            //
            // lblDollarSign
            //
            this.lblDollarSign.Location = new System.Drawing.Point(20, 138);
            this.lblDollarSign.Size = new System.Drawing.Size(18, 26);
            this.lblDollarSign.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblDollarSign.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblDollarSign.Text = "$";
            this.lblDollarSign.AutoSize = false;
            //
            // txtAmount
            //
            this.txtAmount.Location = new System.Drawing.Point(44, 134);
            this.txtAmount.Size = new System.Drawing.Size(616, 30);
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAmount.Name = "txtAmount";
            //
            // lblAmountError
            //
            this.lblAmountError.Location = new System.Drawing.Point(20, 170);
            this.lblAmountError.Size = new System.Drawing.Size(640, 18);
            this.lblAmountError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAmountError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblAmountError.Visible = false;
            this.lblAmountError.AutoSize = false;
            //
            // lblCategoryLabel
            //
            this.lblCategoryLabel.Location = new System.Drawing.Point(20, 196);
            this.lblCategoryLabel.Size = new System.Drawing.Size(300, 20);
            this.lblCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblCategoryLabel.Text = "Categoria *";
            this.lblCategoryLabel.AutoSize = false;
            //
            // cmbCategory
            //
            this.cmbCategory.Location = new System.Drawing.Point(20, 222);
            this.cmbCategory.Size = new System.Drawing.Size(640, 30);
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.cmbCategory.ForeColor = System.Drawing.Color.White;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Name = "cmbCategory";
            //
            // lblCategoryError
            //
            this.lblCategoryError.Location = new System.Drawing.Point(20, 256);
            this.lblCategoryError.Size = new System.Drawing.Size(640, 18);
            this.lblCategoryError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCategoryError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblCategoryError.Visible = false;
            this.lblCategoryError.AutoSize = false;
            //
            // lblDescriptionLabel
            //
            this.lblDescriptionLabel.Location = new System.Drawing.Point(20, 282);
            this.lblDescriptionLabel.Size = new System.Drawing.Size(300, 20);
            this.lblDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblDescriptionLabel.Text = "Descripcion *";
            this.lblDescriptionLabel.AutoSize = false;
            //
            // txtDescription
            //
            this.txtDescription.Location = new System.Drawing.Point(20, 308);
            this.txtDescription.Size = new System.Drawing.Size(640, 84);
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDescription.Multiline = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Name = "txtDescription";
            //
            // lblDescriptionError
            //
            this.lblDescriptionError.Location = new System.Drawing.Point(20, 396);
            this.lblDescriptionError.Size = new System.Drawing.Size(640, 18);
            this.lblDescriptionError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDescriptionError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblDescriptionError.Visible = false;
            this.lblDescriptionError.AutoSize = false;
            //
            // lblDateLabel
            //
            this.lblDateLabel.Location = new System.Drawing.Point(20, 422);
            this.lblDateLabel.Size = new System.Drawing.Size(300, 20);
            this.lblDateLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblDateLabel.Text = "Fecha (AAAA-MM-DD)";
            this.lblDateLabel.AutoSize = false;
            //
            // txtDate
            //
            this.txtDate.Location = new System.Drawing.Point(20, 448);
            this.txtDate.Size = new System.Drawing.Size(300, 30);
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDate.Name = "txtDate";
            //
            // lblDateError
            //
            this.lblDateError.Location = new System.Drawing.Point(20, 482);
            this.lblDateError.Size = new System.Drawing.Size(640, 18);
            this.lblDateError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDateError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblDateError.Visible = false;
            this.lblDateError.AutoSize = false;
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(20, 520);
            this.btnSave.Size = new System.Drawing.Size(478, 46);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 184, 107);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.Text = "Guardar Transaccion";
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Name = "btnSave";
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(510, 520);
            this.btnCancel.Size = new System.Drawing.Size(150, 46);
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Name = "btnCancel";

            // ---- Composicion de controles ----
            this.pnlSuccessBox.Controls.Add(this.lblSuccessIcon);
            this.pnlSuccessBox.Controls.Add(this.lblSuccessText);

            this.pnlWarningBox.Controls.Add(this.lblWarningIcon);
            this.pnlWarningBox.Controls.Add(this.lblWarningTitle);
            this.pnlWarningBox.Controls.Add(this.lblWarningText);

            this.pnlCard.Controls.Add(this.lblTypeLabel);
            this.pnlCard.Controls.Add(this.btnTypeIncome);
            this.pnlCard.Controls.Add(this.btnTypeExpense);
            this.pnlCard.Controls.Add(this.btnTypeInvestment);
            this.pnlCard.Controls.Add(this.lblAmountLabel);
            this.pnlCard.Controls.Add(this.lblDollarSign);
            this.pnlCard.Controls.Add(this.txtAmount);
            this.pnlCard.Controls.Add(this.lblAmountError);
            this.pnlCard.Controls.Add(this.lblCategoryLabel);
            this.pnlCard.Controls.Add(this.cmbCategory);
            this.pnlCard.Controls.Add(this.lblCategoryError);
            this.pnlCard.Controls.Add(this.lblDescriptionLabel);
            this.pnlCard.Controls.Add(this.txtDescription);
            this.pnlCard.Controls.Add(this.lblDescriptionError);
            this.pnlCard.Controls.Add(this.lblDateLabel);
            this.pnlCard.Controls.Add(this.txtDate);
            this.pnlCard.Controls.Add(this.lblDateError);
            this.pnlCard.Controls.Add(this.btnSave);
            this.pnlCard.Controls.Add(this.btnCancel);

            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblSubtitle);
            this.pnlMain.Controls.Add(this.pnlSuccessBox);
            this.pnlMain.Controls.Add(this.pnlWarningBox);
            this.pnlMain.Controls.Add(this.pnlCard);

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
            // TransactionForm
            //
            this.ClientSize = new System.Drawing.Size(1580, 900);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.Text = "Capital Control - Nueva Transaccion (Vista previa)";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.pnlCard.ResumeLayout(false);
            this.pnlWarningBox.ResumeLayout(false);
            this.pnlSuccessBox.ResumeLayout(false);
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

        private System.Windows.Forms.Panel pnlSuccessBox;
        private System.Windows.Forms.Label lblSuccessIcon;
        private System.Windows.Forms.Label lblSuccessText;

        private System.Windows.Forms.Panel pnlWarningBox;
        private System.Windows.Forms.Label lblWarningIcon;
        private System.Windows.Forms.Label lblWarningTitle;
        private System.Windows.Forms.Label lblWarningText;

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTypeLabel;
        private System.Windows.Forms.Button btnTypeIncome;
        private System.Windows.Forms.Button btnTypeExpense;
        private System.Windows.Forms.Button btnTypeInvestment;
        private System.Windows.Forms.Label lblAmountLabel;
        private System.Windows.Forms.Label lblDollarSign;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmountError;
        private System.Windows.Forms.Label lblCategoryLabel;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategoryError;
        private System.Windows.Forms.Label lblDescriptionLabel;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescriptionError;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDateError;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
