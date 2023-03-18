using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void txtAbout_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //open the links included in the text
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
