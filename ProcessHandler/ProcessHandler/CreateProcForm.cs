using System;
using System.Windows.Forms;

namespace ProcessHandler
{
    public partial class CreateProcForm : Form
    {
        public CreateProcForm()
        {
            InitializeComponent();
        }

        public string Path { get; private set; }

        private void buttonCreateProc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pathText.Text))
            {
                MessageBox.Show("Input path", "Error", MessageBoxButtons.OK);
                return;
            }

            Path = pathText.Text;
            Close();
        }
    }
}
