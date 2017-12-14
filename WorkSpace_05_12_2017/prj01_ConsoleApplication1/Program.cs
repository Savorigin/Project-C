using System;

namespace prj01_ConsoleApplication1
{
    class Program
    {
        static int Task1()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) return i;
                Console.WriteLine(i);
            }
            return -1;
        }
        /// <summary>
        /// Дано число месяца (тип int). Необходимо определить время года 
        /// (зима, весна, лето, осень) и вывести на консоль.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static void TaskSwitchMonth(int n)
        {
            switch (n)
            {
                case 12:
                case 1:
                case 2: Console.WriteLine("Winter"); break;
                case 3:
                case 4:
                case 5: Console.WriteLine("Spring"); break;
                case 6:
                case 7:
                case 8: Console.WriteLine("Summer"); break;
                case 9:
                case 10:
                case 11: Console.WriteLine("Autumn"); break;
                default: Console.WriteLine("Not season"); break;
            }
        }
        static int ValidateMonthFromConsole()
        {
            while (true)
            {
                Console.WriteLine("Enter month");
                try
                {
                    int month = int.Parse(Console.ReadLine());
                    if (month < 0) throw new FormatException("Negative");
                    return month;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Bad bad bad not int");
                    Console.WriteLine(ex.Message);
                    //Console.WriteLine(ex);
                }
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("find = " + Task1());
            //Console.WriteLine("FINISH");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("0. For exit");
                Console.WriteLine("1. Season by month");
                Console.WriteLine("2. Task1");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 0: return;
                    case 1:
                        {
                            TaskSwitchMonth(ValidateMonthFromConsole());
                            break;
                        }
                    case 2: Task1(); break;
                    default: break;
                }
                Console.ReadLine();
            }
        }
    }
}
