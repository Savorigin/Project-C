using System;
using System.Collections.Generic;
using System.Text;

namespace RailWay
{
    public class Vagon
    {
        public int Type { get; set; }
        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
