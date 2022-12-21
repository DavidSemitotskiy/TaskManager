namespace ProcessHandler
{
    partial class CreateProcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateProc = new System.Windows.Forms.Button();
            this.pathToOpenProcLabel = new System.Windows.Forms.Label();
            this.pathText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreateProc
            // 
            this.buttonCreateProc.Location = new System.Drawing.Point(85, 90);
            this.buttonCreateProc.Name = "buttonCreateProc";
            this.buttonCreateProc.Size = new System.Drawing.Size(95, 20);
            this.buttonCreateProc.TabIndex = 0;
            this.buttonCreateProc.Text = "Create";
            this.buttonCreateProc.UseVisualStyleBackColor = true;
            this.buttonCreateProc.Click += new System.EventHandler(this.buttonCreateProc_Click);
            // 
            // pathToOpenProcLabel
            // 
            this.pathToOpenProcLabel.AutoSize = true;
            this.pathToOpenProcLabel.Location = new System.Drawing.Point(28, 42);
            this.pathToOpenProcLabel.Name = "pathToOpenProcLabel";
            this.pathToOpenProcLabel.Size = new System.Drawing.Size(56, 13);
            this.pathToOpenProcLabel.TabIndex = 2;
            this.pathToOpenProcLabel.Text = "Input Path";
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(97, 39);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(152, 20);
            this.pathText.TabIndex = 3;
            // 
            // CreateProcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 122);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.pathToOpenProcLabel);
            this.Controls.Add(this.buttonCreateProc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProcForm";
            this.Text = "CreateProcForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateProc;
        private System.Windows.Forms.Label pathToOpenProcLabel;
        private System.Windows.Forms.TextBox pathText;
    }
}