using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_06_Beverage
{
    public class Mocha : CondimentalDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get
            {
                return beverage.Description + ", Mocha";
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
