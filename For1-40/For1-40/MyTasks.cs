using System;

namespace For1_40
{
    class MyTasks
    {
        /// <summary>
        /// Дано вещественное число A и целое число N (> 0). Используя один цикл,
        /// найти значение выражения 1 – A + A2 – A3 + … + (–1)^N·A^N.
        /// </summary>
        /// <param name="a"> вещественное число </param>
        /// <param name="n"> целое число </param>
        /// <returns> 1 – A + A^2 – A^3 + … + (–1)^N·A^N </returns>
        public static double Func18(double a, int n)
        {
            if (n <= 0) return 0;
            else
            {
                double res = 1;
                for (int i = 1; i <= n; i++)
                    res = res + Math.Pow(-1, i) * Math.Pow(a, i);
                return res;
            }
        }
        /// <summary>
        /// Факториал числа n
        /// </summary>
        /// <param name="n"> число </param>
        /// <returns> возвращает факториал </returns>
        public static int Fact(int n)
        {
            int res = 1;
            for (int i = 2; i < n + 1; i++) res = res * i;
            return res;
        }
        /// <summary>
        /// Дано целое число N (> 0). Используя один цикл, найти сумму
        /// 1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!)
        /// (выражение N! — N–факториал — обозначает произведение всех целых
        /// чисел от 1 до N: N! = 1·2·…·N). Полученное число является приближенным значением константы e = exp(1).
        /// </summary>
        /// <param name="n"> целое число </param>
        /// <returns></returns>
        public static double Func21(int n)
        {
            if (n <= 0) return Math.E;
            else
            {
                double res = 2;
                for (int i = 2; i < n + 1; i++)
                {
                    int f = Fact(i);
                    if (f <= 0) break;
                    res = res + 1 / (double)f;
                }
                return res;
            }
        }
        /// <summary>
        /// Дано вещественное число X и целое число N (> 0). Найти значение выражения
        ///1 + X + X2/(2!) + … + XN/(N!)
        ///(N! = 1·2·…·N). Полученное число является приближенным значением
        ///функции exp в точке X
        /// <summary>
        public static double Func22(double x, int n)
        {
            if (n <= 0) return 0;
            else
            {
                double res = 1 + x;
                for (int i = 2; i < n + 1; i++)
                {
                    int f = Fact(i);
                    if (f <= 0) break;
                    res = res + Math.Pow(x, i) / (double)f;
                }
                return res;
            }
        }
        /// <summary>
        /// Дано вещественное число X и целое число N(> 0). Найти значение выражения
        /// X – X3 / (3!) +X5 / (5!) – … +(–1)N·X2·N + 1 / ((2·N + 1)!)
        /// (N! = 1·2·…·N). Полученное число является приближенным значением
        /// функции sin в точке X
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double Func23(double x, int n)
        {
            if (n <= 0) return 0;
            else
            {
                double res = x;
                for (int i = 1; i < n + 1; i++)
                {
                    int f = Fact(2 * i + 1);
                    if (f <= 0) break;
                    res = res + Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (double)f;
                }
                return res;
            }
        }
        /// <summary>
        /// Дано вещественное число X (|X| < 1) и целое число N (> 0). Найти значение выражения
        /// X – X3/3 + X5/5 – … + (–1)N·X2·N+1/(2·N+1).
        /// Полученное число является приближенным значением функции arctg в
        /// точке X.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double Func26(double x, int n)
        {
            if (n <= 0) return 0;
            else
            {
                double res = x;
                for (int i = 1; i < n + 1; i++)
                {
                    res = res + Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
                }
                return res;
            }
        }
    }
}
