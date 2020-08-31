using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Dotto.Position;

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

        Bitmap myBmp;

        private void ClearBitmap(Bitmap bmp)
        {
            for (int Xcount = 0; Xcount < bmp.Width; Xcount++)
            {
                for (int Ycount = 0; Ycount < bmp.Height; Ycount++)
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


        public static void GeneratePoints(List<Point> pts)
        {
            //foreach(var member in pts)
            //{
            //    pts.Remove(member);
            //}
            var random = new Random();

            for (int xctr = 0; xctr < 10; xctr++)
            {
                int positionx = random.Next(1, 899);
                int positiony = random.Next(1, 1199);
                var p = new Point(positionx, positiony);
                pts.Add(p);
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            int bmpHeight, bmpWidth;

            #region //empty textbox exceptions
            if (string.IsNullOrEmpty(txtHeight.Text) || string.IsNullOrEmpty(txtWidth.Text))
            {
                //Message box
                MessageBox.Show("Enter dimensions for image please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            #region //Assigning dimensions to the required bitmap

            int bufferWidth = Convert.ToInt32(txtWidth.Text);
            int bufferHeight = Convert.ToInt32(txtHeight.Text);

            if (bufferWidth < MIN_WIDTH || bufferWidth > MAX_WIDTH)
            {
                bmpWidth = DEFAULT_WIDTH;
            }
            else
            {
                bmpWidth = bufferWidth;
            }

            if (bufferHeight < MIN_HEIGHT || bufferHeight > MAX_HEIGHT)
            {
                bmpHeight = DEFAULT_HEIGHT;
            }
            else
            {
                bmpHeight = bufferHeight;
            }
            #endregion

            myBmp = new Bitmap(bmpWidth, bmpHeight, PixelFormat.Format32bppArgb);

            #region//Disposes previously generated picturebox
            if (pnlPicture.HasChildren)
            {
                foreach (PictureBox pb in pnlPicture.Controls)
                {
                    pb.Dispose();
                }
            }
            #endregion

            #region //creates picturebox at runtime
            PictureBox picBox = new PictureBox
            {
                Name = "picBox",
                Size = pnlPicture.Size,
                Location = pnlPicture.Location,
                Parent = pnlPicture,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            pnlPicture.Controls.Add(picBox);
            #endregion

            //Makes the bitmap empty with white background
            ClearBitmap(myBmp);

            // a list of 10 points generated randomly within the confines of the bitmap
            List<Point> dots = new List<Point> { };
            GeneratePoints(dots);

            //draws the graphics on the bitmap
            using (Graphics g = Graphics.FromImage(myBmp))
            {
                //ClearBitmap(myBmp);
                g.Clear(Color.FromArgb(255, 255, 255, 255));
                Pen red = new Pen(Color.FromArgb(255, 255, 0, 0), 5);
                //g.DrawEllipse(red, 20, 20, 860, 1160);
                var pos = new Positions(dots);
                pos.RenderDotto(g);
            }

            //display
            picBox.Image = myBmp;
        }
    }
}
