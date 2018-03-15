using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_06_Beverage
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark roast";
        }

        public override double Cost
        {
            get
            {
                return .99;
            }
        }
    }
}
