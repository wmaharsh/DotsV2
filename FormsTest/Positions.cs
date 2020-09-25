using System;
using System.Collections.Generic;
using System.Drawing;
using Dotto.Init;

namespace Dotto.Positions
{

    internal class Positions
    {
        public List<Point> dotPositons;
        public Positions()
        {
            this.dotPositons = new List<Point> { };
        }
        public Positions(List<Point> pointList)
            : this()
        {
            foreach(var pointelem in pointList)
            {
                dotPositons.Add(pointelem);
            }
        }

        public void LogPoints(Positions posObj)
        {
            Console.WriteLine("Points:");
            foreach(var elem in posObj.dotPositons)
            {
                Console.WriteLine("({0},{1})", elem.X, elem.Y);
            }
        }

        public void DottoPositionRender(BitmapDetails detailsBmp, Graphics graphicsObj, int jitterX, int jitterY, Random fgrandom, bool isSymmetrical = false)
        {
            //Clearing all points beforehand to avoid extra point artefacts.
            this.dotPositons.Clear();

            this.DottoPos(detailsBmp);

            this.DottoJitter(jitterX, jitterY);

            ColorData bgdata = Initialise.RandoColor(fgrandom);

            SolidBrush fgbrush = new SolidBrush(Color.FromArgb(255, bgdata.rud, bgdata.grn, bgdata.blu));

            foreach(Point elem in dotPositons)
            {
                graphicsObj.FillEllipse(brush: fgbrush, elem.X, elem.Y, 15, 15);
            }
        }

        //Position function to assign base positions
        public void DottoPos(BitmapDetails detailsBmp)
        {
            //Assigning standard dot positions

            for (int xctr = 0; xctr < detailsBmp.ColNumber; xctr++)
            {
                for (int yctr = 0; yctr < detailsBmp.RowNumber; yctr++)
                {
                    var positionX = (xctr + 1) * Convert.ToInt32(detailsBmp.Width / (detailsBmp.ColNumber + 1));
                    var positionY = (yctr + 1) * Convert.ToInt32(detailsBmp.Height / (detailsBmp.RowNumber + 1));

                    this.dotPositons.Add(new Point(positionX, positionY));
                }
            }
        }

        //Jitter function to existing dotpositions
        public void DottoJitter(int jitterX, int jitterY)
        {
            var rand = new Random();

            for(int ctr = 0; ctr < this.dotPositons.Count; ctr++)
            {
                // for X position
                var bufferpoint = dotPositons[ctr];
                if (rand.Next(2)==0)
                {
                    if (jitterX > 0)
                    {
                        bufferpoint.X += rand.Next(jitterX * 2);
                    }
                }
                else
                {
                    if (jitterX > 0)
                    {
                        bufferpoint.X -= rand.Next(jitterX * 2);
                    }
                }

                // for Y position
                if (rand.Next(2) == 0)
                {
                    if (jitterY > 0)
                    {
                        bufferpoint.Y += rand.Next(jitterY * 2);
                    }
                }
                else
                {
                    if (jitterY > 0)
                    {
                        bufferpoint.Y -= rand.Next(jitterY * 2);
                    }
                }
                dotPositons[ctr] = bufferpoint;
            }
        }

        public void RenderDotto(Graphics graphicsObj)
        {
            foreach(Point elem in dotPositons)
            {
                graphicsObj.FillEllipse(Brushes.BlueViolet, (elem.X), (elem.Y), 10, 10);
            }
        }
    }
}
