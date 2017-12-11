using System;

namespace Boolean21_30
{
    class Program
    {
        static void Boolean21()
        {

        }
        static void Boolean22()
        {

        }
        static void Boolean23()
        {

        }
        static void Boolean24()
        {

        }
        static void Boolean25()
        {

        }
        static void Boolean26()
        {

        }
        static void Boolean27()
        {
            // Даны числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит во второй или третьей координатной четверти».
            int x = -45;
            int y = 65;
            if (x < 0 && (y > 0 || y < 0)) Console.WriteLine(true);
            /*if (y > 0) Console.WriteLine("Во второй");
            else Console.WriteLine("В третьей");*/
            else Console.WriteLine(false);
        }
        static void Boolean28()
        {

        }
        static void Boolean29()
        {
            
        }
        static void Boolean30()
        {
            // Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника.Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равносторонним».
            int a = 10;
            int b = 30;
            int c = 40;
            if (a == b && b == c && a == c) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            string nameTask = Console.ReadLine();
            switch (nameTask)
            {
                case "21": Boolean21(); break;
                case "22": Boolean22(); break;
                case "23": Boolean23(); break;
                case "24": Boolean24(); break;
                case "25": Boolean25(); break;
                case "26": Boolean26(); break;
                case "27": Boolean27(); break;
                case "28": Boolean28(); break;
                case "29": Boolean29(); break;
                case "30": Boolean30(); break;
                default: Boolean21(); break;
            }
        }
    }
}
