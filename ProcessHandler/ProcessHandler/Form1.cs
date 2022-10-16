using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProcessHandler
{
    public partial class Form1 : Form
    {
        private ProcessHandler processHandler = new ProcessHandler();
        private string _matchPatternName = @":?(\d{1,}) :?([a-z-A-Z]+)";

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
                string[] columnsText = new string[] { $"{process.Id} {process.ProcessName}",
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
            var proc = processHandler.GetProcessById(GetIdFromProcNameInListView(ListViewOfProcesses.SelectedItems[0].SubItems[0].Text));
            processHandler.KillProcess(proc);
            UpdateListOfProcesses(searchString.Text);
        }

        private void allThreadsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var proc = processHandler.GetProcessById(GetIdFromProcNameInListView(ListViewOfProcesses.SelectedItems[0].SubItems[0].Text));
            var threads = processHandler.GetThreads(proc);
            var text = GetTextToShowThreadsInMessageBox(threads);
            MessageBox.Show(text, $"Threads for {proc.Id} - {proc.ProcessName}", MessageBoxButtons.OKCancel);
        }

        private string GetTextToShowThreadsInMessageBox(ProcessThreadCollection threads)
        {
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < threads.Count; i++)
            {
                text.Append($"{i + 1}){threads[i].Id} - {threads[i].CurrentPriority} - {threads[i].StartTime} - {threads[i].ThreadState}\n");
            }

            return text.ToString();
        }

        private void createProcessToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var createProcForm = new CreateProcForm();
            createProcForm.ShowDialog();
            var path = createProcForm.Path;

            try
            {
                Process.Start(new ProcessStartInfo(path));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private int GetIdFromProcNameInListView(string name)
        {
            var resultMatching = Regex.Match(name, _matchPatternName);
            return int.Parse(resultMatching.Groups[1].Value);
        }
    }
}
