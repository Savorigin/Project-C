using System;

namespace prj_2017_12_12_Console_Class
{
    class MyLib
    {
        public static void Task5()
        {
            // При помощи цикла for вывести на экран нечетные числа от 1 до 99.
            for (int i = 1; i < 100; i++)
                if (i % 2 == 0) Console.WriteLine(i);
        }
        public static int Fact(int n)
        {
            // Дано число n при помощи цикла for посчитать n! (факториал числа) n!=n*(n-1)!
            int res = 1;
            for (int i = 2; i < n + 1; i++) res = res * i;
            return res;
        }
        public static void Task7()
        {
            // При помощи цикла for вывести на экран нечетные числа от 1 до 99.
            // Перепишите программы с использованием цикла while.
            int i = 1;
            while (i < 100)
            {
                if (i % 2 == 0) Console.WriteLine(i);
                i++;
            }
        }
        public static void Task8()
        {
            // Перепишите программы с использованием цикла while.
            int n = 5;
            int res = 1;
            int i = 1;
            while (i < n)
            {
                res = res * i;
                i++;
            }
            Console.WriteLine(res);
        }
        /// <summary>
        /// Вычисление степени
        /// </summary>
        /// <param name="x"> основание </param>
        /// <param name="n"> степень </param>
        /// <returns> результат x ^ n</returns>
        public static int Pow(int x, int n)
        {
            // Даны переменные x и n вычислить x ^ n
            int i = 1;
            int res = 1;
            do
            {
                res = res * x;
                i++;
            } while (i <= 8);
            return res;
        }
        public static void Task10()
        {
            // Вывести 10 первых чисел последовательности 0, -5,-10,-15..
            for (int i = 0; i > -50; i -= 5) Console.WriteLine(i);
        }
        public static void Task11()
        {
            // Используя циклы и метод: 
            // Console.Write("*"), Console.Write(" "), Console.Write("\n")(для перехода на новую строку).
            // Выведите на экран:
            // · прямоугольник
            // · прямоугольный треугольник  
            // · равносторонний треугольник   
            // · ромб
            int n = 5;
            int m = 10;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (j == 1 || j == m) Console.Write("*");
                    else if (i != 1 && i != n) Console.Write(" ");
                    else Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i) Console.Write("*");
                    else if (i != 1 && i != n) Console.Write(" ");
                    else Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
