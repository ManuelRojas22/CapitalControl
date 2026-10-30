using System;
using System.Globalization;
using System.Windows.Forms;

namespace CapitalControl
{
    /// <summary>
    /// Dialogo de previsualizacion (WinForms) para crear o editar una deuda/credito.
    /// Generado con el patron estandar de InitializeComponent para poder abrirse y editarse
    /// desde el Diseñador de Windows Forms de Visual Studio, replicando los campos de
    /// Controls/InputDialog.xaml (version WPF) usados por DebtsCreditsView.
    /// </summary>
    public partial class DebtEditForm : Form
    {
        public string DebtCreditor { get; private set; }
        public bool DebtIsBank { get; private set; }
        public decimal DebtTotal { get; private set; }
        public decimal DebtPaid { get; private set; }
        public DateTime DebtDueDate { get; private set; }
        public double DebtInterestRate { get; private set; }

        public DebtEditForm(string creditor, bool isBank, decimal total, decimal paid, DateTime dueDate, double interestRate)
        {
            InitializeComponent();

            txtCreditor.Text = creditor;
            cmbType.SelectedIndex = isBank ? 0 : 1;
            txtTotal.Text = total > 0 ? total.ToString("0", CultureInfo.InvariantCulture) : "";
            txtPaid.Text = paid.ToString("0", CultureInfo.InvariantCulture);
            txtDue.Text = dueDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            txtRate.Text = interestRate.ToString("0.0", CultureInfo.InvariantCulture);

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            string creditor = (txtCreditor.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(creditor))
            {
                ShowError("El acreedor es requerido");
                return;
            }

            decimal total;
            if (!TryParseMoney(txtTotal.Text, out total) || total <= 0)
            {
                ShowError("El monto total debe ser un numero mayor a cero");
                return;
            }

            decimal paid;
            if (!TryParseMoney(txtPaid.Text, out paid))
            {
                paid = 0;
            }

            DateTime due;
            if (!DateTime.TryParseExact((txtDue.Text ?? "").Trim(), "yyyy-MM-dd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out due))
            {
                ShowError("La fecha limite debe tener el formato AAAA-MM-DD");
                return;
            }

            double rate;
            if (!double.TryParse((txtRate.Text ?? "").Replace(",", "."), NumberStyles.Any,
                    CultureInfo.InvariantCulture, out rate))
            {
                rate = 0;
            }

            DebtCreditor = creditor;
            DebtIsBank = cmbType.SelectedIndex != 1;
            DebtTotal = total;
            DebtPaid = paid;
            DebtDueDate = due;
            DebtInterestRate = rate;

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
