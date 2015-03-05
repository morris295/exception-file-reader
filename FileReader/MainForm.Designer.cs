namespace FileReader
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exceptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.argumentExceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathTooLongExceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryNotFoundExceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOExceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unauthorizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNotFoundExceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSupportedExceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityExceptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileSizeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileContentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exceptionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exceptionsToolStripMenuItem
            // 
            this.exceptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.argumentExceptionToolStripMenuItem,
            this.pathTooLongExceptionToolStripMenuItem,
            this.directoryNotFoundExceptionToolStripMenuItem,
            this.iOExceptionToolStripMenuItem,
            this.unauthorizedToolStripMenuItem,
            this.fileNotFoundExceptionToolStripMenuItem,
            this.notSupportedExceptionToolStripMenuItem,
            this.securityExceptionToolStripMenuItem});
            this.exceptionsToolStripMenuItem.Name = "exceptionsToolStripMenuItem";
            this.exceptionsToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.exceptionsToolStripMenuItem.Text = "Exceptions";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // argumentExceptionToolStripMenuItem
            // 
            this.argumentExceptionToolStripMenuItem.Name = "argumentExceptionToolStripMenuItem";
            this.argumentExceptionToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.argumentExceptionToolStripMenuItem.Text = "ArgumentException";
            this.argumentExceptionToolStripMenuItem.Click += new System.EventHandler(this.argumentExceptionToolStripMenuItem_Click);
            // 
            // pathTooLongExceptionToolStripMenuItem
            // 
            this.pathTooLongExceptionToolStripMenuItem.Name = "pathTooLongExceptionToolStripMenuItem";
            this.pathTooLongExceptionToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.pathTooLongExceptionToolStripMenuItem.Text = "PathTooLongException";
            this.pathTooLongExceptionToolStripMenuItem.Click += new System.EventHandler(this.pathTooLongExceptionToolStripMenuItem_Click);
            // 
            // directoryNotFoundExceptionToolStripMenuItem
            // 
            this.directoryNotFoundExceptionToolStripMenuItem.Name = "directoryNotFoundExceptionToolStripMenuItem";
            this.directoryNotFoundExceptionToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.directoryNotFoundExceptionToolStripMenuItem.Text = "DirectoryNotFoundException";
            this.directoryNotFoundExceptionToolStripMenuItem.Click += new System.EventHandler(this.directoryNotFoundExceptionToolStripMenuItem_Click);
            // 
            // iOExceptionToolStripMenuItem
            // 
            this.iOExceptionToolStripMenuItem.Name = "iOExceptionToolStripMenuItem";
            this.iOExceptionToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.iOExceptionToolStripMenuItem.Text = "IOException";
            this.iOExceptionToolStripMenuItem.Click += new System.EventHandler(this.iOExceptionToolStripMenuItem_Click);
            // 
            // unauthorizedToolStripMenuItem
            // 
            this.unauthorizedToolStripMenuItem.Name = "unauthorizedToolStripMenuItem";
            this.unauthorizedToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.unauthorizedToolStripMenuItem.Text = "UnauthorizedAccessException";
            this.unauthorizedToolStripMenuItem.Click += new System.EventHandler(this.unauthorizedToolStripMenuItem_Click);
            // 
            // fileNotFoundExceptionToolStripMenuItem
            // 
            this.fileNotFoundExceptionToolStripMenuItem.Name = "fileNotFoundExceptionToolStripMenuItem";
            this.fileNotFoundExceptionToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.fileNotFoundExceptionToolStripMenuItem.Text = "FileNotFoundException";
            this.fileNotFoundExceptionToolStripMenuItem.Click += new System.EventHandler(this.fileNotFoundExceptionToolStripMenuItem_Click);
            // 
            // notSupportedExceptionToolStripMenuItem
            // 
            this.notSupportedExceptionToolStripMenuItem.Name = "notSupportedExceptionToolStripMenuItem";
            this.notSupportedExceptionToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.notSupportedExceptionToolStripMenuItem.Text = "NotSupportedException";
            this.notSupportedExceptionToolStripMenuItem.Click += new System.EventHandler(this.notSupportedExceptionToolStripMenuItem_Click);
            // 
            // securityExceptionToolStripMenuItem
            // 
            this.securityExceptionToolStripMenuItem.Name = "securityExceptionToolStripMenuItem";
            this.securityExceptionToolStripMenuItem.Size = new System.Drawing.Size(276, 24);
            this.securityExceptionToolStripMenuItem.Text = "SecurityException";
            this.securityExceptionToolStripMenuItem.Click += new System.EventHandler(this.securityExceptionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSizeToolStripStatusLabel,
            this.fileNameToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileSizeToolStripStatusLabel
            // 
            this.fileSizeToolStripStatusLabel.Name = "fileSizeToolStripStatusLabel";
            this.fileSizeToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // fileNameToolStripStatusLabel
            // 
            this.fileNameToolStripStatusLabel.Name = "fileNameToolStripStatusLabel";
            this.fileNameToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // fileContentsRichTextBox
            // 
            this.fileContentsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileContentsRichTextBox.Location = new System.Drawing.Point(0, 28);
            this.fileContentsRichTextBox.Name = "fileContentsRichTextBox";
            this.fileContentsRichTextBox.Size = new System.Drawing.Size(496, 351);
            this.fileContentsRichTextBox.TabIndex = 2;
            this.fileContentsRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 401);
            this.Controls.Add(this.fileContentsRichTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Exception File Reader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fileSizeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel fileNameToolStripStatusLabel;
        private System.Windows.Forms.RichTextBox fileContentsRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem exceptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem argumentExceptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathTooLongExceptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryNotFoundExceptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOExceptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unauthorizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNotFoundExceptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notSupportedExceptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityExceptionToolStripMenuItem;
    }
}

