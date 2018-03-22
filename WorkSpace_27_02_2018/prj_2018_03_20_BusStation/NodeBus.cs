using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_20_BusStation
{
    class NodeBusList
    {
        public NodeBusList(Bus info)
        {
            Info = info;
            Next = null;
        }
        public Bus Info { get; set; }
        public NodeBusList Next { get; set; }
    }
}
