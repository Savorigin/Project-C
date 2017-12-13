using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For1_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 18");
            Console.WriteLine(MyTasks.Func18(5.0, 6));
            Console.WriteLine("Task 21");
            Console.WriteLine(Math.E);
            Console.WriteLine(MyTasks.Func21(35));
            Console.WriteLine("Task 22");
            Console.WriteLine(Math.Exp(35));
            Console.WriteLine(MyTasks.Func22(35, 16));
            Console.WriteLine("Task 23");
            Console.WriteLine(Math.Sin(3.0));
            Console.WriteLine(MyTasks.Func23(3.0, 35));
            Console.WriteLine("Task 26");
            Console.WriteLine(Math.Atan(0.56));
            Console.WriteLine(MyTasks.Func26(0.56, 35));
        }
    }
}
