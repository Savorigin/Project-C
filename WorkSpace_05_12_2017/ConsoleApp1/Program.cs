using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_2018_02_15_Delegate_External;

namespace prj_2018_02_15_Delegate
{
    delegate void PrintDelegate(int[] mas);
    class Program
    {
        static void Main(string[] args)
        {
            //PrintDelegate Print = ExternalPrint.PrintMinus;
            //Print += ExternalPrint.PrintBase;
            //Print += new PrintLib().PrintPlus;
            Func<int[], int> Print
            //Action<int[]> Print
            //PrintDelegate Print
            = (int[] arr) =>
            //= delegate (int[] arr) =>
            {
                Console.WriteLine("\n********************************");
                foreach (var item in arr)
                {
                    Console.Write(item + ":");
                }
                Console.WriteLine("\n********************************");
                return arr.Length;
            };
            int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("length = " + Print(mas));
            int[] mas1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print(mas1);
            //Print -= ExternalPrint.PrintBase;
            int[] mas2 = { -1, -2, -3, -4, -5, -6, -7, -8 };
            Print(mas2);
        }
    }
}
