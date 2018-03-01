using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_27_01
{
    public class Point : AbstractFigure
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() : this(0, 0)
        {
        }

        public Point(int x, int y) : base()
        {
            X = x;
            Y = y;
        }

        public Point(Point p) : this(p.X, p.Y)
        {

        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }

        public override void Print()
        {
            Console.WriteLine("Point : " + ToString());
        }
    }
}
