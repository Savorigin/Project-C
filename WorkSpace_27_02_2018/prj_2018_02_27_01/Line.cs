using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_27_01
{
    public class Line : AbstractFigure
    {
        public Point Beg { get; set; }
        public Point End { get; set; }

        public Line()
        {

        }

        public Line(Point beg, Point end)
        {
            Beg = beg;
            End = end;
        }

        public Line(int x1, int y1, int x2, int y2)
        {
            Beg = new Point(x1, y1);
            End = new Point(x2, y2);
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(Beg.X - End.X, 2) + Math.Pow(Beg.Y - End.Y, 2));
            }
        }

        public override string ToString()
        {
            return $"{Beg}, {End}";
        }

        public override void Print()
        {
            Console.WriteLine("Line : " + ToString());
        }
    }
}
