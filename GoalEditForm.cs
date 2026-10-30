using System;
using System.Globalization;
using System.Windows.Forms;

namespace CapitalControl
{
    /// <summary>
    /// Dialogo de previsualizacion (WinForms) para crear o editar una meta de ahorro.
    /// Generado con el patron estandar de InitializeComponent para poder abrirse y editarse
    /// desde el Diseñador de Windows Forms de Visual Studio, replicando los campos de
    /// Controls/InputDialog.xaml (version WPF) usados por SavingsGoalsView.
    /// </summary>
    public partial class GoalEditForm : Form
    {
        private static readonly string[] ColorKeys = { "blue", "green", "purple", "red" };

        public string GoalName { get; private set; }
        public string GoalCategory { get; private set; }
        public decimal GoalTarget { get; private set; }
        public decimal GoalCurrent { get; private set; }
        public DateTime GoalTargetDate { get; private set; }
        public string GoalColorKey { get; private set; }

        public GoalEditForm(string name, string category, decimal target, decimal current, DateTime targetDate, string colorKey)
        {
            InitializeComponent();

            txtName.Text = name;
            txtCategory.Text = category;
            txtTarget.Text = target > 0 ? target.ToString("0", CultureInfo.InvariantCulture) : "";
            txtCurrent.Text = current.ToString("0", CultureInfo.InvariantCulture);
            txtTargetDate.Text = targetDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            int idx = Array.IndexOf(ColorKeys, colorKey);
            cmbColor.SelectedIndex = idx >= 0 ? idx : 0;

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            string name = (txtName.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                ShowError("El nombre de la meta es requerido");
                return;
            }

            string category = (txtCategory.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(category))
            {
                category = "Otros";
            }

            decimal target;
            if (!TryParseMoney(txtTarget.Text, out target) || target <= 0)
            {
                ShowError("El monto de la meta debe ser un numero mayor a cero");
                return;
            }

            decimal current;
            if (!TryParseMoney(txtCurrent.Text, out current))
            {
                current = 0;
            }

            DateTime targetDate;
            if (!DateTime.TryParseExact((txtTargetDate.Text ?? "").Trim(), "yyyy-MM-dd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out targetDate))
            {
                ShowError("La fecha meta debe tener el formato AAAA-MM-DD");
                return;
            }

            GoalName = name;
            GoalCategory = category;
            GoalTarget = target;
            GoalCurrent = current;
            GoalTargetDate = targetDate;
            GoalColorKey = ColorKeys[Math.Max(0, cmbColor.SelectedIndex)];

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
