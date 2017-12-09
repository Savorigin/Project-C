using System;

namespace prj01_ConsoleApplication
{
    class Program
    {
        static void Task0()
        {
            int x = 10;
            int y = 5;
            int z = 2;
            double average = (double)(x + y) / z;
            Console.WriteLine("x = " + average);

            byte b = 255;
            b++;
            Console.WriteLine("b = " + b);

            float f1 = -10.000000000000f;
            float f2 = -20.000000000000f;
            double eps = 0.0001;
            bool res = Math.Abs(f1 - f2) < eps;
            Console.WriteLine(res);

            if (x > y || x > z) Console.WriteLine("x bigger then y");
            else Console.WriteLine("y bigger then x");
        }
        static int MyMin(int x, int y)
        {
            if (x < y) return x;
            else return y;
        }
        static void Task1()
        {
            int a = 9, c = 10, d = 11, e = 8;

            if (a < c && a < d && a < e)
                Console.WriteLine("a = " + a);
            else
                if (c < d && c < e)
                Console.WriteLine("c = " + c);
            else
                    if (d < e)
                Console.WriteLine("d = " + d);
            else
                Console.WriteLine("e = " + e);

            /*int myMin = a;

            if (c < myMin) myMin = c;
            if (d < myMin) myMin = d;
            if (e < myMin) myMin = e;*/

            /*int myMin = MyMin(a, c);
            myMin = MyMin(MyMin(a, c), d);
            myMin = MyMin(MyMin(MyMin(a, c), d), e);*/

            Console.WriteLine(MyMin(MyMin(MyMin(a, c), d), e));
            Console.WriteLine(Math.Min(Math.Min(Math.Min(a, c), d), e));
        }
        static void Task2()
        {
            int a = 9, b = 10, c = 11, d = 8;
            int myMax = Math.Max(Math.Max(Math.Max(a, b), c), d);
            int count = 0;
            if (a == myMax) count++;
            if (b == myMax) count++;
            if (c == myMax) count++;
            if (d == myMax) count++;
            Console.WriteLine("count of max = " + count);
        }
        static void Main(string[] args)
        {
            Task2();
        }
    }
}
