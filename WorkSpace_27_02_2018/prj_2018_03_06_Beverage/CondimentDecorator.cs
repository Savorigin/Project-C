using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_06_Beverage
{
    public abstract class CondimentalDecorator : Beverage
    {
        public CondimentalDecorator()
        {
            Description = "";
        }
    }
}
