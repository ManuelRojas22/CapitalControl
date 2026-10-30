namespace CapitalControl
{
    partial class RegisterForm
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
            lblNameLabel = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblNameError = new System.Windows.Forms.Label();
            lblEmailLabel = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmailError = new System.Windows.Forms.Label();
            lblPasswordLabel = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnShowPassword = new CapitalControl.Controls.RoundedButton();
            lblPasswordError = new System.Windows.Forms.Label();
            lblConfirmLabel = new System.Windows.Forms.Label();
            txtConfirm = new System.Windows.Forms.TextBox();
            btnShowConfirm = new CapitalControl.Controls.RoundedButton();
            lblConfirmError = new System.Windows.Forms.Label();
            chkTerms = new System.Windows.Forms.CheckBox();
            btnTerms = new System.Windows.Forms.Button();
            lblTermsError = new System.Windows.Forms.Label();
            btnRegister = new CapitalControl.Controls.RoundedButton();
            pnlDividerLeft = new System.Windows.Forms.Panel();
            lblDivider = new System.Windows.Forms.Label();
            pnlDividerRight = new System.Windows.Forms.Panel();
            btnGoogle = new CapitalControl.Controls.RoundedButton();
            btnGithub = new CapitalControl.Controls.RoundedButton();
            lblHaveAccount = new System.Windows.Forms.Label();
            btnGoLogin = new System.Windows.Forms.Button();
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
            pnlRoot.Name = "pnlRoot";
            pnlRoot.TabIndex = 0;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = System.Drawing.Color.FromArgb(22, 22, 25);
            pnlCard.Controls.Add(lblNameLabel);
            pnlCard.Controls.Add(txtName);
            pnlCard.Controls.Add(lblNameError);
            pnlCard.Controls.Add(lblEmailLabel);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblEmailError);
            pnlCard.Controls.Add(lblPasswordLabel);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(btnShowPassword);
            pnlCard.Controls.Add(lblPasswordError);
            pnlCard.Controls.Add(lblConfirmLabel);
            pnlCard.Controls.Add(txtConfirm);
            pnlCard.Controls.Add(btnShowConfirm);
            pnlCard.Controls.Add(lblConfirmError);
            pnlCard.Controls.Add(chkTerms);
            pnlCard.Controls.Add(btnTerms);
            pnlCard.Controls.Add(lblTermsError);
            pnlCard.Controls.Add(btnRegister);
            pnlCard.Controls.Add(pnlDividerLeft);
            pnlCard.Controls.Add(lblDivider);
            pnlCard.Controls.Add(pnlDividerRight);
            pnlCard.Controls.Add(btnGoogle);
            pnlCard.Controls.Add(btnGithub);
            pnlCard.Controls.Add(lblHaveAccount);
            pnlCard.Controls.Add(btnGoLogin);
            pnlCard.CornerRadius = 22;
            pnlCard.Location = new System.Drawing.Point(50, 216);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new System.Drawing.Size(460, 574);
            pnlCard.TabIndex = 0;
            // 
            // lblNameLabel
            // 
            lblNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblNameLabel.ForeColor = System.Drawing.Color.FromArgb(210, 210, 213);
            lblNameLabel.Location = new System.Drawing.Point(24, 22);
            lblNameLabel.Name = "lblNameLabel";
            lblNameLabel.Size = new System.Drawing.Size(320, 20);
            lblNameLabel.TabIndex = 0;
            lblNameLabel.Text = "Nombre Completo";
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtName.ForeColor = System.Drawing.Color.White;
            txtName.Location = new System.Drawing.Point(24, 44);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(412, 26);
            txtName.TabIndex = 1;
            // 
            // lblNameError
            // 
            lblNameError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblNameError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            lblNameError.Location = new System.Drawing.Point(24, 76);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new System.Drawing.Size(412, 18);
            lblNameError.TabIndex = 2;
            lblNameError.Text = "El nombre completo es requerido";
            lblNameError.Visible = false;
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(210, 210, 213);
            lblEmailLabel.Location = new System.Drawing.Point(24, 96);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new System.Drawing.Size(320, 20);
            lblEmailLabel.TabIndex = 3;
            lblEmailLabel.Text = "Correo Electronico";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtEmail.ForeColor = System.Drawing.Color.White;
            txtEmail.Location = new System.Drawing.Point(24, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(412, 26);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "correo@ejemplo.com";
            // 
            // lblEmailError
            // 
            lblEmailError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblEmailError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            lblEmailError.Location = new System.Drawing.Point(24, 150);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new System.Drawing.Size(412, 18);
            lblEmailError.TabIndex = 5;
            lblEmailError.Text = "El correo electronico es requerido";
            lblEmailError.Visible = false;
            // 
            // lblPasswordLabel
            // 
            lblPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(210, 210, 213);
            lblPasswordLabel.Location = new System.Drawing.Point(24, 170);
            lblPasswordLabel.Name = "lblPasswordLabel";
            lblPasswordLabel.Size = new System.Drawing.Size(320, 20);
            lblPasswordLabel.TabIndex = 6;
            lblPasswordLabel.Text = "Contrasena";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtPassword.ForeColor = System.Drawing.Color.White;
            txtPassword.Location = new System.Drawing.Point(24, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(372, 26);
            txtPassword.TabIndex = 7;
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
            btnShowPassword.Location = new System.Drawing.Point(400, 192);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new System.Drawing.Size(36, 30);
            btnShowPassword.TabIndex = 8;
            btnShowPassword.Text = "👁";
            btnShowPassword.UseVisualStyleBackColor = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblPasswordError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            lblPasswordError.Location = new System.Drawing.Point(24, 224);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new System.Drawing.Size(412, 18);
            lblPasswordError.TabIndex = 9;
            lblPasswordError.Text = "La contrasena es requerida";
            lblPasswordError.Visible = false;
            // 
            // lblConfirmLabel
            // 
            lblConfirmLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblConfirmLabel.ForeColor = System.Drawing.Color.FromArgb(210, 210, 213);
            lblConfirmLabel.Location = new System.Drawing.Point(24, 244);
            lblConfirmLabel.Name = "lblConfirmLabel";
            lblConfirmLabel.Size = new System.Drawing.Size(320, 20);
            lblConfirmLabel.TabIndex = 10;
            lblConfirmLabel.Text = "Confirmar Contrasena";
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtConfirm.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            txtConfirm.ForeColor = System.Drawing.Color.White;
            txtConfirm.Location = new System.Drawing.Point(24, 266);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new System.Drawing.Size(372, 26);
            txtConfirm.TabIndex = 11;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // btnShowConfirm
            // 
            btnShowConfirm.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            btnShowConfirm.CornerRadius = 6;
            btnShowConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            btnShowConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShowConfirm.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            btnShowConfirm.ForeColor = System.Drawing.Color.White;
            btnShowConfirm.Location = new System.Drawing.Point(400, 266);
            btnShowConfirm.Name = "btnShowConfirm";
            btnShowConfirm.Size = new System.Drawing.Size(36, 30);
            btnShowConfirm.TabIndex = 12;
            btnShowConfirm.Text = "👁";
            btnShowConfirm.UseVisualStyleBackColor = false;
            // 
            // lblConfirmError
            // 
            lblConfirmError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblConfirmError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            lblConfirmError.Location = new System.Drawing.Point(24, 298);
            lblConfirmError.Name = "lblConfirmError";
            lblConfirmError.Size = new System.Drawing.Size(412, 18);
            lblConfirmError.TabIndex = 13;
            lblConfirmError.Text = "Confirma tu contrasena";
            lblConfirmError.Visible = false;
            // 
            // chkTerms
            // 
            chkTerms.Cursor = System.Windows.Forms.Cursors.Hand;
            chkTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkTerms.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            chkTerms.Location = new System.Drawing.Point(24, 320);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new System.Drawing.Size(24, 40);
            chkTerms.TabIndex = 14;
            // 
            // btnTerms
            // 
            btnTerms.BackColor = System.Drawing.Color.FromArgb(22, 22, 25);
            btnTerms.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTerms.FlatAppearance.BorderSize = 0;
            btnTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTerms.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btnTerms.ForeColor = System.Drawing.Color.FromArgb(200, 200, 203);
            btnTerms.Location = new System.Drawing.Point(52, 320);
            btnTerms.Name = "btnTerms";
            btnTerms.Size = new System.Drawing.Size(384, 40);
            btnTerms.TabIndex = 15;
            btnTerms.Text = "Acepto los terminos y condiciones y la politica de privacidad";
            btnTerms.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            btnTerms.UseVisualStyleBackColor = false;
            // 
            // lblTermsError
            // 
            lblTermsError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblTermsError.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            lblTermsError.Location = new System.Drawing.Point(24, 362);
            lblTermsError.Name = "lblTermsError";
            lblTermsError.Size = new System.Drawing.Size(412, 18);
            lblTermsError.TabIndex = 16;
            lblTermsError.Text = "Debes aceptar los terminos y condiciones";
            lblTermsError.Visible = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.FromArgb(30, 197, 111);
            btnRegister.CornerRadius = 10;
            btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnRegister.ForeColor = System.Drawing.Color.White;
            btnRegister.Location = new System.Drawing.Point(24, 388);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(412, 46);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Crear Cuenta";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // pnlDividerLeft
            // 
            pnlDividerLeft.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            pnlDividerLeft.Location = new System.Drawing.Point(24, 455);
            pnlDividerLeft.Name = "pnlDividerLeft";
            pnlDividerLeft.Size = new System.Drawing.Size(140, 1);
            pnlDividerLeft.TabIndex = 18;
            // 
            // lblDivider
            // 
            lblDivider.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblDivider.ForeColor = System.Drawing.Color.FromArgb(140, 140, 145);
            lblDivider.Location = new System.Drawing.Point(174, 444);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new System.Drawing.Size(112, 22);
            lblDivider.TabIndex = 19;
            lblDivider.Text = "o registrate con";
            lblDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDividerRight
            // 
            pnlDividerRight.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            pnlDividerRight.Location = new System.Drawing.Point(296, 455);
            pnlDividerRight.Name = "pnlDividerRight";
            pnlDividerRight.Size = new System.Drawing.Size(140, 1);
            pnlDividerRight.TabIndex = 20;
            // 
            // btnGoogle
            // 
            btnGoogle.BackColor = System.Drawing.Color.FromArgb(36, 36, 40);
            btnGoogle.CornerRadius = 8;
            btnGoogle.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGoogle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnGoogle.ForeColor = System.Drawing.Color.FromArgb(230, 230, 233);
            btnGoogle.Location = new System.Drawing.Point(24, 480);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new System.Drawing.Size(198, 40);
            btnGoogle.TabIndex = 21;
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
            btnGithub.Location = new System.Drawing.Point(238, 480);
            btnGithub.Name = "btnGithub";
            btnGithub.Size = new System.Drawing.Size(198, 40);
            btnGithub.TabIndex = 22;
            btnGithub.Text = "⚙   GitHub";
            btnGithub.UseVisualStyleBackColor = false;
            // 
            // lblHaveAccount
            // 
            lblHaveAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblHaveAccount.ForeColor = System.Drawing.Color.FromArgb(150, 150, 154);
            lblHaveAccount.Location = new System.Drawing.Point(90, 540);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new System.Drawing.Size(160, 24);
            lblHaveAccount.TabIndex = 23;
            lblHaveAccount.Text = "Ya tienes una cuenta?";
            lblHaveAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGoLogin
            // 
            btnGoLogin.BackColor = System.Drawing.Color.FromArgb(22, 22, 25);
            btnGoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGoLogin.FlatAppearance.BorderSize = 0;
            btnGoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGoLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnGoLogin.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnGoLogin.Location = new System.Drawing.Point(256, 538);
            btnGoLogin.Name = "btnGoLogin";
            btnGoLogin.Size = new System.Drawing.Size(130, 28);
            btnGoLogin.TabIndex = 24;
            btnGoLogin.Text = "Inicia sesion aqui";
            btnGoLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnGoLogin.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(214, 238, 230);
            lblSubtitle.Location = new System.Drawing.Point(0, 172);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(560, 24);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Registrate para comenzar a gestionar tus finanzas";
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(0, 136);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(560, 34);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Crear Cuenta";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIcon
            // 
            pnlIcon.BackColor = System.Drawing.Color.FromArgb(20, 199, 120);
            pnlIcon.Controls.Add(lblIcon);
            pnlIcon.CornerRadius = 18;
            pnlIcon.Location = new System.Drawing.Point(248, 60);
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
            // RegisterForm
            // 
            BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(560, 820);
            Controls.Add(pnlRoot);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Capital Control - Crear Cuenta (Vista previa)";
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
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPasswordLabel;
        private System.Windows.Forms.TextBox txtPassword;
        private CapitalControl.Controls.RoundedButton btnShowPassword;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblConfirmLabel;
        private System.Windows.Forms.TextBox txtConfirm;
        private CapitalControl.Controls.RoundedButton btnShowConfirm;
        private System.Windows.Forms.Label lblConfirmError;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.Button btnTerms;
        private System.Windows.Forms.Label lblTermsError;
        private CapitalControl.Controls.RoundedButton btnRegister;
        private System.Windows.Forms.Panel pnlDividerLeft;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Panel pnlDividerRight;
        private CapitalControl.Controls.RoundedButton btnGoogle;
        private CapitalControl.Controls.RoundedButton btnGithub;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.Button btnGoLogin;
    }
}
