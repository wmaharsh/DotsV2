using Dotto.Init;
using Dotto.Positions;
using System;
using System.Collections.Generic;
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

        Bitmap myBmp;

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

        #region//Textbox text limiting
        
        private void txtNumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers
            if(!char.IsNumber(e.KeyChar) && e.KeyChar.ToString() != "\b")
            {
                e.Handled = true;
            }
        }
        #endregion

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

        public static List<Point> GeneratePoints(int xmax, int ymax, int noPoints)
        {
            var pts = new List<Point>() { };

            var random = new Random();

            for (int xctr = 0; xctr < noPoints; xctr++)
            {
                int positionx = random.Next(0, xmax);
                int positiony = random.Next(0, ymax);
                var p = new Point(positionx, positiony);
                pts.Add(p);
            }

            return pts;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            BitmapDetails bmpdims;

            #region // Width, height, column and row values to the bitmap

            //Checking if TextBoxes are empty
            if(string.IsNullOrEmpty(txtColNo.Text) || string.IsNullOrEmpty(txtRowNo.Text))
            {
                MessageBox.Show("Please enter the number of rows or columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtHeight.Text) || string.IsNullOrEmpty(txtWidth.Text))
                {
                    bmpdims.Width = DEFAULT_WIDTH;
                    bmpdims.Height = DEFAULT_HEIGHT;
                }
                else
                {
                    int bufferWidth = Convert.ToInt32(txtWidth.Text);
                    int bufferHeight = Convert.ToInt32(txtHeight.Text);

                    //width values
                    if (bufferWidth < MIN_WIDTH)
                    {
                        bmpdims.Width = MIN_WIDTH;
                    }
                    else if (bufferWidth > MAX_WIDTH)
                    {
                        bmpdims.Width = MAX_WIDTH;
                    }
                    else
                    {
                        bmpdims.Width = bufferWidth;
                    }

                    //height values
                    if (bufferHeight < MIN_HEIGHT)
                    {
                        bmpdims.Height = MIN_HEIGHT;
                    }
                    else if (bufferHeight > MAX_HEIGHT)
                    {
                        bmpdims.Height = MAX_HEIGHT;
                    }
                    else
                    {
                        bmpdims.Height = bufferHeight;
                    }
                }

                bmpdims.ColNumber = Convert.ToInt32(txtColNo.Text);
                bmpdims.RowNumber = Convert.ToInt32(txtRowNo.Text);
            }

            #endregion

            myBmp = new Bitmap(bmpdims.Width, bmpdims.Height, PixelFormat.Format32bppArgb);

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
            //List<Point> dots = GeneratePoints(bmpWidth, bmpHeight, 10);

            //draws the graphics on the bitmap
            using (Graphics g = Graphics.FromImage(myBmp))
            {
                //ClearBitmap(myBmp);

                g.Clear(Color.FromArgb(255, 255, 255, 255));

                Positions.Positions pos = new Positions.Positions();
                pos.DottoPositionRender(bmpdims, g, trackBarHJitter.Value, trackBarVjitter.Value);
                //g.DrawEllipse(red, 20, 20, 860, 1160);
                //Positions.Positions pos = new Positions.Positions(dots);
                //pos.RenderDotto(g);
            }

            //display
            picBox.Image = myBmp;
        }
    }
}
