using System;
using System.Collections.Generic;
using System.Drawing;

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

        //public static void setDotto(Positions posObj,int Width, int Height, int rows, int cols, bool isSymmetrical, int jitterX, int jitterY)
        //{

        //}

        public void RenderDotto(Graphics graphicsObj)
        {
            foreach(var elem in this.dotPositons)
            {
                graphicsObj.FillEllipse(Brushes.BlueViolet, (elem.X), (elem.Y), 20, 20);
            }
        }
    }
}
