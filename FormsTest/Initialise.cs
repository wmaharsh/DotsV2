using System;
using System.Drawing;

namespace Dotto.Init
{
    internal struct BitmapDetails
    {
        public int Width;
        public int Height;
        public int ColNumber;
        public int RowNumber;

        public BitmapDetails(int w, int h, int c, int r)
        {
            Width = w;
            Height = h;
            ColNumber = c;
            RowNumber = r;
        }
    }

    internal struct ColorData
    {
        public int rud;
        public int grn;
        public int blu;
        public int alf;

        public ColorData(int red, int blue, int green, int alpha)
        {
            rud = red;
            grn = green;
            blu = blue;
            alf = alpha;
        }
    }

    internal class Initialise
    {
        public static void fillBackground(BitmapDetails bmpDetails, Graphics g, ColorData clrData)
        {
            SolidBrush clrbrush;
            clrbrush = new SolidBrush(Color.FromArgb(255, clrData.rud, clrData.grn, clrData.blu));

            g.FillRectangle(clrbrush, 0, 0, bmpDetails.Width, bmpDetails.Height);
        }

        public static ColorData RandoColor(Random random)
        {
            int a = random.Next(180, 256);
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            var temp = new ColorData(a, r, g, b);
            return temp;
        }
    }
}
