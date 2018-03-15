using System;

namespace prj_2018_03_06_Beverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage[] beverage = new Beverage[3];
            beverage[0] = new Milk(new Espresso());
            beverage[1] = new Milk(new Milk(new Espresso()));
            beverage[2] = new Choko(new Milk(new Espresso()));
            foreach (var item in beverage)
            {
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Cost);
            }
        }
    }
}
