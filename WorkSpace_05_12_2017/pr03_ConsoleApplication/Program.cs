using System;

namespace prj_2017_12_14_Units
{
    class Program
    {
        // Case7. Единицы массы пронумерованы следующим образом: 1 — килограмм,
        // 2 — миллиграмм, 3 — грамм, 4 — тонна, 5 — центнер.Дан номер единицы
        // массы(целое число в диапазоне 1–5) и масса тела в этих единицах(веще-
        // ственное число). Найти массу тела в килограммах.
        static int EnterCurrentUnit()
        {
            Console.WriteLine("Enter unit");
            Console.WriteLine("1. kg");
            Console.WriteLine("2. mg");
            Console.WriteLine("3. g");
            Console.WriteLine("4. t");
            Console.WriteLine("5. c");
            Console.WriteLine("0. exit");
            while (true)
            {
                int cu = int.Parse(Console.ReadLine());
                switch (cu)
                {
                    case 0: Console.WriteLine("Exit"); return cu;
                    case 1: Console.WriteLine("Current unit = kg"); return cu;
                    case 2: Console.WriteLine("Current unit = mg"); return cu;
                    case 3: Console.WriteLine("Current unit = g"); return cu;
                    case 4: Console.WriteLine("Current unit = t"); return cu;
                    case 5: Console.WriteLine("Current unit = c"); return cu;
                    default: break;
                }
            }
        }
        static double CountMassInKg(int cu, double m)
        {
            switch (cu)
            {
                case 1: return m;
                case 2: return m / 1000;
                case 3: return m / 100;
                case 4: return m * 1000;
                case 5: return m * 100;
                default: throw new ArgumentException("Error");
            }
        }
        static void TaskCase7()
        {
            Console.WriteLine("Enter mass");
            double m = double.Parse(Console.ReadLine());
            while (true)
            {
                int cu = EnterCurrentUnit();
                if (cu == 0) return;
                try
                {
                    double m_kg = CountMassInKg(cu, m);
                    Console.WriteLine("Mass in kg = " + m_kg);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
        static void Main(string[] args)
        {
            TaskCase7();
        }
    }
}
