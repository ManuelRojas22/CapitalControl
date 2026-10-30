using System;
using System.Globalization;
using System.Windows.Forms;

namespace CapitalControl
{
    /// <summary>
    /// Dialogo de previsualizacion (WinForms) para crear o editar una membresia/suscripcion.
    /// Generado con el patron estandar de InitializeComponent para poder abrirse y editarse
    /// desde el Diseñador de Windows Forms de Visual Studio, replicando los campos de
    /// Controls/InputDialog.xaml (version WPF) usados por SubscriptionsView.
    /// </summary>
    public partial class MembershipEditForm : Form
    {
        public string MembershipName { get; private set; }
        public decimal MembershipCost { get; private set; }
        public int MembershipBillingDay { get; private set; }
        public string MembershipLogo { get; private set; }

        public MembershipEditForm(string name, decimal cost, int billingDay, string logo)
        {
            InitializeComponent();

            txtName.Text = name;
            txtCost.Text = cost > 0 ? cost.ToString("0", CultureInfo.InvariantCulture) : "";
            txtDay.Text = billingDay.ToString(CultureInfo.InvariantCulture);
            txtLogo.Text = logo;

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            string name = (txtName.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                ShowError("El nombre es requerido");
                return;
            }

            decimal cost;
            if (!TryParseMoney(txtCost.Text, out cost) || cost <= 0)
            {
                ShowError("El costo debe ser un numero mayor a cero");
                return;
            }

            int day;
            if (!int.TryParse((txtDay.Text ?? "").Trim(), out day) || day < 1 || day > 28)
            {
                ShowError("El dia de cobro debe estar entre 1 y 28");
                return;
            }

            MembershipName = name;
            MembershipCost = cost;
            MembershipBillingDay = day;
            MembershipLogo = (txtLogo.Text ?? "").Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        /// <summary>Misma logica que InputDialog.TryParseMoney (Controls/InputDialog.xaml.cs).</summary>
        private static bool TryParseMoney(string text, out decimal value)
        {
            text = (text ?? "").Replace("$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");
            return decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out value);
        }
    }
}
