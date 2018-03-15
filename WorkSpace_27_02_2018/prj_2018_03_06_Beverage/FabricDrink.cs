using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_06_Beverage
{
    class FabricDrink
    {
        public Beverage GetDrink(int n)
        {
            switch (n)
            {
                case 0: return new Milk(new Espresso());
                case 1: return new Milk(new Milk(new Espresso()));
                case 2: return new Choko(new Milk(new Espresso()));
                default: return null;
            }
        }
    }
}
