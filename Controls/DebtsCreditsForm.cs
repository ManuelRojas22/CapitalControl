using System;
using System.Windows.Forms;

namespace CapitalControl.Controls
{
    public partial class DebtsCreditsForm : Form
    {
        public event EventHandler<string> NavigateRequested;

        public DebtsCreditsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "DebtsCreditsForm";
            this.Size = new System.Drawing.Size(800, 600);
        }
    }
}