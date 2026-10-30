namespace CapitalControl
{
    partial class LoginForm
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
            pnlRoot = new System.Windows.Forms.Panel();
            pnlCard = new CapitalControl.Controls.RoundedPanel();
            lblEmailLabel = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmailError = new System.Windows.Forms.Label();
            lblPasswordLabel = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnShowPassword = new CapitalControl.Controls.RoundedButton();
            lblPasswordError = new System.Windows.Forms.Label();
            chkRemember = new System.Windows.Forms.CheckBox();
            btnForgot = new System.Windows.Forms.Button();
            btnLogin = new CapitalControl.Controls.RoundedButton();
            pnlDividerLeft = new System.Windows.Forms.Panel();
            lblDivider = new System.Windows.Forms.Label();
            pnlDividerRight = new System.Windows.Forms.Panel();
            btnGoogle = new CapitalControl.Controls.RoundedButton();
            btnGithub = new CapitalControl.Controls.RoundedButton();
            lblNoAccount = new System.Windows.Forms.Label();
            btnGoRegister = new System.Windows.Forms.Button();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            pnlIcon = new CapitalControl.Controls.RoundedPanel();
            lblIcon = new System.Windows.Forms.Label();
            btnBack = new CapitalControl.Controls.RoundedButton();
            pnlRoot.SuspendLayout();
            pnlCard.SuspendLayout();
            pnlIcon.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRoot
            // 
            pnlRoot.BackColor = System.Drawing.Color.Green;
            pnlRoot.Controls.Add(pnlCard);
            pnlRoot.Controls.Add(lblSubtitle);
            pnlRoot.Controls.Add(lblTitle);
            pnlRoot.Controls.Add(pnlIcon);
            pnlRoot.Controls.Add(btnBack);
            pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRoot.Location = new System.Drawing.Point(0, 0);
            pnlRoot.Name = "pnlRoot";
            pnlRoot.Size = new System.Drawing.Size(545, 680);
            pnlRoot.TabIndex = 0;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = System.Drawing.Color.FromArgb(22, 22, 25);
            pnlCard.Controls.Add(lblEmailLabel);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblEmailError);
            pnlCard.Controls.Add(lblPasswordLabel);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(btnShowPassword);
            pnlCard.Controls.Add(lblPasswordError);
            pnlCard.Controls.Add(chkRemember);
            pnlCard.Controls.Add(btnForgot);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(pnlDividerLeft);
            pnlCard.Controls.Add(lblDivider);
            pnlCard.Controls.Add(pnlDividerRight);
            pnlCard.Controls.Add(btnGoogle);
            pnlCard.Controls.Add(btnGithub);
            pnlCard.Controls.Add(lblNoAccount);
            pnlCard.Controls.Add(btnGoRegister);
            pnlCard.CornerRadius = 22;
            pnlCard.Location = new System.Drawing.Point(50, 220);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new System.Drawing.Size(420, 412);
            pnlCard.TabIndex = 0;
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(210, 210, 213);
            lblEmailLabel.Location = new System.Drawing.Point(24, 22);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new System.Drawing.Size(300, 20);
            lblEmailLabel.TabIndex = 0;
            lblEmailLabel.Text = "✉  Correo Electronico";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtEmail.ForeColor = System.Drawing.Color.White;
            txtEmail.Location = new System.Drawing.Point(24, 44);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(372, 26);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "correo@ejemplo.com";
            // 
            // lblEmailError
            // 
            lblEmailError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblEmailError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            lblEmailError.Location = new System.Drawing.Point(24, 76);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new System.Drawing.Size(372, 18);
            lblEmailError.TabIndex = 2;
            lblEmailError.Text = "El correo electronico es requerido";
            lblEmailError.Visible = false;
            // 
            // lblPasswordLabel
            // 
            lblPasswordLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 9.5F);
            lblPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(210, 210, 213);
            lblPasswordLabel.Location = new System.Drawing.Point(24, 96);
            lblPasswordLabel.Name = "lblPasswordLabel";
            lblPasswordLabel.Size = new System.Drawing.Size(300, 20);
            lblPasswordLabel.TabIndex = 3;
            lblPasswordLabel.Text = "🔒  Contrasena";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtPassword.ForeColor = System.Drawing.Color.White;
            txtPassword.Location = new System.Drawing.Point(24, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(332, 26);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            btnShowPassword.CornerRadius = 6;
            btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            btnShowPassword.ForeColor = System.Drawing.Color.White;
            btnShowPassword.Location = new System.Drawing.Point(360, 118);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new System.Drawing.Size(36, 30);
            btnShowPassword.TabIndex = 5;
            btnShowPassword.Text = "👁";
            btnShowPassword.UseVisualStyleBackColor = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblPasswordError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            lblPasswordError.Location = new System.Drawing.Point(24, 150);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new System.Drawing.Size(372, 18);
            lblPasswordError.TabIndex = 6;
            lblPasswordError.Text = "La contrasena es requerida";
            lblPasswordError.Visible = false;
            // 
            // chkRemember
            // 
            chkRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            chkRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkRemember.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            chkRemember.ForeColor = System.Drawing.Color.FromArgb(200, 200, 203);
            chkRemember.Location = new System.Drawing.Point(24, 172);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new System.Drawing.Size(140, 24);
            chkRemember.TabIndex = 7;
            chkRemember.Text = "Recordarme";
            // 
            // btnForgot
            // 
            btnForgot.BackColor = System.Drawing.Color.FromArgb(22, 22, 25);
            btnForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            btnForgot.FlatAppearance.BorderSize = 0;
            btnForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnForgot.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnForgot.ForeColor = System.Drawing.Color.FromArgb(70, 156, 255);
            btnForgot.Location = new System.Drawing.Point(180, 172);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new System.Drawing.Size(216, 24);
            btnForgot.TabIndex = 8;
            btnForgot.Text = "Olvidaste tu contrasena?";
            btnForgot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnForgot.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(37, 110, 235);
            btnLogin.CornerRadius = 10;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(24, 208);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(372, 46);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pnlDividerLeft
            // 
            pnlDividerLeft.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            pnlDividerLeft.Location = new System.Drawing.Point(24, 275);
            pnlDividerLeft.Name = "pnlDividerLeft";
            pnlDividerLeft.Size = new System.Drawing.Size(130, 1);
            pnlDividerLeft.TabIndex = 10;
            // 
            // lblDivider
            // 
            lblDivider.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblDivider.ForeColor = System.Drawing.Color.FromArgb(140, 140, 145);
            lblDivider.Location = new System.Drawing.Point(154, 264);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new System.Drawing.Size(112, 22);
            lblDivider.TabIndex = 11;
            lblDivider.Text = "o continua con";
            lblDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDividerRight
            // 
            pnlDividerRight.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            pnlDividerRight.Location = new System.Drawing.Point(266, 275);
            pnlDividerRight.Name = "pnlDividerRight";
            pnlDividerRight.Size = new System.Drawing.Size(130, 1);
            pnlDividerRight.TabIndex = 12;
            // 
            // btnGoogle
            // 
            btnGoogle.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            btnGoogle.CornerRadius = 8;
            btnGoogle.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGoogle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnGoogle.ForeColor = System.Drawing.Color.FromArgb(230, 230, 233);
            btnGoogle.Location = new System.Drawing.Point(24, 300);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new System.Drawing.Size(180, 40);
            btnGoogle.TabIndex = 13;
            btnGoogle.Text = "G   Google";
            btnGoogle.UseVisualStyleBackColor = false;
            // 
            // btnGithub
            // 
            btnGithub.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            btnGithub.CornerRadius = 8;
            btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGithub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnGithub.ForeColor = System.Drawing.Color.FromArgb(230, 230, 233);
            btnGithub.Location = new System.Drawing.Point(216, 300);
            btnGithub.Name = "btnGithub";
            btnGithub.Size = new System.Drawing.Size(180, 40);
            btnGithub.TabIndex = 14;
            btnGithub.Text = "GitHub";
            btnGithub.UseVisualStyleBackColor = false;
            // 
            // lblNoAccount
            // 
            lblNoAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblNoAccount.ForeColor = System.Drawing.Color.FromArgb(150, 150, 154);
            lblNoAccount.Location = new System.Drawing.Point(80, 362);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new System.Drawing.Size(150, 24);
            lblNoAccount.TabIndex = 15;
            lblNoAccount.Text = "No tienes una cuenta?";
            lblNoAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGoRegister
            // 
            btnGoRegister.BackColor = System.Drawing.Color.FromArgb(22, 22, 25);
            btnGoRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGoRegister.FlatAppearance.BorderSize = 0;
            btnGoRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGoRegister.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnGoRegister.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnGoRegister.Location = new System.Drawing.Point(236, 360);
            btnGoRegister.Name = "btnGoRegister";
            btnGoRegister.Size = new System.Drawing.Size(110, 28);
            btnGoRegister.TabIndex = 16;
            btnGoRegister.Text = "Registrate aqui";
            btnGoRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnGoRegister.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(214, 238, 230);
            lblSubtitle.Location = new System.Drawing.Point(0, 176);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(520, 24);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Inicia sesion para gestionar tus finanzas";
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(0, 140);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(520, 34);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Capital Control";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIcon
            // 
            pnlIcon.BackColor = System.Drawing.Color.FromArgb(20, 199, 120);
            pnlIcon.Controls.Add(lblIcon);
            pnlIcon.CornerRadius = 18;
            pnlIcon.Location = new System.Drawing.Point(228, 64);
            pnlIcon.Name = "pnlIcon";
            pnlIcon.Size = new System.Drawing.Size(64, 64);
            pnlIcon.TabIndex = 3;
            // 
            // lblIcon
            // 
            lblIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 22F);
            lblIcon.ForeColor = System.Drawing.Color.White;
            lblIcon.Location = new System.Drawing.Point(0, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new System.Drawing.Size(64, 64);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "💰";
            lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.FromArgb(18, 24, 28);
            btnBack.CornerRadius = 8;
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.FromArgb(214, 240, 224);
            btnBack.Location = new System.Drawing.Point(20, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(150, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "←  Volver al Inicio";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(545, 680);
            Controls.Add(pnlRoot);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Capital Control - Iniciar Sesion (Vista previa)";
            pnlRoot.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlIcon.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlRoot;
        private CapitalControl.Controls.RoundedButton btnBack;
        private CapitalControl.Controls.RoundedPanel pnlIcon;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private CapitalControl.Controls.RoundedPanel pnlCard;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPasswordLabel;
        private System.Windows.Forms.TextBox txtPassword;
        private CapitalControl.Controls.RoundedButton btnShowPassword;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Button btnForgot;
        private CapitalControl.Controls.RoundedButton btnLogin;
        private System.Windows.Forms.Panel pnlDividerLeft;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Panel pnlDividerRight;
        private CapitalControl.Controls.RoundedButton btnGoogle;
        private CapitalControl.Controls.RoundedButton btnGithub;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Button btnGoRegister;
    }
}
