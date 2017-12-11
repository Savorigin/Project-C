using System;

namespace if1_30
{
    class Program
    {
        static void if21()
        {
            // Даны целочисленные координаты точки на плоскости. Если точка совпадает с началом координат, то вывести 0. Если точка не совпадает с началом
            // координат, но лежит на оси OX или OY, то вывести соответственно 1 или 2.
            // Если точка не лежит на координатных осях, то вывести 3.
            int x = 134;
            int y = 345;
            if (x == 0 && y == 0) Console.WriteLine(0);
            else
                if (x == 0 && y != 0) Console.WriteLine(1);
                else
                    if (x != 0 && y == 0) Console.WriteLine(2);
                    else Console.WriteLine(3);
        }
        static void if22()
        {
            // Даны координаты точки, не лежащей на координатных осях OX и OY.
            // Определить номер координатной четверти, в которой находится данная
            // точка.
            int x = 134;
            int y = -345;
            if (x > 0)
                if (y > 0) Console.WriteLine(1);
                else Console.WriteLine(4);
            else
                if (y > 0) Console.WriteLine(2);
                else Console.WriteLine(3);
        }
        static void if23()
        {
            // Даны целочисленные координаты трех вершин прямоугольника, стороны
            // которого параллельны координатным осям. Найти координаты его четвертой вершины.
            int x1 = 56;
            int y1 = 48;
            int x2 = -32;
            int y2 = 48;
            int x3 = -32;
            int y3 = -12;
            int x4 = 0;
            int y4 = 0;
            if (x1 == x2) x4 = x3;
            else if (x1 == x3) x4 = x2;
            else if (x2 == x3) x4 = x1;
            if (y1 == y2) y4 = y3;
            else if (y1 == y3) y4 = y2;
            else if (y2 == y3) y4 = y1;
            Console.WriteLine("x4 = " + x4.ToString());
            Console.WriteLine("y4 = " + y4.ToString());
        }
        static void if24()
        {
            // Для данного вещественного x найти значение следующей функции f, принимающей вещественные значения:
            //         2·sin(x), если x > 0,
            // f(x) =  6 – x, если x ≤ 0.
            double x = 23.456;
            double f;
            if (x > 0) f = 2 * Math.Sin(x);
            else f = 6 - x;
            Console.WriteLine("f(x) = " + f.ToString());
        }
        static void if25()
        {
            
        }
        static void if26()
        {
            // Для данного вещественного x найти значение следующей функции f, принимающей вещественные значения:
            //         –x, если x ≤ 0,
            // f(x) =  x2, если 0 < x < 2,
            //         4, если x ≥ 2.
            double x = 1.346;
            double f;
            if (x <= 0) f = -x;
            else if (x > 0 && x < 2) f = Math.Pow(x, 2);
            else f = 4.0;
            Console.WriteLine("f(x) = " + f.ToString());
        }
        static void if27()
        {
           
        }
        static void if28()
        {

        }
        static void if29()
        {

        }
        static void if30()
        {
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            string nameTask = Console.ReadLine();
            switch (nameTask)
            {
                case "21": if21(); break;
                case "22": if22(); break;
                case "23": if23(); break;
                case "24": if24(); break;
                case "25": if25(); break;
                case "26": if26(); break;
                case "27": if27(); break;
                case "28": if28(); break;
                case "29": if29(); break;
                case "30": if30(); break;
                default: if21(); break;
            }
        }
    }
}
