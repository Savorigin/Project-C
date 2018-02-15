using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_15_Delegate
{
    public class PrintLib
    {
        public static void PrintMinus(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " - ");
            }
            Console.WriteLine();
        }
        public void PrintPlus(int[] mas)
        {
            Console.WriteLine("\n+++++++++++++++++++++++");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " + ");
            }
            Console.WriteLine("\n+++++++++++++++++++++++");
        }
        public static void PrintBase(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i] + ",");
            }
        }
    }
}
