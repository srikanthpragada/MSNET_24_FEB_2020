using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class TestPoint
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;

            Point p2 = new Point { X = 1, Y = 10 };

        }
    }
}
