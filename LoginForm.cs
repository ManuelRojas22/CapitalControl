using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using CapitalControl.Services;
using CapitalControl.Controls;

namespace CapitalControl
{
    /// <summary>
    /// Formulario de previsualizacion (WinForms) del Login.
    /// Generado con el patron estandar de InitializeComponent para poder
    /// abrirse y editarse desde el Diseñador de Windows Forms de Visual Studio,
    /// replicando el diseño de Views/LoginView.xaml (version WPF).
    /// </summary>
    public partial class LoginForm : Form
    {
        public event EventHandler<string> NavigateRequested;

        private bool _showPassword;

        private bool _layoutReady = false;

        public LoginForm()
        {
            InitializeComponent();

            // Prevent layout / styling code from running in the VS Designer
            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            // Responsive form settings
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(360, 520);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(30,30,30);

            // Ensure root panel fills and scrolls
            pnlRoot.Dock = DockStyle.Fill;
            pnlRoot.AutoScroll = true;

            // Anchor back button top-left
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            StyleBackButton();

            // Header elements centered horizontally, stay at top
            pnlIcon.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblSubtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            StyleHeader();

            // Card will be centered manually in Resize
            pnlCard.Anchor = AnchorStyles.None;
            StyleCard();

            // Inner card controls: explicit anchors per control
            // Stretch with card width
            lblEmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmailError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPasswordError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Fixed width, left-aligned
            chkRemember.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnGoogle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblNoAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlDividerLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblDivider.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Fixed width, right-aligned (follow card right edge)
            btnShowPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnForgot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGithub.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGoRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlDividerRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            StyleInputsAndButtons();

            this.Resize += LoginForm_Resize;
            this.Load += LoginForm_Load;
            WireEvents();
            // Do NOT call PerformCardLayout here; keep Designer positions until first Resize after Load
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _layoutReady = true;
            PerformCardLayout();
        }

        private void StyleBackButton()
        {
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.BackColor = Color.Transparent;
            btnBack.ForeColor = Color.FromArgb(214, 240, 224);
            btnBack.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            btnBack.Cursor = Cursors.Hand;
        }

        private void StyleHeader()
        {
            // Icon panel already rounded, keep its color
            lblIcon.ForeColor = Color.White;
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 20f, FontStyle.Bold);
            lblTitle.BackColor = Color.Transparent;
            lblSubtitle.ForeColor = Color.FromArgb(214, 238, 230);
            lblSubtitle.Font = new Font("Segoe UI", 10f);
            lblSubtitle.BackColor = Color.Transparent;
        }

        private void StyleCard()
        {
            pnlCard.BackColor = Color.FromArgb(22, 22, 25);
            // RoundedPanel already paints rounded corners
        }

