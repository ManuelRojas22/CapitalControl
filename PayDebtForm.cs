using System;
using System.Globalization;
using System.Windows.Forms;

namespace CapitalControl
{
    /// <summary>
    /// Dialogo de previsualizacion (WinForms) para registrar el pago de una deuda.
    /// Generado con el patron estandar de InitializeComponent para poder abrirse y editarse
    /// desde el Diseñador de Windows Forms de Visual Studio, replicando el flujo de
    /// "Registrar Pago" de DebtsCreditsView.xaml.cs (version WPF).
    /// </summary>
    public partial class PayDebtForm : Form
    {
        public decimal PaymentAmount { get; private set; }

        public PayDebtForm(string creditor, string remainingLabel)
        {
            InitializeComponent();

            lblSubtitle.Text = creditor + " - saldo pendiente " + remainingLabel;

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            decimal amount;
            if (!TryParseMoney(txtAmount.Text, out amount) || amount <= 0)
            {
                ShowError("El valor del pago debe ser un numero mayor a cero");
                return;
            }

            PaymentAmount = amount;

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
