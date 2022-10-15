﻿namespace ProcessHandler
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.filterByName = new System.Windows.Forms.ToolStripLabel();
            this.searchString = new System.Windows.Forms.ToolStripTextBox();
            this.ListViewOfProcesses = new System.Windows.Forms.ListView();
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UsedMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripForListItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitThreeOfProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStripForListItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByName,
            this.searchString});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // ListViewOfProcesses
            // 
            this.ListViewOfProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.UsedMemory});
            this.ListViewOfProcesses.ContextMenuStrip = this.contextMenuStripForListItem;
            this.ListViewOfProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewOfProcesses.GridLines = true;
            this.ListViewOfProcesses.HideSelection = false;
            this.ListViewOfProcesses.Location = new System.Drawing.Point(0, 25);
            this.ListViewOfProcesses.MultiSelect = false;
            this.ListViewOfProcesses.Name = "ListViewOfProcesses";
            this.ListViewOfProcesses.Size = new System.Drawing.Size(800, 425);
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
            // 
            // exitProcessToolStripMenuItem
            // 
            this.exitProcessToolStripMenuItem.Name = "exitProcessToolStripMenuItem";
            this.exitProcessToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitProcessToolStripMenuItem.Text = "Exit Process";
            // 
            // exitThreeOfProcessToolStripMenuItem
            // 
            this.exitThreeOfProcessToolStripMenuItem.Name = "exitThreeOfProcessToolStripMenuItem";
            this.exitThreeOfProcessToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitThreeOfProcessToolStripMenuItem.Text = "Exit Three of Process";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListViewOfProcesses);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "ProcessHandler";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStripForListItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel filterByName;
        private System.Windows.Forms.ToolStripTextBox searchString;
        private System.Windows.Forms.ListView ListViewOfProcesses;
        private System.Windows.Forms.ColumnHeader ProcessName;
        private System.Windows.Forms.ColumnHeader UsedMemory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForListItem;
        private System.Windows.Forms.ToolStripMenuItem allThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitThreeOfProcessToolStripMenuItem;
    }
}

