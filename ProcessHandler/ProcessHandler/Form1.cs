using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace ProcessHandler
{
    public partial class Form1 : Form
    {
        private delegate void UpdateListViewDelegate(string filter);
        private ProcessHandler processHandler = new ProcessHandler();
        private string _matchPatternName = @":?(\d{1,}) :?([a-z-A-Z]+)";
        private bool _textChanged = false;
        private bool _isItemsDeleted = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateListOfProcesses(string filter = null)
        {
            if (ListViewOfProcesses.InvokeRequired)
            {
                var deleg = new UpdateListViewDelegate(UpdateListOfProcesses);
                try
                {
                    Invoke(deleg, searchString.Text);
                }
                catch { }

                return;
            }

            int topItemIndex = 0;
            if (ListViewOfProcesses.TopItem != null)
            {
                topItemIndex = ListViewOfProcesses.TopItem.Index;
            }

            ListViewOfProcesses.BeginUpdate();
            int selectedItem = -1;
            if (ListViewOfProcesses.SelectedIndices.Count != 0)
            {
                selectedItem = ListViewOfProcesses.SelectedIndices[0];
            }

            ListViewOfProcesses.Items.Clear();
            var processes = processHandler.ActiveProcesses;
            if (!string.IsNullOrWhiteSpace(filter))
            {
                if (_textChanged)
                {
                    selectedItem = -1;
                }

                processes = processes.Where(proc => proc.ProcessName.Contains(filter));
            }

            foreach (var process in processes)
            {
                string[] columnsText = new string[] { $"{ process.Id } { process.ProcessName }",
                        $"{ processHandler.GetUsedMemory(process) } Mb", $"{ process.BasePriority }",
                        $"{ process.HandleCount }", $"{ process.MainWindowTitle }",
                        $"{ process.SessionId }", $"{ process.Threads.Count }"};

                ListViewOfProcesses.Items.Add(new ListViewItem(columnsText));
            }

            if (selectedItem >= 0 && !_isItemsDeleted)
            {
                ListViewOfProcesses.Items[selectedItem].Selected = true;
            }

            _textChanged = false;
            _isItemsDeleted = false;
            ListViewOfProcesses.EndUpdate();
            try
            {
                ListViewOfProcesses.TopItem = ListViewOfProcesses.Items[topItemIndex];
            }
            catch (Exception ex) { }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    UpdateListOfProcesses(searchString.Text);
                    Thread.Sleep(7000);
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void searchString_TextChanged(object sender, System.EventArgs e)
        {
            _textChanged = true;
            UpdateListOfProcesses(searchString.Text);
        }

        private void exitProcessToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var proc = processHandler.GetProcessById(GetIdFromProcNameInListView(ListViewOfProcesses.SelectedItems[0].SubItems[0].Text));
            processHandler.KillProcess(proc);
            _isItemsDeleted = true;
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
        }

        private int GetIdFromProcNameInListView(string name)
        {
            var resultMatching = Regex.Match(name, _matchPatternName);
            return int.Parse(resultMatching.Groups[1].Value);
        }

        private void exitThreeOfProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc = processHandler.GetProcessById(GetIdFromProcNameInListView(ListViewOfProcesses.SelectedItems[0].SubItems[0].Text));
            var parentId = processHandler.GetParentProcessId(proc);
            processHandler.KillChildrenProc(parentId);
            _isItemsDeleted = true;
            UpdateListOfProcesses(searchString.Text);
        }
    }
}
