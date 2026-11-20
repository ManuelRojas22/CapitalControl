using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CapitalControl.Services;

namespace CapitalControl
{
    public class AccesoForm : Form
    {
        public event EventHandler<string> NavigateRequested;

        private readonly TextBox txtEmail = new TextBox();
        private readonly TextBox txtClave = new TextBox();
        private readonly Button btnIngresar = new Button { Text = "Iniciar sesión" };
        private readonly Button btnMostrar = new Button { Text = "Ver" };
        private readonly Button btnRegistrar = new Button { Text = "Crear cuenta" };
        private readonly Label lblError = new Label();

        public AccesoForm()
        {
            Text = "CapitalControl - Acceso";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            ClientSize = new Size(390, 220);
            BackColor = Color.FromArgb(30, 30, 30);
            ForeColor = Color.White;

            lblError.Location = new Point(30, 15);
            lblError.Size = new Size(330, 25);
            lblError.ForeColor = Color.FromArgb(239, 68, 68);
            lblError.Visible = false;

            var lblEmail = new Label
            {
                Text = "Correo electrónico",
                Location = new Point(30, 48),
                Size = new Size(330, 20)
            };
            txtEmail.Location = new Point(30, 70);
            txtEmail.Size = new Size(330, 28);

            var lblClave = new Label
            {
                Text = "Contraseña",
                Location = new Point(30, 106),
                Size = new Size(330, 20)
            };
            txtClave.Location = new Point(30, 128);
            txtClave.Size = new Size(330, 28);
            txtClave.UseSystemPasswordChar = true;

            btnMostrar.Location = new Point(30, 170);
            btnMostrar.Size = new Size(80, 32);
            btnIngresar.Location = new Point(120, 170);
            btnIngresar.Size = new Size(130, 32);
            btnRegistrar.Location = new Point(260, 170);
            btnRegistrar.Size = new Size(100, 32);

            foreach (var boton in new[] { btnMostrar, btnIngresar, btnRegistrar })
            {
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 0;
                boton.BackColor = Color.FromArgb(37, 110, 235);
                boton.ForeColor = Color.White;
                boton.Cursor = Cursors.Hand;
            }

            Controls.Add(lblError);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblClave);
            Controls.Add(txtClave);
            Controls.Add(btnMostrar);
            Controls.Add(btnIngresar);
            Controls.Add(btnRegistrar);

            btnIngresar.Click += Ingresar_Click;
            btnMostrar.Click += (s, e) =>
            {
                txtClave.UseSystemPasswordChar = !txtClave.UseSystemPasswordChar;
                btnMostrar.Text = txtClave.UseSystemPasswordChar ? "Ver" : "Ocultar";
            };
            btnRegistrar.Click += (s, e) => Raise("register");
            txtClave.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    Ingresar_Click(this, EventArgs.Empty);
                }
            };
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            string email = txtEmail.Text.Trim();
            string clave = txtClave.Text;

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblError.Text = "Ingresa un correo electrónico válido.";
                lblError.Visible = true;
                return;
            }
            if (clave.Length == 0)
            {
                lblError.Text = "La contraseña es requerida.";
                lblError.Visible = true;
                return;
            }

            string nombre;
            try
            {
                nombre = Conexion.ValidarUsuario(email, clave);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos:\n" + ex.Message,
                    "CapitalControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nombre == null)
            {
                lblError.Text = "Correo o contraseña incorrectos.";
                lblError.Visible = true;
                txtClave.Clear();
                txtClave.Focus();
                return;
            }

            AppData.UserEmail = email;
            AppData.UserName = nombre;
            AppData.UserId = BaseDatos.ObtenerIdUsuario(email);
            if (!BaseDatos.CargarDatosUsuario()) return;

            Raise("menu");
        }

        private void Raise(string destino)
        {
            EventHandler<string> handler = NavigateRequested;
            if (handler != null) handler(this, destino);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Raise("landing");
            }
            base.OnFormClosing(e);
        }
    }
}
