using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapitalControl
{
    public class MenuPForm : Form
    {
        public event EventHandler<string> NavigateRequested;

        private readonly Timer reloj = new Timer { Interval = 1000 };
        private readonly Label lblHora = new Label();
        private readonly Label lblFecha = new Label();

        public MenuPForm()
        {
            Text = "CapitalControl - Menú";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            ClientSize = new Size(420, 460);
            BackColor = Color.FromArgb(30, 30, 30);
            ForeColor = Color.White;

            AgregarBoton("Dashboard", "dashboard", 40, 30);
            AgregarBoton("Transacciones", "transaction", 40, 75);
            AgregarBoton("Deudas y créditos", "debts", 40, 120);
            AgregarBoton("Metas de ahorro", "goals", 40, 165);
            AgregarBoton("Membresías", "memberships", 40, 210);
            AgregarBoton("Historial", "history", 40, 255);
            AgregarBoton("Usuarios", "usuarios", 40, 300);
            AgregarBoton("Inicio", "landing", 40, 345);

            lblHora.Location = new Point(40, 395);
            lblHora.Size = new Size(130, 25);
            lblFecha.Location = new Point(180, 395);
            lblFecha.Size = new Size(200, 25);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);

            reloj.Tick += Reloj_Tick;
            Reloj_Tick(this, EventArgs.Empty);
            reloj.Start();
        }

        private void AgregarBoton(string texto, string destino, int x, int y)
        {
            var boton = new Button
            {
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(340, 36),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(37, 110, 235),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            boton.FlatAppearance.BorderSize = 0;
            boton.Click += (s, e) => Raise(destino);
            Controls.Add(boton);
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
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
