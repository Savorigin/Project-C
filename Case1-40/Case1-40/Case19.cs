using System;

namespace Case1_40
{
    /// <summary>
    /// Case19.В восточном календаре принят 60-летний цикл, состоящий из 12-летних подциклов, обозначаемых названиями цвета: зеленый, красный, желтый, белый и черный.В каждом подцикле годы носят названия животных:
    /// крысы, коровы, тигра, зайца, дракона, змеи, лошади, овцы, обезьяны, курицы, собаки и свиньи.По номеру года определить его название, если 1984
    /// год — начало цикла: «год зеленой крысы».
    /// </summary>
    class Case19
    {
        const int start = 1924;
        static int EnterYear()
        {
            Console.WriteLine("Enter year > " + start);
            while (true)
            {
                try
                {
                    int year = int.Parse(Console.ReadLine());
                    if (year < start) throw new FormatException("Not correct year");
                    return year;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static string NameOfYear(int year)
        {
            int bitw = year - start;
            int ost12 = bitw % 12;
            string nameofyear = "";
            switch (ost12)
            {
                case 0:
                    nameofyear = "крысы"; break;
                case 1:
                    nameofyear = "коровы"; break;
                case 2:
                    nameofyear = "тигра"; break;
                case 3:
                    nameofyear = "зайца"; break;
                case 4:
                    nameofyear = "дракона"; break;
                case 5:
                    nameofyear = "змеи"; break;
                case 6:
                    nameofyear = "лошади"; break;
                case 7:
                    nameofyear = "овцы"; break;
                case 8:
                    nameofyear = "обезьяны"; break;
                case 9:
                    nameofyear = "курицы"; break;
                case 10:
                    nameofyear = "собаки"; break;
                case 11:
                    nameofyear = "свиньи"; break;
                default: break;
            }
            return nameofyear;
        }
        static string ColorOfYear(int year)
        {
            int bitw = year - start;
            int ost5 = bitw % 5;
            int ost12 = bitw % 12;
            string colorofyear = "";
            switch (ost5)
            {
                case 0:
                    if (ost12 == 2 || ost12 == 3 || ost12 == 4) colorofyear = "зеленого"; else colorofyear = "зеленой"; break;
                case 1:
                    if (ost12 == 2 || ost12 == 3 || ost12 == 4) colorofyear = "красного"; else colorofyear = "красной"; break;
                case 2:
                    if (ost12 == 2 || ost12 == 3 || ost12 == 4) colorofyear = "желтого"; else colorofyear = "желтой"; break;
                case 3:
                    if (ost12 == 2 || ost12 == 3 || ost12 == 4) colorofyear = "белого"; else colorofyear = "белой"; break;
                case 4:
                    if (ost12 == 2 || ost12 == 3 || ost12 == 4) colorofyear = "черный"; else colorofyear = "черной"; break;
                default: break;
            }
            return colorofyear;
        }
        public static void Task()
        {
            Console.Clear();
            int year = EnterYear();
            string name = NameOfYear(year);
            string color = ColorOfYear(year);
            Console.WriteLine("Год " + color + " " + name);
            Console.ReadLine();
        }
    }
}
