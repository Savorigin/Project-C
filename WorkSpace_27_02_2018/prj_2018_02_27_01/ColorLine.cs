using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_27_01
{
    class ColorLine : Line
    {
        public string Color { set; get; }
        public ColorLine(Point beg, Point end, string color) : base(beg, end)
        {
            Color = color;
        }
    }
}
