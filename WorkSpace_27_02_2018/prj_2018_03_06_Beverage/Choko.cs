using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_06_Beverage
{
    public class Choko : CondimentalDecorator
    {
        Beverage beverage;

        public Choko(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get
            {
                return beverage.Description + ", Choko";
            }
        }

        public override double Cost
        {
            get
            {
                return beverage.Cost + 0.75;
            }
        }
    }
}
