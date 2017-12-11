using System;

namespace Boolean1_10
{
    class Program
    {
        static void Boolean1()
        {
            // Дано целое число A. Проверить истинность высказывания: «Число
            // A является положительным».
            int A = 156;
            if (A > 0) Console.WriteLine("Number is positive");
            else Console.WriteLine("Number is negative");
        }
        static void Boolean2()
        {
        }
        static void Boolean3()
        {
        }
        static void Boolean4()
        {

        }
        static void Boolean5()
        {

        }
        static void Boolean6()
        {

        }
        static void Boolean7()
        {
            // Даны три целых числа: A, B, C. Проверить истинность высказывания: «Число B находится между числами A и C».
            int A = 56;
            int B = 25;
            int C = 345;
            if (B > A && B < C) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
        static void Boolean8()
        {

        }
        static void Boolean9()
        {
            
        }
        static void Boolean10()
        {
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            string nameTask = Console.ReadLine();
            switch (nameTask)
            {
                case "1": Boolean1(); break;
                case "2": Boolean2(); break;
                case "3": Boolean3(); break;
                case "4": Boolean4(); break;
                case "5": Boolean5(); break;
                case "6": Boolean6(); break;
                case "7": Boolean7(); break;
                case "8": Boolean8(); break;
                case "9": Boolean9(); break;
                case "10": Boolean10(); break;
                default: Boolean1(); break;
            }
        }
    }
}
