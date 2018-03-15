using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_06_Beverage
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House blend coffee";
        }

        public override double Cost
        {
            get
            {
                return .89;
            }
        }
    }
}
