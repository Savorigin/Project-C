using System;

namespace Case1_40
{
    /// <summary>
    /// Case15.Мастям игральных карт присвоены порядковые номера: 1 — пики,
    /// 2 — трефы, 3 — бубны, 4 — червы.Достоинству карт, старших десятки,
    /// присвоены номера: 11 — валет, 12 — дама, 13 — король, 14 — туз.Даны
    /// два целых числа: N — достоинство(6 ≤ N ≤ 14) и M — масть карты
    /// (1 ≤ M ≤ 4). Вывести название соответствующей карты вида «шестерка бу-
    /// бен», «дама червей», «туз треф» и т.п.
    /// </summary>
    class Case15
    {
        const int mast_from = 1; //  4
        const int kind_from = 6; // 14
        static int EnterMast()
        {
            Console.WriteLine("Enter mast");
            while (true)
            {
                try
                {
                    int mast = int.Parse(Console.ReadLine());
                    if (mast >= mast_from && mast <= mast_from + 3) return mast;
                    else throw new FormatException("Non correct mast");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static int EnterKind()
        {
            Console.WriteLine("Enter kind");
            while (true)
            {
                try
                {
                    int kind = int.Parse(Console.ReadLine());
                    if (kind >= kind_from && kind <= kind_from + 8) return kind;
                    else throw new FormatException("Non correct kind");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static string MastCard(int mast)
        {
            string name = "";
            switch (mast)
            {
                case mast_from: name = "пик"; break;
                case mast_from + 1: name = "треф"; break;
                case mast_from + 2: name = "бубен"; break;
                case mast_from + 3: name = "червей"; break;
                default: break;
            }
            return name;
        }
        static string KindCard(int kind)
        {
            string name = "";
            switch (kind)
            {
                case kind_from: name = "шестерка"; break;
                case kind_from + 1: name = "семерка"; break;
                case kind_from + 2: name = "восьмерка"; break;
                case kind_from + 3: name = "девятка"; break;
                case kind_from + 4: name = "десятка"; break;
                case kind_from + 5: name = "валет"; break;
                case kind_from + 6: name = "дама"; break;
                case kind_from + 7: name = "король"; break;
                case kind_from + 8: name = "туз"; break;
                default: break;
            }
            return name;
        }
        public static void Task()
        {
            Console.Clear();
            int mast = EnterMast();
            int kind = EnterKind();
            Console.WriteLine("Карта " + KindCard(kind) + " " + MastCard(mast));
            Console.ReadLine();
        }
    }
}
