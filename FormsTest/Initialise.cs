using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    internal class Initialise
    {
        
    }
}
