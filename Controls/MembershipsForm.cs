using System;
using System.Windows.Forms;

namespace CapitalControl.Controls
{
    public partial class MembershipsForm : Form
    {
        public event EventHandler<string> NavigateRequested;

        public MembershipsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "MembershipsForm";
            this.Size = new System.Drawing.Size(800, 600);
        }
    }
}