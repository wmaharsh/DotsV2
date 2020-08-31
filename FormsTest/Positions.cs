﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotto.Position
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
            foreach(var elem in posObj.dotPositons)
            {
                Console.WriteLine("({0},{1})", elem.X, elem.Y);
            }
        }

        //public static void setDotto(Positions posObj,int Width, int Height, int rows, int cols, bool isSymmetrical, int jitterX, int jitterY)
        //{

        //}

        public static void RenderDotto(Positions posObj, Graphics graphicsObj)
        {
            foreach(var elem in posObj.dotPositons)
            {
                graphicsObj.DrawEllipse(Pens.Black, (elem.X - 1), (elem.Y - 1), 2, 2);
            }
        }
    }
}
