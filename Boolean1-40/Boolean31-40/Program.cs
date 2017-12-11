using System;

namespace Boolean31_40
{
    class Program
    {
        static void Boolean31()
        {
            // Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника.Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равнобедренным».
            int a = 56;
            int b = 25;
            int c = 345;
            if (a == b || a == c || b == c) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
        static void Boolean32()
        {
        }
        static void Boolean33()
        {
        }
        static void Boolean34()
        {

        }
        static void Boolean35()
        {

        }
        static void Boolean36()
        {

        }
        static void Boolean37()
        {

        }
        static void Boolean38()
        {

        }
        static void Boolean39()
        {

        }
        static void Boolean40()
        {
            // Даны координаты двух различных полей шахматной доски x1, y1,
            // x2, y2 (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания: «Конь за один ход может перейти с одного поля на другое».
            int x1 = 4;
            int y1 = 5;
            int x2 = 6;
            int y2 = 6;
            if (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2 || Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            string nameTask = Console.ReadLine();
            switch (nameTask)
            {
                case "31": Boolean31(); break;
                case "32": Boolean32(); break;
                case "33": Boolean33(); break;
                case "34": Boolean34(); break;
                case "35": Boolean35(); break;
                case "36": Boolean36(); break;
                case "37": Boolean37(); break;
                case "38": Boolean38(); break;
                case "39": Boolean39(); break;
                case "40": Boolean40(); break;
                default: Boolean31(); break;
            }
        }
    }
}
