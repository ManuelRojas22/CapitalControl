namespace CapitalControl
{
    partial class GoalEditForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.lblNameLabel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();

            this.lblCategoryLabel = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();

            this.lblTargetLabel = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();

            this.lblCurrentLabel = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();

            this.lblTargetDateLabel = new System.Windows.Forms.Label();
            this.txtTargetDate = new System.Windows.Forms.TextBox();

            this.lblColorLabel = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();

            this.lblError = new System.Windows.Forms.Label();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.pnlRoot.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlRoot
            //
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.pnlRoot.Name = "pnlRoot";
            //
            // lblTitle
            //
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Size = new System.Drawing.Size(360, 26);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "Nueva Meta";
            this.lblTitle.AutoSize = false;
            //
            // lblSubtitle
            //
            this.lblSubtitle.Location = new System.Drawing.Point(20, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(360, 20);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSubtitle.Text = "Define un objetivo de ahorro";
            this.lblSubtitle.AutoSize = false;
            //
            // lblNameLabel
            //
            this.lblNameLabel.Location = new System.Drawing.Point(20, 78);
            this.lblNameLabel.Size = new System.Drawing.Size(360, 18);
            this.lblNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNameLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblNameLabel.Text = "Nombre de la meta";
            this.lblNameLabel.AutoSize = false;
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(20, 98);
            this.txtName.Size = new System.Drawing.Size(360, 28);
            this.txtName.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Name = "txtName";
            //
            // lblCategoryLabel
            //
            this.lblCategoryLabel.Location = new System.Drawing.Point(20, 134);
            this.lblCategoryLabel.Size = new System.Drawing.Size(360, 18);
            this.lblCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblCategoryLabel.Text = "Categoria";
            this.lblCategoryLabel.AutoSize = false;
            //
            // txtCategory
            //
            this.txtCategory.Location = new System.Drawing.Point(20, 154);
            this.txtCategory.Size = new System.Drawing.Size(360, 28);
            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtCategory.ForeColor = System.Drawing.Color.White;
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategory.Name = "txtCategory";
            //
            // lblTargetLabel
            //
            this.lblTargetLabel.Location = new System.Drawing.Point(20, 190);
            this.lblTargetLabel.Size = new System.Drawing.Size(360, 18);
            this.lblTargetLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTargetLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblTargetLabel.Text = "Monto meta";
            this.lblTargetLabel.AutoSize = false;
            //
            // txtTarget
            //
            this.txtTarget.Location = new System.Drawing.Point(20, 210);
            this.txtTarget.Size = new System.Drawing.Size(360, 28);
            this.txtTarget.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtTarget.ForeColor = System.Drawing.Color.White;
            this.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarget.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTarget.Name = "txtTarget";
            //
            // lblCurrentLabel
            //
            this.lblCurrentLabel.Location = new System.Drawing.Point(20, 246);
            this.lblCurrentLabel.Size = new System.Drawing.Size(360, 18);
            this.lblCurrentLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCurrentLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblCurrentLabel.Text = "Monto ya ahorrado";
            this.lblCurrentLabel.AutoSize = false;
            //
            // txtCurrent
            //
            this.txtCurrent.Location = new System.Drawing.Point(20, 266);
            this.txtCurrent.Size = new System.Drawing.Size(360, 28);
            this.txtCurrent.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtCurrent.ForeColor = System.Drawing.Color.White;
            this.txtCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCurrent.Name = "txtCurrent";
            //
            // lblTargetDateLabel
            //
            this.lblTargetDateLabel.Location = new System.Drawing.Point(20, 302);
            this.lblTargetDateLabel.Size = new System.Drawing.Size(360, 18);
            this.lblTargetDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTargetDateLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblTargetDateLabel.Text = "Fecha meta (AAAA-MM-DD)";
            this.lblTargetDateLabel.AutoSize = false;
            //
            // txtTargetDate
            //
            this.txtTargetDate.Location = new System.Drawing.Point(20, 322);
            this.txtTargetDate.Size = new System.Drawing.Size(360, 28);
            this.txtTargetDate.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtTargetDate.ForeColor = System.Drawing.Color.White;
            this.txtTargetDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTargetDate.Name = "txtTargetDate";
            //
            // lblColorLabel
            //
            this.lblColorLabel.Location = new System.Drawing.Point(20, 358);
            this.lblColorLabel.Size = new System.Drawing.Size(360, 18);
            this.lblColorLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblColorLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblColorLabel.Text = "Color";
            this.lblColorLabel.AutoSize = false;
            //
            // cmbColor
            //
            this.cmbColor.Location = new System.Drawing.Point(20, 378);
            this.cmbColor.Size = new System.Drawing.Size(360, 28);
            this.cmbColor.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.cmbColor.ForeColor = System.Drawing.Color.White;
            this.cmbColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbColor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Items.AddRange(new object[] { "Azul", "Verde", "Morado", "Rojo" });
            this.cmbColor.Name = "cmbColor";
            //
            // lblError
            //
            this.lblError.Location = new System.Drawing.Point(20, 412);
            this.lblError.Size = new System.Drawing.Size(360, 20);
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblError.Visible = false;
            this.lblError.AutoSize = false;
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(20, 440);
            this.btnSave.Size = new System.Drawing.Size(220, 42);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 184, 107);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Text = "Guardar";
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Name = "btnSave";
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(250, 440);
            this.btnCancel.Size = new System.Drawing.Size(130, 42);
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Name = "btnCancel";

            // ---- Composicion de controles ----
            this.pnlRoot.Controls.Add(this.lblTitle);
            this.pnlRoot.Controls.Add(this.lblSubtitle);
            this.pnlRoot.Controls.Add(this.lblNameLabel);
            this.pnlRoot.Controls.Add(this.txtName);
            this.pnlRoot.Controls.Add(this.lblCategoryLabel);
            this.pnlRoot.Controls.Add(this.txtCategory);
            this.pnlRoot.Controls.Add(this.lblTargetLabel);
            this.pnlRoot.Controls.Add(this.txtTarget);
            this.pnlRoot.Controls.Add(this.lblCurrentLabel);
            this.pnlRoot.Controls.Add(this.txtCurrent);
            this.pnlRoot.Controls.Add(this.lblTargetDateLabel);
            this.pnlRoot.Controls.Add(this.txtTargetDate);
            this.pnlRoot.Controls.Add(this.lblColorLabel);
            this.pnlRoot.Controls.Add(this.cmbColor);
            this.pnlRoot.Controls.Add(this.lblError);
            this.pnlRoot.Controls.Add(this.btnSave);
            this.pnlRoot.Controls.Add(this.btnCancel);

            this.Controls.Add(this.pnlRoot);
            //
            // GoalEditForm
            //
            this.ClientSize = new System.Drawing.Size(400, 502);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.Text = "Meta de Ahorro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;

            this.pnlRoot.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlRoot;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Label lblCategoryLabel;
        private System.Windows.Forms.TextBox txtCategory;

        private System.Windows.Forms.Label lblTargetLabel;
        private System.Windows.Forms.TextBox txtTarget;

        private System.Windows.Forms.Label lblCurrentLabel;
        private System.Windows.Forms.TextBox txtCurrent;

        private System.Windows.Forms.Label lblTargetDateLabel;
        private System.Windows.Forms.TextBox txtTargetDate;

        private System.Windows.Forms.Label lblColorLabel;
        private System.Windows.Forms.ComboBox cmbColor;

        private System.Windows.Forms.Label lblError;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
