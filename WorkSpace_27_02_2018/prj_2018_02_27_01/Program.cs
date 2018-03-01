using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_27_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point();
            Point p3 = new Point { X = 0, Y = 1 };
            ColorPoint cp1 = new ColorPoint(2, 2, "Red");
            ColorPoint cp2 = new ColorPoint(p1, "Green");
            ColorPointAggregate cpa1 = new ColorPointAggregate("Blue", p1);
            Line l1 = new Line(p1, p2);
            Line l2 = new Line(3, 3, 4, 4);
            Line l3 = new Line(new Point(1, 1), new Point(2, 2));
            Line l4 = new Line(l2.Beg, l2.End);
            Line l5 = new Line { Beg = new Point(6, 6), End = p2 };
            ColorLine cl1 = new ColorLine(p2, p3, "Black");
            Triangle tr1 = new Triangle(p1, p2, p3);

            object[] masObj = new object[3];
            masObj[0] = p1;
            masObj[1] = l1;
            masObj[2] = tr1;
            foreach (var item in masObj)
            {
                Console.WriteLine(item);
            }
        }
    }
}
