namespace ProcessHandler
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripForFilteringProcesses = new System.Windows.Forms.ToolStrip();
            this.filterByName = new System.Windows.Forms.ToolStripLabel();
            this.searchString = new System.Windows.Forms.ToolStripTextBox();
            this.ListViewOfProcesses = new System.Windows.Forms.ListView();
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsedMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BasePriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HandleCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainWindowTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripForListItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitThreeOfProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SessionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountThreads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripForFilteringProcesses.SuspendLayout();
            this.contextMenuStripForListItem.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripForFilteringProcesses
            // 
            this.toolStripForFilteringProcesses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByName,
            this.searchString});
            this.toolStripForFilteringProcesses.Location = new System.Drawing.Point(0, 24);
            this.toolStripForFilteringProcesses.Name = "toolStripForFilteringProcesses";
            this.toolStripForFilteringProcesses.Size = new System.Drawing.Size(800, 25);
            this.toolStripForFilteringProcesses.TabIndex = 0;
            this.toolStripForFilteringProcesses.Text = "toolStrip1";
            // 
            // filterByName
            // 
            this.filterByName.Name = "filterByName";
            this.filterByName.Size = new System.Drawing.Size(125, 22);
            this.filterByName.Text = "Filter by process name";
            // 
            // searchString
            // 
            this.searchString.Name = "searchString";
            this.searchString.Size = new System.Drawing.Size(100, 25);
            this.searchString.TextChanged += new System.EventHandler(this.searchString_TextChanged);
            // 
            // ListViewOfProcesses
            // 
            this.ListViewOfProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.UsedMemory,
            this.BasePriority,
            this.HandleCount,
            this.MainWindowTitle,
            this.SessionId,
            this.CountThreads});
            this.ListViewOfProcesses.ContextMenuStrip = this.contextMenuStripForListItem;
            this.ListViewOfProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewOfProcesses.GridLines = true;
            this.ListViewOfProcesses.HideSelection = false;
            this.ListViewOfProcesses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListViewOfProcesses.Location = new System.Drawing.Point(0, 49);
            this.ListViewOfProcesses.MultiSelect = false;
            this.ListViewOfProcesses.Name = "ListViewOfProcesses";
            this.ListViewOfProcesses.Size = new System.Drawing.Size(800, 401);
            this.ListViewOfProcesses.TabIndex = 1;
            this.ListViewOfProcesses.UseCompatibleStateImageBehavior = false;
            this.ListViewOfProcesses.View = System.Windows.Forms.View.Details;
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "Name";
            this.ProcessName.Width = 200;
            // 
            // UsedMemory
            // 
            this.UsedMemory.Text = "Memory";
            this.UsedMemory.Width = 200;
            // 
            // BasePriority
            // 
            this.BasePriority.Text = "Base priority";
            this.BasePriority.Width = 63;
            // 
            // HandleCount
            // 
            this.HandleCount.Text = "Count of handles";
            this.HandleCount.Width = 137;
            // 
            // MainWindowTitle
            // 
            this.MainWindowTitle.Text = "Main window title";
            this.MainWindowTitle.Width = 178;
            // 
            // contextMenuStripForListItem
            // 
            this.contextMenuStripForListItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allThreadsToolStripMenuItem,
            this.exitProcessToolStripMenuItem,
            this.exitThreeOfProcessToolStripMenuItem});
            this.contextMenuStripForListItem.Name = "contextMenuStripForListItem";
            this.contextMenuStripForListItem.Size = new System.Drawing.Size(183, 70);
            // 
            // allThreadsToolStripMenuItem
            // 
            this.allThreadsToolStripMenuItem.Name = "allThreadsToolStripMenuItem";
            this.allThreadsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.allThreadsToolStripMenuItem.Text = "All Threads";
            this.allThreadsToolStripMenuItem.Click += new System.EventHandler(this.allThreadsToolStripMenuItem_Click);
            // 
            // exitProcessToolStripMenuItem
            // 
            this.exitProcessToolStripMenuItem.Name = "exitProcessToolStripMenuItem";
            this.exitProcessToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitProcessToolStripMenuItem.Text = "Exit Process";
            this.exitProcessToolStripMenuItem.Click += new System.EventHandler(this.exitProcessToolStripMenuItem_Click);
            // 
            // exitThreeOfProcessToolStripMenuItem
            // 
            this.exitThreeOfProcessToolStripMenuItem.Name = "exitThreeOfProcessToolStripMenuItem";
            this.exitThreeOfProcessToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitThreeOfProcessToolStripMenuItem.Text = "Exit Three of Process";
            this.exitThreeOfProcessToolStripMenuItem.Click += new System.EventHandler(this.exitThreeOfProcessToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProcessToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createProcessToolStripMenuItem
            // 
            this.createProcessToolStripMenuItem.Name = "createProcessToolStripMenuItem";
            this.createProcessToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.createProcessToolStripMenuItem.Text = "Create Process";
            this.createProcessToolStripMenuItem.Click += new System.EventHandler(this.createProcessToolStripMenuItem_Click);
            // 
            // SessionId
            // 
            this.SessionId.Text = "Session id";
            // 
            // CountThreads
            // 
            this.CountThreads.Text = "Count of threads";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListViewOfProcesses);
            this.Controls.Add(this.toolStripForFilteringProcesses);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ProcessHandler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripForFilteringProcesses.ResumeLayout(false);
            this.toolStripForFilteringProcesses.PerformLayout();
            this.contextMenuStripForListItem.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripForFilteringProcesses;
        private System.Windows.Forms.ToolStripLabel filterByName;
        private System.Windows.Forms.ToolStripTextBox searchString;
        private System.Windows.Forms.ListView ListViewOfProcesses;
        private System.Windows.Forms.ColumnHeader ProcessName;
        private System.Windows.Forms.ColumnHeader UsedMemory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForListItem;
        private System.Windows.Forms.ToolStripMenuItem allThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitThreeOfProcessToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProcessToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader BasePriority;
        private System.Windows.Forms.ColumnHeader HandleCount;
        private System.Windows.Forms.ColumnHeader MainWindowTitle;
        private System.Windows.Forms.ColumnHeader SessionId;
        private System.Windows.Forms.ColumnHeader CountThreads;
    }
}

