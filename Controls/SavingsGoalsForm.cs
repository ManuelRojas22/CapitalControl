using System;
using System.Windows.Forms;

namespace CapitalControl.Controls
{
    public partial class SavingsGoalsForm : Form
    {
        public event EventHandler<string> NavigateRequested;

        public SavingsGoalsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "SavingsGoalsForm";
            this.Size = new System.Drawing.Size(800, 600);
        }
    }
}