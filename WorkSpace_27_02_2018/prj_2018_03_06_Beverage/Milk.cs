using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_06_Beverage
{
    public class Milk : CondimentalDecorator
    {
        Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get
            {
                return beverage.Description + ", Milk";
            }
        }

        public override double Cost
        {
            get
            {
                return beverage.Cost + 0.5;
            }
        }
    }
}
