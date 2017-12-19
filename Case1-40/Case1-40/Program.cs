using System;

namespace Case1_40
{
    class Program
    {
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("15. Enter cards");
            Console.WriteLine("19. Enter year");
            Console.WriteLine("20. Enter date");
            while (true)
            {
                try
                {
                    int m = int.Parse(Console.ReadLine());
                    switch (m)
                    {
                        case 0: return m;
                        case 15: Case15.Task(); return m;
                        case 19: Case19.Task(); return m;
                        case 20: Case20.Task(); return m;
                        default: break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                if (Menu() == 0) return;
            }
        }
    }
}
