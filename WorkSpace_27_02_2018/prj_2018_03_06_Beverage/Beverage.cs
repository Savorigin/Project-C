using System;
using System.Collections.Generic;
using System.Text;

namespace prj_2018_03_06_Beverage
{
    public abstract class Beverage
    {
        public virtual string Description { get; set; }
        public abstract double Cost { get; }
        public Beverage()
        {
            Description = "Unknown";
        }
    }
}
