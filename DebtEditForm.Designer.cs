namespace CapitalControl
{
    partial class DebtEditForm
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

            this.lblCreditorLabel = new System.Windows.Forms.Label();
            this.txtCreditor = new System.Windows.Forms.TextBox();

            this.lblTypeLabel = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();

            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();

            this.lblPaidLabel = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();

            this.lblDueLabel = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();

            this.lblRateLabel = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();

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
            this.lblTitle.Text = "Nueva Deuda";
            this.lblTitle.AutoSize = false;
            //
            // lblSubtitle
            //
            this.lblSubtitle.Location = new System.Drawing.Point(20, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(360, 20);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSubtitle.Text = "Registra una obligacion financiera";
            this.lblSubtitle.AutoSize = false;
            //
            // lblCreditorLabel
            //
            this.lblCreditorLabel.Location = new System.Drawing.Point(20, 78);
            this.lblCreditorLabel.Size = new System.Drawing.Size(360, 18);
            this.lblCreditorLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCreditorLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblCreditorLabel.Text = "Acreedor";
            this.lblCreditorLabel.AutoSize = false;
            //
            // txtCreditor
            //
            this.txtCreditor.Location = new System.Drawing.Point(20, 98);
            this.txtCreditor.Size = new System.Drawing.Size(360, 28);
            this.txtCreditor.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtCreditor.ForeColor = System.Drawing.Color.White;
            this.txtCreditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreditor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCreditor.Name = "txtCreditor";
            //
            // lblTypeLabel
            //
            this.lblTypeLabel.Location = new System.Drawing.Point(20, 134);
            this.lblTypeLabel.Size = new System.Drawing.Size(360, 18);
            this.lblTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTypeLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblTypeLabel.Text = "Tipo";
            this.lblTypeLabel.AutoSize = false;
            //
            // cmbType
            //
            this.cmbType.Location = new System.Drawing.Point(20, 154);
            this.cmbType.Size = new System.Drawing.Size(360, 28);
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.cmbType.ForeColor = System.Drawing.Color.White;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Items.AddRange(new object[] { "Bancaria", "Personal" });
            this.cmbType.Name = "cmbType";
            //
            // lblTotalLabel
            //
            this.lblTotalLabel.Location = new System.Drawing.Point(20, 190);
            this.lblTotalLabel.Size = new System.Drawing.Size(360, 18);
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblTotalLabel.Text = "Monto total";
            this.lblTotalLabel.AutoSize = false;
            //
            // txtTotal
            //
            this.txtTotal.Location = new System.Drawing.Point(20, 210);
            this.txtTotal.Size = new System.Drawing.Size(360, 28);
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotal.Name = "txtTotal";
            //
            // lblPaidLabel
            //
            this.lblPaidLabel.Location = new System.Drawing.Point(20, 246);
            this.lblPaidLabel.Size = new System.Drawing.Size(360, 18);
            this.lblPaidLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaidLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblPaidLabel.Text = "Monto ya pagado";
            this.lblPaidLabel.AutoSize = false;
            //
            // txtPaid
            //
            this.txtPaid.Location = new System.Drawing.Point(20, 266);
            this.txtPaid.Size = new System.Drawing.Size(360, 28);
            this.txtPaid.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtPaid.ForeColor = System.Drawing.Color.White;
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaid.Name = "txtPaid";
            //
            // lblDueLabel
            //
            this.lblDueLabel.Location = new System.Drawing.Point(20, 302);
            this.lblDueLabel.Size = new System.Drawing.Size(360, 18);
            this.lblDueLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDueLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblDueLabel.Text = "Fecha limite (AAAA-MM-DD)";
            this.lblDueLabel.AutoSize = false;
            //
            // txtDue
            //
            this.txtDue.Location = new System.Drawing.Point(20, 322);
            this.txtDue.Size = new System.Drawing.Size(360, 28);
            this.txtDue.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtDue.ForeColor = System.Drawing.Color.White;
            this.txtDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDue.Name = "txtDue";
            //
            // lblRateLabel
            //
            this.lblRateLabel.Location = new System.Drawing.Point(20, 358);
            this.lblRateLabel.Size = new System.Drawing.Size(360, 18);
            this.lblRateLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRateLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblRateLabel.Text = "Tasa de interes (%) - opcional";
            this.lblRateLabel.AutoSize = false;
            //
            // txtRate
            //
            this.txtRate.Location = new System.Drawing.Point(20, 378);
            this.txtRate.Size = new System.Drawing.Size(360, 28);
            this.txtRate.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtRate.ForeColor = System.Drawing.Color.White;
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRate.Name = "txtRate";
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
            this.pnlRoot.Controls.Add(this.lblCreditorLabel);
            this.pnlRoot.Controls.Add(this.txtCreditor);
            this.pnlRoot.Controls.Add(this.lblTypeLabel);
            this.pnlRoot.Controls.Add(this.cmbType);
            this.pnlRoot.Controls.Add(this.lblTotalLabel);
            this.pnlRoot.Controls.Add(this.txtTotal);
            this.pnlRoot.Controls.Add(this.lblPaidLabel);
            this.pnlRoot.Controls.Add(this.txtPaid);
            this.pnlRoot.Controls.Add(this.lblDueLabel);
            this.pnlRoot.Controls.Add(this.txtDue);
            this.pnlRoot.Controls.Add(this.lblRateLabel);
            this.pnlRoot.Controls.Add(this.txtRate);
            this.pnlRoot.Controls.Add(this.lblError);
            this.pnlRoot.Controls.Add(this.btnSave);
            this.pnlRoot.Controls.Add(this.btnCancel);

            this.Controls.Add(this.pnlRoot);
            //
            // DebtEditForm
            //
            this.ClientSize = new System.Drawing.Size(400, 502);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.Text = "Deuda";
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

        private System.Windows.Forms.Label lblCreditorLabel;
        private System.Windows.Forms.TextBox txtCreditor;

        private System.Windows.Forms.Label lblTypeLabel;
        private System.Windows.Forms.ComboBox cmbType;

        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.TextBox txtTotal;

        private System.Windows.Forms.Label lblPaidLabel;
        private System.Windows.Forms.TextBox txtPaid;

        private System.Windows.Forms.Label lblDueLabel;
        private System.Windows.Forms.TextBox txtDue;

        private System.Windows.Forms.Label lblRateLabel;
        private System.Windows.Forms.TextBox txtRate;

        private System.Windows.Forms.Label lblError;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
