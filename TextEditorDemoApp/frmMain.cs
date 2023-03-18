using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        //get the default port
        Font defaultFont;

        //set the splitting characters for counting the words
        private char[] splitCharacters = "\n ,.:;\"'?!".ToArray();

        //flag if editing is in progress
        bool isEditingInProgress = false;

        //variables
        string fileToOpen;
        string fileToSave;
        string retrievedText = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"Text submitted","Message to User",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "This is a sample .Net Windows Forms App", "Message to user", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplayText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtContent.Text);
        }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            //handle the word-wrap option (if off-switch on, and vice-versa)
            if (txtContent.WordWrap)
            {
                wordWraponToolStripMenuItem.Text = "Word Wrap(on)";
            }
            else
            {
                wordWraponToolStripMenuItem.Text = "Word Wrap(off)";
            }

            defaultFont = txtContent.Font;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if editing is in progress and handle accordingly
            if(isEditingInProgress)
            {
                DialogResult drDiscard = MessageBox.Show(this, "You are currently editing the text document." + Environment.NewLine + "Discard changes?", "Open Text Document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (drDiscard != DialogResult.Yes)
                {
                    return;
                }
            }

            //show open file dialog
            DialogResult dr = dlgOpenFile.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //get the path of the file to be opened
                //string fileToOpen = @dlgOpenFile.FileName;
                fileToOpen = @dlgOpenFile.FileName;

                //read the file and display content into rich text box
                try
                {
                    //txtContent.Text = File.ReadAllText(@fileToOpen);
                    //lblStatus.Text = "Opened file" + @fileToOpen;

                    //isEditingInProgress = true;

                    //this.Text= "Text Editor Demo App - " + @fileToOpen;


                    //open the file by calling a separate process/thread via the bgWorker object
                    if (!bgWorkerOpenFile.IsBusy)
                        bgWorkerOpenFile.RunWorkerAsync();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, "Error Message", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = dlgSaveFile.ShowDialog();

            if (dr == DialogResult.OK) 
            {
                //string fileToSave = @dlgSaveFile.FileName;
                fileToSave = @dlgSaveFile.FileName;
                try
                {
                    //File.WriteAllText(@fileToSave, txtContent.Text);
                    //lblStatus.Text = "File saved as: " + @fileToSave;

                    //isEditingInProgress = false;

                    //this.Text = "Text Editor Demo App - " + @fileToSave;

                    //if bgWorkerSaveFile component is not busy, start the thread
                    if (!bgWorkerSaveFile.IsBusy)
                        bgWorkerSaveFile.RunWorkerAsync();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, "Error Message", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if editing is in progress and handle accordingly
            if (isEditingInProgress)
            {
                DialogResult drDiscard = MessageBox.Show(this, "You are currently editing the text document." + Environment.NewLine + "Discard changes?", "Open New Text Document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (drDiscard == DialogResult.Yes)
                {
                    txtContent.Clear();
                    lblStatus.Text = "New Text Document";
                    this.Text = "Text Editor Demo App - New Text Document";
                }
            }
            else
            {
                txtContent.Clear();
                lblStatus.Text = "New Text Document";
                this.Text = "Text Editor Demo App - New Text Document";
            }

            isEditingInProgress = true;
        }

        private void wordWraponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //handle the word-wrap option (if off-switch on, and vice-versa)
            if (txtContent.WordWrap)
            {
                txtContent.WordWrap = false;
                wordWraponToolStripMenuItem.Text = "Word Wrap(off)";
            }
            else
            {
                txtContent.WordWrap = true;
                wordWraponToolStripMenuItem.Text = "Word Wrap(on)";
            }
        }

        private void increaseFontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set 18 as the max font size
            if(txtContent.Font.Size < 18)
            {
                //increase font size by 2
                txtContent.Font = new Font("Microsoft Sans Serif", txtContent.Font.Size + 2);
            }
            else
            {
                MessageBox.Show(this, "Max Font Size Reached (" + Convert.ToInt32(txtContent.Font.Size).ToString() + ").", "Increase Font Size", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void decreaseFontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set 8 as the min font size
            if (txtContent.Font.Size > 10)
            {
                //increase font size by 2
                txtContent.Font = new Font("Microsoft Sans Serif", txtContent.Font.Size - 2);
            }
            else
            {
                MessageBox.Show(this, "Min Font Size Reached (" + Convert.ToInt32(txtContent.Font.Size).ToString() + ").", "Decrease Font Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetFontSizeToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Font = defaultFont;

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(this, "Sample Text Editor Build in .Net WinForms Demo", "About the Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //show the "About" dialog
            new frmAbout().ShowDialog();
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            //lblStatus.Text = "Text Changed";
            updateStatusLines();

            isEditingInProgress= true;
        }

        private void txtContent_MouseHover(object sender, EventArgs e)
        {
            //lblStatus.Text = "Mouse Entered TextBox";
        }

        private void txtContent_MouseLeave(object sender, EventArgs e)
        {
            //lblStatus.Text = "Mouse Left TextBox";
        }

        private void updateStatusLines()
        {
            //update status bar
            lblStatus.Text = "Editing Line: " + (txtContent.GetLineFromCharIndex(txtContent.SelectionStart) + 1).ToString() + " - Total Lines: " + txtContent.Lines.Count().ToString() + " - Total Words: " + txtContent.Text.Split(splitCharacters, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
        }

        private void txtContent_KeyDown(object sender, KeyEventArgs e)
        {
            //handle the copy-paste event in order to paste text as plain text only
            if(e.Control && e.KeyCode == Keys.V)
            {
                txtContent.Text = (string)Clipboard.GetData("Text");
                e.Handled= true;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //check if editing is in progress and handle accordingly
            if (isEditingInProgress)
            {
                DialogResult drDiscard = MessageBox.Show(this, "You are currently editing the text document." + Environment.NewLine + "Discard changes?", "Close Text Document", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (drDiscard != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void bgWorkerOpenFile_DoWork(object sender, DoWorkEventArgs e)
        {
            //retrieve the file contents using a separate process/thread
            try
            {
                retrievedText = File.ReadAllText(@fileToOpen);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgWorkerOpenFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //after file contents are retrieved by a seperate process/thread
            //perform rest of the tasks
            txtContent.Text = retrievedText;
            lblStatus.Text = "Opened file: " + @fileToOpen;
            isEditingInProgress = true;
            this.Text = "Text Editor Demo App - " + @fileToOpen;
        }

        private void bgWorkerSaveFile_DoWork(object sender, DoWorkEventArgs e)
        {
            //retrieve the file contents using a separate process/thread
            try
            {
                if (txtContent.InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        File.WriteAllText(@fileToSave, txtContent.Text);
                    });
                }
                else
                {
                    File.WriteAllText(@fileToSave, txtContent.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgWorkerSaveFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //after the file is saved via the separate process/thread
            //perform the rest of the tasks
            lblStatus.Text = "File saved as: " + @fileToSave;
            isEditingInProgress = false;
            this.Text = "Text Editor Demo App - " + @fileToSave;
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Online Help is currently being created.");
        }
    }
}
