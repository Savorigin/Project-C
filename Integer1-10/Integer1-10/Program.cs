using System;

namespace Integer1_10
{
    class Program
    {
        static void Integer1()
        {
            // Дано расстояние L в сантиметрах. Используя операцию деления нацело, найти количество полных метров в нем (1 метр = 100 см).
            int L = 156;
            int countM = ((L - L % 100) / 100);
            Console.WriteLine("Количество метров = " + countM.ToString());
        }
        static void Integer2()
        {
            // Дана масса M в килограммах. Используя операцию деления нацело,
            // найти количество полных тонн в ней(1 тонна = 1000 кг).
            int kg = 1556546;
            double t = Math.Floor((double)kg / 1000);
            Console.WriteLine("Количество тонн = " + t.ToString());
        }
        static void Integer3()
        {
            // Дан размер файла в байтах. Используя операцию деления нацело,
            // найти количество полных килобайтов, которые занимает данный файл
            // (1 килобайт = 1024 байта).
            int b = 35434564;
            int kb = b / 1024;
            Console.WriteLine("Kb = " + kb.ToString());
        }
        static void Integer4()
        {

        }
        static void Integer5()
        {

        }
        static void Integer6()
        {

        }
        static void Integer7()
        {
            // Дано двузначное число. Найти сумму и произведение его цифр.
            int dch = 56;
            int p = dch / 10;
            int o = dch % 10;
            Console.WriteLine("Сумма = " + (o + p).ToString() + ", Произведение = " + (o * p).ToString());
        }
        static void Integer8()
        {

        }
        static void Integer9()
        {

        }
        static void Integer10()
        {
            // Дано трехзначное число. Вывести вначале его последнюю цифру
            // (единицы), а затем — его среднюю цифру(десятки).
            int ch = 639;
            int d = ch % 100;
            int l = d % 10;
            Console.WriteLine("Последняя = " + l.ToString() + ", средняя = " + (d / 10).ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            string nameTask = Console.ReadLine();
            switch (nameTask)
            {
                case "1": Integer1(); break;
                case "2": Integer2(); break;
                case "3": Integer3(); break;
                case "4": Integer4(); break;
                case "5": Integer5(); break;
                case "6": Integer6(); break;
                case "7": Integer7(); break;
                case "8": Integer8(); break;
                case "9": Integer9(); break;
                case "10": Integer10(); break;
                default: Integer1(); break;
            }
        }
    }
}
