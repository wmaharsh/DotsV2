using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Dotto
{
    public partial class GDITestForm : Form
    {
        #region //constant values
        const int DEFAULT_WIDTH = 900;
        const int DEFAULT_HEIGHT = 1200;
        const int MIN_WIDTH = 300;
        const int MIN_HEIGHT = 300;
        const int MAX_WIDTH = 3000;
        const int MAX_HEIGHT = 3000;
        #endregion

        Bitmap myBmp = new Bitmap(DEFAULT_WIDTH, DEFAULT_HEIGHT, PixelFormat.Format32bppArgb);

        private void ClearBitmap(Bitmap bmp)
        {
            for(int Xcount = 0; Xcount < bmp.Width; Xcount++)
            {
                for(int Ycount = 0; Ycount < bmp.Height; Ycount++)
                {
                    bmp.SetPixel(Xcount, Ycount, Color.FromArgb(255, 255, 255, 255));
                }
            }
        }

        public GDITestForm()
        {
            InitializeComponent();
        }

        private void GDITestForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true; //prevents flickering

            this.Paint += new PaintEventHandler(GDITestForm_Paint);
        }

        private void GDITestForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.GhostWhite, new Rectangle(0, 0, Size.Width, Size.Height));
            //e.Graphics.DrawImage(Resources.Ame, 20, 20);
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        //public int AssignHeight()
        //{
        //    int pic_height = Convert.ToInt32(txtHeight.Text);
        //    if (pic_height < MIN_HEIGHT || pic_height > MAX_HEIGHT)
        //    {

        //    }
        //}

        #region//Textbox text limiting
        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!char.IsNumber(e.KeyChar) && e.KeyChar.ToString() != "\b")
            {
                e.Handled = true;
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers
            if (!char.IsNumber(e.KeyChar) && e.KeyChar.ToString() != "\b")
            {
                e.Handled = true;
            }
        }
        #endregion

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            ClearBitmap(myBmp);

            //draw
            using (Graphics g = Graphics.FromImage(myBmp))
            {
                Pen red = new Pen(Color.FromArgb(255, 255, 0, 0), 5);
                g.DrawEllipse(red, 20, 20, 860, 1160);
            }

            //display
            pictureBox.Image = myBmp;

        }
    }
}
