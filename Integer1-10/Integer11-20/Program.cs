using System;

namespace Integer11_20
{
    class Program
    {
        static void Integer11()
        {
        }
        static void Integer12()
        {
        }
        static void Integer13()
        {
        }
        static void Integer14()
        {

        }
        static void Integer15()
        {

        }
        static void Integer16()
        {

        }
        static void Integer17()
        {
            // Дано целое число, большее 999. Используя одну операцию деления
            // нацело и одну операцию взятия остатка от деления, найти цифру, соответствующую разряду сотен в записи этого числа.
            int ch = 1759;
            int o = ch % 1000;
            int s = o / 100;
            Console.WriteLine("Сотни = " + s.ToString());
        }
        static void Integer18()
        {

        }
        static void Integer19()
        {
            // С начала суток прошло N секунд (N — целое). Найти количество
            // полных минут, прошедших с начала суток.
            int N = 53456;
            int m = N / 60;
            Console.WriteLine("Full minutes = " + m.ToString());
        }
        static void Integer20()
        {
            // С начала суток прошло N секунд(N — целое). Найти количество
            // полных часов, прошедших с начала суток.
            int N = 53456;
            int m = N / 60;
            int ch = m / 60;
            Console.WriteLine("Full hours = " + ch.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            string nameTask = Console.ReadLine();
            switch (nameTask)
            {
                case "11": Integer11(); break;
                case "12": Integer12(); break;
                case "13": Integer13(); break;
                case "14": Integer14(); break;
                case "15": Integer15(); break;
                case "16": Integer16(); break;
                case "17": Integer17(); break;
                case "18": Integer18(); break;
                case "19": Integer19(); break;
                case "20": Integer20(); break;
                default: Integer11(); break;
            }
        }
    }
}
