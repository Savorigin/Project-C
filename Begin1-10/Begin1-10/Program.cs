using System;

namespace Begin1_10
{
    class Program
    {
        static double Square()
        {
            Console.WriteLine("Введите сторону квадрата");
            string S1 = Console.ReadLine();
            return double.Parse(S1);
        }
        static void Begin1()
        {
            // Дана сторона квадрата a. Найти его периметр P = 4·a.
            double a = Square();
            double P = 4 * a;
            Console.WriteLine("Периметр квадрата = " + P.ToString());
        }
        static void Begin2()
        {
            // Дана сторона квадрата a. Найти его площадь S = a2.
            double a = Square();
            double S = Math.Pow(a, 2);
            Console.WriteLine("Площадь квадрата = " + S.ToString());
        }
        static void Begin3()
        {
            // Даны стороны прямоугольника a и b. Найти его площадь S = a·b и
            // периметр P = 2·(a + b).
            Console.WriteLine("Введите 1 сторону прямоугольника");
            string S1 = Console.ReadLine();
            Console.WriteLine("Введите 2 сторону прямоугольника");
            string S2 = Console.ReadLine();
            double a = double.Parse(S1);
            double b = double.Parse(S2);
            double S = a * b;
            Console.WriteLine("Площадь прямоугольника = " + S.ToString());
            double P = 2 * (a + b);
            Console.WriteLine("Периметр прямоугольника = " + P.ToString());
        }
        static void Begin4()
        {
            // Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14.
            double d = 15;
            const double pi = 3.14;
            double L = pi * d;
            Console.WriteLine("Длина окружности = " + L.ToString());
        }
        static void Begin5()
        {
            // Дана длина ребра куба a. Найти объем куба V = a3 и площадь его поверхности S = 6·a2.
            double a = 23;
            double V = Math.Pow(a, 3);
            Console.WriteLine("Объем куба = " + V.ToString());
            double S = 6 * Math.Pow(a, 2);
            Console.WriteLine("Поверхность куба = " + S.ToString());
        }
        static void Begin6()
        {

        }
        static void Begin7()
        {

        }
        static void Begin8()
        {

        }
        static void Begin9()
        {

        }
        static void Begin10()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите задание:");
            string nameTask = Console.ReadLine();

            switch (nameTask)
            {
                case "1": Begin1(); break;
                case "2": Begin2(); break;
                case "3": Begin3(); break;
                case "4": Begin4(); break;
                case "5": Begin5(); break;
                case "6": Begin6(); break;
                case "7": Begin7(); break;
                case "8": Begin8(); break;
                case "9": Begin9(); break;
                case "10": Begin10(); break;
                default: Begin1(); break;
            }
        }
    }
}
