using System.Drawing.Printing;
namespace Simple_Image_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void lnkOpenImageFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dlgOpenFile.FileName = "";
            dlgOpenFile.Filter = "Image files (*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png | *.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)";

            dlgOpenFile.ShowDialog();
            if (!string.IsNullOrEmpty(dlgOpenFile.FileName))
            {
                picBox.Image = Image.FromFile(@dlgOpenFile.FileName);
            }
        }

        private void lnkAutoSize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picBox.SizeMode=PictureBoxSizeMode.Zoom;
            picBox.Refresh();
        }

        private void lnkZoomIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picBox.SizeMode = PictureBoxSizeMode.AutoSize;

            Image img = picBox.Image;
            Size size = new Size(img.Width + 100, img.Height + 100);

            Bitmap bm = new Bitmap(img,size);
            Graphics g = Graphics.FromImage(bm);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

            picBox.Image = bm;
        }

        private void lnkZoomOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picBox.SizeMode = PictureBoxSizeMode.AutoSize;

            Image img = picBox.Image;
            Size size = new Size(img.Width - 100, img.Height - 100);

            //check if new size width or height are below 0
            if (size.Width < 0 || size.Height < 0)
                return;

            Bitmap bm = new Bitmap(img, size);
            Graphics g = Graphics.FromImage(bm);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

            picBox.Image = bm;
        }

        private void lnkPrint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrintDialog dg = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            dg.Document = doc;

            if(dg.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(picBox.Width, picBox.Height);
            picBox.DrawToBitmap(bm, new Rectangle(0,0,picBox.Width,picBox.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}