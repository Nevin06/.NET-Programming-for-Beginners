namespace Simple_Image_Viewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lnkOpenImageFile = new System.Windows.Forms.LinkLabel();
            this.lnkAutoSize = new System.Windows.Forms.LinkLabel();
            this.lnkZoomIn = new System.Windows.Forms.LinkLabel();
            this.lnkZoomOut = new System.Windows.Forms.LinkLabel();
            this.lnkPrint = new System.Windows.Forms.LinkLabel();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.picBox);
            this.panelMain.Location = new System.Drawing.Point(16, 22);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1340, 363);
            this.panelMain.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1338, 361);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lnkOpenImageFile
            // 
            this.lnkOpenImageFile.AutoSize = true;
            this.lnkOpenImageFile.Location = new System.Drawing.Point(16, 411);
            this.lnkOpenImageFile.Name = "lnkOpenImageFile";
            this.lnkOpenImageFile.Size = new System.Drawing.Size(142, 25);
            this.lnkOpenImageFile.TabIndex = 1;
            this.lnkOpenImageFile.TabStop = true;
            this.lnkOpenImageFile.Text = "Open Image File";
            this.lnkOpenImageFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpenImageFile_LinkClicked);
            // 
            // lnkAutoSize
            // 
            this.lnkAutoSize.AutoSize = true;
            this.lnkAutoSize.Location = new System.Drawing.Point(181, 411);
            this.lnkAutoSize.Name = "lnkAutoSize";
            this.lnkAutoSize.Size = new System.Drawing.Size(144, 25);
            this.lnkAutoSize.TabIndex = 2;
            this.lnkAutoSize.TabStop = true;
            this.lnkAutoSize.Text = "Auto-Size Image";
            this.lnkAutoSize.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAutoSize_LinkClicked);
            // 
            // lnkZoomIn
            // 
            this.lnkZoomIn.AutoSize = true;
            this.lnkZoomIn.Location = new System.Drawing.Point(350, 411);
            this.lnkZoomIn.Name = "lnkZoomIn";
            this.lnkZoomIn.Size = new System.Drawing.Size(104, 25);
            this.lnkZoomIn.TabIndex = 3;
            this.lnkZoomIn.TabStop = true;
            this.lnkZoomIn.Text = "Zoom-In(+)";
            this.lnkZoomIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkZoomIn_LinkClicked);
            // 
            // lnkZoomOut
            // 
            this.lnkZoomOut.AutoSize = true;
            this.lnkZoomOut.Location = new System.Drawing.Point(487, 411);
            this.lnkZoomOut.Name = "lnkZoomOut";
            this.lnkZoomOut.Size = new System.Drawing.Size(114, 25);
            this.lnkZoomOut.TabIndex = 4;
            this.lnkZoomOut.TabStop = true;
            this.lnkZoomOut.Text = "Zoom-Out(-)";
            this.lnkZoomOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkZoomOut_LinkClicked);
            // 
            // lnkPrint
            // 
            this.lnkPrint.AutoSize = true;
            this.lnkPrint.Location = new System.Drawing.Point(1266, 411);
            this.lnkPrint.Name = "lnkPrint";
            this.lnkPrint.Size = new System.Drawing.Size(48, 25);
            this.lnkPrint.TabIndex = 5;
            this.lnkPrint.TabStop = true;
            this.lnkPrint.Text = "Print";
            this.lnkPrint.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrint_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 450);
            this.Controls.Add(this.lnkPrint);
            this.Controls.Add(this.lnkZoomOut);
            this.Controls.Add(this.lnkZoomIn);
            this.Controls.Add(this.lnkAutoSize);
            this.Controls.Add(this.lnkOpenImageFile);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Image Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMain;
        private PictureBox picBox;
        private LinkLabel lnkOpenImageFile;
        private LinkLabel lnkAutoSize;
        private LinkLabel lnkZoomIn;
        private LinkLabel lnkZoomOut;
        private LinkLabel lnkPrint;
        private OpenFileDialog dlgOpenFile;
    }
}