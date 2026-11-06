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
    /// Formulario de previsualizacion (WinForms) del Registro.
    /// Generado con el patron estandar de InitializeComponent para poder
    /// abrirse y editarse desde el Diseñador de Windows Forms de Visual Studio,
    /// replicando el diseño de Views/RegisterView.xaml (version WPF).
    /// </summary>
    public partial class RegisterForm : Form
    {
        public event EventHandler<string> NavigateRequested;

        private bool _showPassword;
        private bool _showConfirm;
        private bool _layoutReady = false;

        public RegisterForm()
        {
            InitializeComponent();
            // Ensure title labels have no background so gradient shows through
            lblTitle.BackColor = Color.Transparent;
            lblSubtitle.BackColor = Color.Transparent;

            // Prevent layout / styling code from running in the VS Designer
            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            // Responsive form settings
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new Size(360, 620);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Ensure root panel fills and scrolls
            pnlRoot.Dock = DockStyle.Fill;
            pnlRoot.AutoScroll = true;

            // Anchor back button top-left
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Header elements centered horizontally, stay at top
            pnlIcon.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblSubtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Card will be centered manually in Resize
            pnlCard.Anchor = AnchorStyles.None;

            // Inner card controls: explicit anchors per control
            // Stretch with card width
            lblNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNameError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmailError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPasswordError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTerms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTermsError.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Fixed width, left-aligned
            chkTerms.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnGoogle.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblHaveAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pnlDividerLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblDivider.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Fixed width, right-aligned
            btnShowPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGithub.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGoLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlDividerRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this.Resize += RegisterForm_Resize;
            this.Load += RegisterForm_Load;
            WireEvents();
            // Do NOT call PerformCardLayout here; keep Designer positions until first Resize after Load
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            _layoutReady = true;
            PerformCardLayout();
        }

        private void RegisterForm_Resize(object sender, EventArgs e)
        {
            if (_layoutReady)
                PerformCardLayout();
        }

        private void PerformCardLayout()
        {
            int hMargin = 20;
            int vMargin = 20;
            int maxCardWidth = 460;
            int designedCardHeight = 574; // altura real de pnlCard en el Designer

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
            btnShowPassword.Click += (s, e) =>
            {
                _showPassword = !_showPassword;
                txtPassword.UseSystemPasswordChar = !_showPassword;
            };
            btnShowConfirm.Click += (s, e) =>
            {
                _showConfirm = !_showConfirm;
                txtConfirm.UseSystemPasswordChar = !_showConfirm;
            };
            btnTerms.Click += (s, e) => chkTerms.Checked = !chkTerms.Checked;
            btnRegister.Click += BtnRegister_Click;
            btnGoLogin.Click += (s, e) => Raise("login");
            btnBack.Click += (s, e) => Raise("landing");
            btnGoogle.Click += (s, e) => ShowSocialDemo("Google");
            btnGithub.Click += (s, e) => ShowSocialDemo("GitHub");
        }

        private static void ShowSocialDemo(string provider)
        {
            MessageBox.Show($"En el mockup no hay integracion real con {provider}.",
                "Registro social", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            HideErrors();

            bool valid = true;
            string name = (txtName.Text ?? string.Empty).Trim();
            string email = (txtEmail.Text ?? string.Empty).Trim();
            string password = txtPassword.Text ?? string.Empty;
            string confirm = txtConfirm.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(name))
            {
                Show(lblNameError, "El nombre completo es requerido");
                valid = false;
            }
            else if (name.Length < 3)
            {
                Show(lblNameError, "El nombre debe tener al menos 3 caracteres");
                valid = false;
            }

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
            else if (password.Length < 8)
            {
                Show(lblPasswordError, "La contrasena debe tener al menos 8 caracteres");
                valid = false;
            }
            else if (!Regex.IsMatch(password, "[A-Z]") || !Regex.IsMatch(password, "[a-z]") || !Regex.IsMatch(password, "[0-9]"))
            {
                Show(lblPasswordError, "Debe contener mayusculas, minusculas y numeros");
                valid = false;
            }

            if (string.IsNullOrEmpty(confirm))
            {
                Show(lblConfirmError, "Confirma tu contrasena");
                valid = false;
            }
            else if (confirm != password)
            {
                Show(lblConfirmError, "Las contrasenas no coinciden");
                valid = false;
            }

            if (!chkTerms.Checked)
            {
                Show(lblTermsError, "Debes aceptar los terminos y condiciones");
                valid = false;
            }

            if (!valid) return;

            string error = Conexion.RegistrarUsuario(name, email, password);
            if (error != "")
            {
                Show(lblEmailError, error);
                return;
            }

            AppData.UserName = name;
            AppData.UserEmail = email;
            AppData.UserId = BaseDatos.ObtenerIdUsuario(email);
            if (!BaseDatos.CargarDatosUsuario()) return;

            btnRegister.Enabled = false;
            btnRegister.Text = "Creando cuenta...";

            Timer timer = new Timer { Interval = 700 };
            timer.Tick += delegate
            {
                timer.Stop();
                timer.Dispose();
                btnRegister.Enabled = true;
                btnRegister.Text = "Crear Cuenta";
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

        private void HideErrors()
        {
            lblNameError.Visible = false;
            lblEmailError.Visible = false;
            lblPasswordError.Visible = false;
            lblConfirmError.Visible = false;
            lblTermsError.Visible = false;
        }
    }
}
