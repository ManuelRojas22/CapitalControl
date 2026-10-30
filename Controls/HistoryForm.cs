using System;
using System.Windows.Forms;

namespace CapitalControl.Controls
{
    public partial class HistoryForm : Form
    {
        public event EventHandler<string> NavigateRequested;

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "HistoryForm";
            this.Size = new System.Drawing.Size(800, 600);
        }
    }
}