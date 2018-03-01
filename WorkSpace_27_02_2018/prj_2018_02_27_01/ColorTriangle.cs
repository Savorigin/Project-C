using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_27_01
{
    class ColorTriangle : Triangle
    {
        public string Color { set; get; }
        public ColorTriangle(Point apexA, Point apexB, Point apexC, string color) : base(apexA, apexB, apexC)
        {
            Color = color;
        }
    }
}
