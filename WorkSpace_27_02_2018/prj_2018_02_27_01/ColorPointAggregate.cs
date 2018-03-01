using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_27_01
{
    class ColorPointAggregate
    {
        public string Color { get; set; }
        public Point Point_ref { get; set; }

        public ColorPointAggregate(string color, Point point_ref)
        {
            Color = color;
            Point_ref = point_ref;
        }
        public override string ToString()
        {
            return $"{Point_ref}, {Color}";
        }
    }
}
