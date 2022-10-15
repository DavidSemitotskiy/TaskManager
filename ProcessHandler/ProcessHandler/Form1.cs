using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ProcessHandler
{
    public partial class Form1 : Form
    {
        private ProcessHandler processHandler = new ProcessHandler();

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateListOfProcesses(string filter = null)
        {
            ListViewOfProcesses.Items.Clear();
            var processes = processHandler.ActiveProcesses;
            if (!string.IsNullOrWhiteSpace(filter))
            {
                processes = processes.Where(proc => proc.ProcessName.Contains(filter));
            }

            foreach (var process in processes)
            {
                string[] columnsText = new string[] { process.ProcessName,
                        $"{processHandler.GetUsedMemory(process)} Mb" };

                ListViewOfProcesses.Items.Add(new ListViewItem(columnsText));
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            UpdateListOfProcesses();
        }

        private void searchString_TextChanged(object sender, System.EventArgs e)
        {
            UpdateListOfProcesses(searchString.Text);
        }

        private void exitProcessToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var processes = processHandler.ActiveProcesses;
            processHandler.KillProcess(processes.FirstOrDefault(proc => proc.ProcessName == ListViewOfProcesses.SelectedItems[0].SubItems[0].Text));
            UpdateListOfProcesses(searchString.Text);
        }
    }
}
