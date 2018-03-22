using System;
using System.Collections.Generic;

namespace prj_2018_03_20_BusStation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedBusList park = new LinkedBusList();
            park.AddAfterTail(new Bus { Name = "Vasya", Number = 111, NRoute = 2 });
            park.AddAfterTail(new Bus { Name = "Basya", Number = 222, NRoute = 2 });
            park.AddAfterTail(new Bus { Name = "Tasya", Number = 333, NRoute = 3 });
            park.AddAfterTail(new Bus { Name = "Dasya", Number = 444, NRoute = 3 });
            park.AddFirst(new Bus { Name = "Masya", Number = 555, NRoute = 3 });
            park.Insert(333, new Bus { Name = "Gadya", Number = 344, NRoute = 3 });

            LinkedBusList route = new LinkedBusList();
            route.AddFirst(park.Delete(333));
            route.AddAfterTail(ref park);
            park.Print();
            Console.WriteLine("-------------------------------------");
            route.Print();
            park.AddAfterTail(ref route);
            park.Print();
            Console.WriteLine("-------------------------------------");
            route.Print();

            LinkedList<Bus> list = new LinkedList<Bus>();
            //list.AddFirst();
        }
    }
}
