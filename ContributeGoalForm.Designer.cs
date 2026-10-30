namespace CapitalControl
{
    partial class ContributeGoalForm
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

            this.lblAmountLabel = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();

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
            this.lblTitle.Text = "Abonar a Meta";
            this.lblTitle.AutoSize = false;
            //
            // lblSubtitle
            //
            this.lblSubtitle.Location = new System.Drawing.Point(20, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(360, 34);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
            this.lblSubtitle.Text = "";
            this.lblSubtitle.AutoSize = false;
            //
            // lblAmountLabel
            //
            this.lblAmountLabel.Location = new System.Drawing.Point(20, 88);
            this.lblAmountLabel.Size = new System.Drawing.Size(360, 18);
            this.lblAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAmountLabel.ForeColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.lblAmountLabel.Text = "Valor del abono";
            this.lblAmountLabel.AutoSize = false;
            //
            // txtAmount
            //
            this.txtAmount.Location = new System.Drawing.Point(20, 108);
            this.txtAmount.Size = new System.Drawing.Size(360, 28);
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAmount.Name = "txtAmount";
            //
            // lblError
            //
            this.lblError.Location = new System.Drawing.Point(20, 144);
            this.lblError.Size = new System.Drawing.Size(360, 20);
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblError.Visible = false;
            this.lblError.AutoSize = false;
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(20, 172);
            this.btnSave.Size = new System.Drawing.Size(220, 42);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 184, 107);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Text = "Abonar";
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Name = "btnSave";
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(250, 172);
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
            this.pnlRoot.Controls.Add(this.lblAmountLabel);
            this.pnlRoot.Controls.Add(this.txtAmount);
            this.pnlRoot.Controls.Add(this.lblError);
            this.pnlRoot.Controls.Add(this.btnSave);
            this.pnlRoot.Controls.Add(this.btnCancel);

            this.Controls.Add(this.pnlRoot);
            //
            // ContributeGoalForm
            //
            this.ClientSize = new System.Drawing.Size(400, 234);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.Text = "Abonar a Meta";
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

        private System.Windows.Forms.Label lblAmountLabel;
        private System.Windows.Forms.TextBox txtAmount;

        private System.Windows.Forms.Label lblError;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
