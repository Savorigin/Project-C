using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer1_10
{
    class Program
    {
        static void Integer1()
        {
            int L = 156;
            int ost = L % 100;
            double countM = ((L - ost) / 100);
            Console.WriteLine("Количество метров = " + countM.ToString());
        }
        static void Integer2()
        {
            int kg = 1556546;
            double t = Math.Floor((double)kg / 1000);
            Console.WriteLine("Количество тонн = " + t.ToString());
        }
        static void Integer3()
        {

        }
        static void Integer4()
        {

        }
        static void Integer5()
        {

        }
        static void Integer6()
        {

        }
        static void Integer7()
        {

        }
        static void Integer8()
        {

        }
        static void Integer9()
        {

        }
        static void Integer10()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            string nameTask = Console.ReadLine();
            switch (nameTask)
            {
                case "1": Integer1(); break;
                case "2": Integer2(); break;
                case "3": Integer3(); break;
                case "4": Integer4(); break;
                case "5": Integer5(); break;
                case "6": Integer6(); break;
                case "7": Integer7(); break;
                case "8": Integer8(); break;
                case "9": Integer9(); break;
                case "10": Integer10(); break;
                default: Integer1(); break;
            }
        }
    }
}
