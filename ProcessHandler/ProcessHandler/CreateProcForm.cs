using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProcessHandler
{
    public partial class CreateProcForm : Form
    {
        public CreateProcForm()
        {
            InitializeComponent();
        }

        private void buttonCreateProc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pathText.Text))
            {
                MessageBox.Show("Input path", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                Process.Start(new ProcessStartInfo(pathText.Text));
            }
            catch
            {
                MessageBox.Show("Incorrect path", "Error", MessageBoxButtons.OK);
            }

            Close();
        }
    }
}
