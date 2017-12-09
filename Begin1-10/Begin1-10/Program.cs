using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.;

namespace Begin1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);

            // Begin1
            /*int P = 4 * a;
            Console.WriteLine("Периметр квадрата = " + P.ToString());*/

            // Begin2
            double S = Math.Pow((double)a, 2);
            Console.WriteLine("Площадь квадрата = " + S.ToString());

            Console.ReadLine();
        }
    }
}
