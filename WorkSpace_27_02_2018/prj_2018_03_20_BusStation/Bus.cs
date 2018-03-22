using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_20_BusStation
{
    class Bus
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int NRoute { get; set; }
        public override string ToString()
        {
            return $"{Name}, {NRoute}, {Number}";
        }
    }
}