        private void StyleInputsAndButtons()
        {
            // Labels
            foreach (Control c in pnlCard.Controls)
            {
                if (c is Label lbl && lbl != lblDivider && lbl != lblNoAccount)
                {
                    lbl.ForeColor = Color.FromArgb(210, 210, 213);
                    lbl.Font = new Font("Segoe UI", 9.5f);
                }
            }

            // TextBoxes
            StyleTextBox(txtEmail, "correo@ejemplo.com");
            StyleTextBox(txtPassword, null, true);

            // Error labels
            lblEmailError.ForeColor = Color.FromArgb(239, 68, 68);
            lblEmailError.Font = new Font("Segoe UI", 8.5f);
            lblEmailError.Visible = false;
            lblPasswordError.ForeColor = Color.FromArgb(239, 68, 68);
            lblPasswordError.Font = new Font("Segoe UI", 8.5f);
            lblPasswordError.Visible = false;

            // CheckBox
            chkRemember.ForeColor = Color.FromArgb(200, 200, 203);
            chkRemember.Font = new Font("Segoe UI", 9.5f);
            chkRemember.FlatStyle = FlatStyle.Flat;
            chkRemember.Cursor = Cursors.Hand;

            // Forgot link
            btnForgot.FlatStyle = FlatStyle.Flat;
            btnForgot.FlatAppearance.BorderSize = 0;
            btnForgot.BackColor = Color.FromArgb(22, 22, 25);
            btnForgot.ForeColor = Color.FromArgb(70, 156, 255);
            btnForgot.Font = new Font("Segoe UI", 9f);
            btnForgot.Cursor = Cursors.Hand;
            btnForgot.TextAlign = ContentAlignment.MiddleRight;

            // Login button
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.BackColor = Color.FromArgb(37, 110, 235);
            btnLogin.ForeColor = Color.White;
            btnLogin.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Height = 46;

            // Divider - hide the horizontal line behind the card
            pnlDividerLeft.BackColor = Color.Transparent;
            pnlDividerRight.BackColor = Color.Transparent;
            lblDivider.Visible = false;

            // Social buttons
            StyleSocialButton(btnGoogle, "G   Google");
            StyleSocialButton(btnGithub, "GitHub");

            // Bottom link
            lblNoAccount.ForeColor = Color.FromArgb(150, 150, 154);
            lblNoAccount.Font = new Font("Segoe UI", 9.5f);
            lblNoAccount.TextAlign = ContentAlignment.MiddleRight;
            btnGoRegister.FlatStyle = FlatStyle.Flat;
            btnGoRegister.FlatAppearance.BorderSize = 0;
            btnGoRegister.BackColor = Color.FromArgb(22, 22, 25);
            btnGoRegister.ForeColor = Color.FromArgb(46, 204, 113);
            btnGoRegister.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            btnGoRegister.Cursor = Cursors.Hand;
            btnGoRegister.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void StyleTextBox(TextBox tb, string placeholder, bool isPassword = false)
        {
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.BackColor = Color.FromArgb(36, 36, 40);
            tb.ForeColor = Color.White;
            tb.Font = new Font("Segoe UI", 10.5f);
            tb.Height = 30;
            if (isPassword) tb.UseSystemPasswordChar = true;
            if (!string.IsNullOrEmpty(placeholder))
            {
                tb.Text = placeholder;
                tb.ForeColor = Color.Gray;
                tb.GotFocus += (s, e) =>
                {
                    if (tb.Text == placeholder) { tb.Text = ""; tb.ForeColor = Color.White; }
                };
                tb.LostFocus += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(tb.Text)) { tb.Text = placeholder; tb.ForeColor = Color.Gray; }
                };
            }
        }

        private void StyleSocialButton(RoundedButton btn, string text)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.FromArgb(63, 63, 68);
            btn.BackColor = Color.FromArgb(36, 36, 40);
            btn.ForeColor = Color.FromArgb(230, 230, 233);
            btn.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Text = text;
            btn.Height = 40;
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            if (_layoutReady)
                PerformCardLayout();
        }

        private void PerformCardLayout()
        {
            int hMargin = 20;
            int vMargin = 20;
            int maxCardWidth = 420;
            int designedCardHeight = 412; // altura tal cual quedó en el Designer

            int cardWidth = Math.Min(maxCardWidth, this.ClientSize.Width - 2 * hMargin);
            if (cardWidth < 280) cardWidth = 280;

            int availableHeight = this.ClientSize.Height - 2 * vMargin;
            int cardHeight = Math.Min(designedCardHeight, Math.Max(200, availableHeight));

            pnlCard.Width = cardWidth;
            pnlCard.Height = cardHeight;
            pnlCard.Left = (this.ClientSize.Width - cardWidth) / 2;
            pnlCard.Top = Math.Max(vMargin, (this.ClientSize.Height - cardHeight) / 2);

            CenterHorizontally(pnlIcon);
            CenterHorizontally(lblTitle);
            CenterHorizontally(lblSubtitle);
        }

        private void CenterHorizontally(Control ctrl)
        {
            if (ctrl != null)
                ctrl.Left = (this.ClientSize.Width - ctrl.Width) / 2;
        }

        private void WireEvents()
        {
            btnShowPassword.Click += BtnShowPassword_Click;
            btnLogin.Click += BtnLogin_Click;
            btnForgot.Click += BtnForgot_Click;
            btnGoRegister.Click += (s, e) => Raise("register");
            btnBack.Click += (s, e) => Raise("landing");
            btnGoogle.Click += (s, e) => ShowSocialDemo("Google");
            btnGithub.Click += (s, e) => ShowSocialDemo("GitHub");

            txtEmail.GotFocus += (s, e) =>
            {
                if (txtEmail.Text == "correo@ejemplo.com") txtEmail.Text = string.Empty;
            };
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            _showPassword = !_showPassword;
            txtPassword.UseSystemPasswordChar = !_showPassword;
        }

        private static void ShowSocialDemo(string provider)
        {
            MessageBox.Show($"En el mockup no hay integracion real con {provider}.",
                "Inicio de sesion social", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En el mockup no hay recuperacion de contrasena. Usa cualquier correo valido.",
                "Recuperar contrasena", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblEmailError.Visible = false;
            lblPasswordError.Visible = false;

            bool valid = true;
            string email = (txtEmail.Text ?? string.Empty).Trim();
            string password = txtPassword.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(email))
            {
                Show(lblEmailError, "El correo electronico es requerido");
                valid = false;
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Show(lblEmailError, "Ingresa un correo electronico valido");
                valid = false;
            }

            if (string.IsNullOrEmpty(password))
            {
                Show(lblPasswordError, "La contrasena es requerida");
                valid = false;
            }
            else if (password.Length < 6)
            {
                Show(lblPasswordError, "La contrasena debe tener al menos 6 caracteres");
                valid = false;
            }

            if (!valid) return;

            AppData.UserEmail = email;
            btnLogin.Enabled = false;
            btnLogin.Text = "Iniciando sesion...";

            Timer timer = new Timer { Interval = 700 };
            timer.Tick += delegate
            {
                timer.Stop();
                timer.Dispose();
                btnLogin.Enabled = true;
                btnLogin.Text = "Iniciar Sesion";
                Raise("app");
            };
            timer.Start();
        }

        private void Raise(string target)
        {
            EventHandler<string> handler = NavigateRequested;
            if (handler != null) handler(this, target);
        }

        private static void Show(Label target, string message)
        {
            target.Text = message;
            target.Visible = true;
        }
    }
}
