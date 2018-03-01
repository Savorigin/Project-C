using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_27_01
{
    public class ColorPoint : Point, IFigureColor
    {
        private Point p1;
        private string v;

        public string Color { get; set; }

        public ColorPoint(int x, int y, string color) : base(x, y)
        {
            Color = color;
        }

        public ColorPoint(Point p, string color) : this(p.X, p.Y, color)
        {
            
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {Color}";
        }

        public override void Print()
        {
            Console.WriteLine("Color point : " + ToString());
        }

        public void PrintColorAble()
        {
            Console.WriteLine("Print color able : " + ToString());
        }
    }
}
