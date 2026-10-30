namespace CapitalControl
{
    partial class MembershipEditForm
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

            this.lblCostLabel = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();

            this.lblDayLabel = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();

            this.lblLogoLabel = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();

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
            this.lblTitle.Text = "Nueva Membresia";
            this.lblTitle.AutoSize = false;
            //
            // lblSubtitle
            //
            this.lblSubtitle.Location = new System.Drawing.Point(20, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(360, 20);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSubtitle.Text = "Registra una membresia recurrente";
            this.lblSubtitle.AutoSize = false;
            //
            // lblNameLabel
            //
            this.lblNameLabel.Location = new System.Drawing.Point(20, 78);
            this.lblNameLabel.Size = new System.Drawing.Size(360, 18);
            this.lblNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNameLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblNameLabel.Text = "Nombre";
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
            // lblCostLabel
            //
            this.lblCostLabel.Location = new System.Drawing.Point(20, 134);
            this.lblCostLabel.Size = new System.Drawing.Size(360, 18);
            this.lblCostLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCostLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblCostLabel.Text = "Costo mensual";
            this.lblCostLabel.AutoSize = false;
            //
            // txtCost
            //
            this.txtCost.Location = new System.Drawing.Point(20, 154);
            this.txtCost.Size = new System.Drawing.Size(360, 28);
            this.txtCost.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtCost.ForeColor = System.Drawing.Color.White;
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCost.Name = "txtCost";
            //
            // lblDayLabel
            //
            this.lblDayLabel.Location = new System.Drawing.Point(20, 190);
            this.lblDayLabel.Size = new System.Drawing.Size(360, 18);
            this.lblDayLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDayLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblDayLabel.Text = "Dia de cobro (1-28)";
            this.lblDayLabel.AutoSize = false;
            //
            // txtDay
            //
            this.txtDay.Location = new System.Drawing.Point(20, 210);
            this.txtDay.Size = new System.Drawing.Size(360, 28);
            this.txtDay.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtDay.ForeColor = System.Drawing.Color.White;
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDay.Name = "txtDay";
            //
            // lblLogoLabel
            //
            this.lblLogoLabel.Location = new System.Drawing.Point(20, 246);
            this.lblLogoLabel.Size = new System.Drawing.Size(360, 18);
            this.lblLogoLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLogoLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblLogoLabel.Text = "Icono (opcional)";
            this.lblLogoLabel.AutoSize = false;
            //
            // txtLogo
            //
            this.txtLogo.Location = new System.Drawing.Point(20, 266);
            this.txtLogo.Size = new System.Drawing.Size(360, 28);
            this.txtLogo.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtLogo.ForeColor = System.Drawing.Color.White;
            this.txtLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLogo.Name = "txtLogo";
            //
            // lblError
            //
            this.lblError.Location = new System.Drawing.Point(20, 300);
            this.lblError.Size = new System.Drawing.Size(360, 20);
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblError.Visible = false;
            this.lblError.AutoSize = false;
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(20, 328);
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
            this.btnCancel.Location = new System.Drawing.Point(250, 328);
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
            this.pnlRoot.Controls.Add(this.lblCostLabel);
            this.pnlRoot.Controls.Add(this.txtCost);
            this.pnlRoot.Controls.Add(this.lblDayLabel);
            this.pnlRoot.Controls.Add(this.txtDay);
            this.pnlRoot.Controls.Add(this.lblLogoLabel);
            this.pnlRoot.Controls.Add(this.txtLogo);
            this.pnlRoot.Controls.Add(this.lblError);
            this.pnlRoot.Controls.Add(this.btnSave);
            this.pnlRoot.Controls.Add(this.btnCancel);

            this.Controls.Add(this.pnlRoot);
            //
            // MembershipEditForm
            //
            this.ClientSize = new System.Drawing.Size(400, 392);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.Text = "Membresia";
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

        private System.Windows.Forms.Label lblCostLabel;
        private System.Windows.Forms.TextBox txtCost;

        private System.Windows.Forms.Label lblDayLabel;
        private System.Windows.Forms.TextBox txtDay;

        private System.Windows.Forms.Label lblLogoLabel;
        private System.Windows.Forms.TextBox txtLogo;

        private System.Windows.Forms.Label lblError;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
