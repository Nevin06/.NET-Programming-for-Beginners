namespace WindowsFormsApp1
{
    partial class frmMain
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWraponToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseFontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseFontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetFontSizeToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.bgWorkerOpenFile = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerSaveFile = new System.ComponentModel.BackgroundWorker();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.saveAsToolStripMenuItem.Text = "&SaveAs";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWraponToolStripMenuItem,
            this.increaseFontSizeToolStripMenuItem,
            this.decreaseFontSizeToolStripMenuItem,
            this.resetFontSizeToToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // wordWraponToolStripMenuItem
            // 
            this.wordWraponToolStripMenuItem.Name = "wordWraponToolStripMenuItem";
            this.wordWraponToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.wordWraponToolStripMenuItem.Text = "&Word Wrap(off)";
            this.wordWraponToolStripMenuItem.Click += new System.EventHandler(this.wordWraponToolStripMenuItem_Click);
            // 
            // increaseFontSizeToolStripMenuItem
            // 
            this.increaseFontSizeToolStripMenuItem.Name = "increaseFontSizeToolStripMenuItem";
            this.increaseFontSizeToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.increaseFontSizeToolStripMenuItem.Text = "&Increase Font Size";
            this.increaseFontSizeToolStripMenuItem.Click += new System.EventHandler(this.increaseFontSizeToolStripMenuItem_Click);
            // 
            // decreaseFontSizeToolStripMenuItem
            // 
            this.decreaseFontSizeToolStripMenuItem.Name = "decreaseFontSizeToolStripMenuItem";
            this.decreaseFontSizeToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.decreaseFontSizeToolStripMenuItem.Text = "Decrease Font Size";
            this.decreaseFontSizeToolStripMenuItem.Click += new System.EventHandler(this.decreaseFontSizeToolStripMenuItem_Click);
            // 
            // resetFontSizeToToolStripMenuItem
            // 
            this.resetFontSizeToToolStripMenuItem.Name = "resetFontSizeToToolStripMenuItem";
            this.resetFontSizeToToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.resetFontSizeToToolStripMenuItem.Text = "Reset Font Size to Default";
            this.resetFontSizeToToolStripMenuItem.Click += new System.EventHandler(this.resetFontSizeToToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.onlineHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(0, 36);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(800, 379);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown);
            this.txtContent.MouseLeave += new System.EventHandler(this.txtContent_MouseLeave);
            this.txtContent.MouseHover += new System.EventHandler(this.txtContent_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(322, 25);
            this.lblStatus.Text = "Welcome to the Text Editor Demo App!";
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "Text Files(*.txt) | *.txt";
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.Filter = "Text Files(*.txt) | *.txt";
            // 
            // bgWorkerOpenFile
            // 
            this.bgWorkerOpenFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerOpenFile_DoWork);
            this.bgWorkerOpenFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerOpenFile_RunWorkerCompleted);
            // 
            // bgWorkerSaveFile
            // 
            this.bgWorkerSaveFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerSaveFile_DoWork);
            this.bgWorkerSaveFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerSaveFile_RunWorkerCompleted);
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.onlineHelpToolStripMenuItem.Text = "&Online Help";
            this.onlineHelpToolStripMenuItem.Click += new System.EventHandler(this.onlineHelpToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Text Editor Demo App - New Text Document";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWraponToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseFontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseFontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetFontSizeToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.ComponentModel.BackgroundWorker bgWorkerOpenFile;
        private System.ComponentModel.BackgroundWorker bgWorkerSaveFile;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
    }
}

