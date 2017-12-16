using System;

namespace Case1_40
{
    class Program
    {
        // Case20. Даны два целых числа: D (день) и M (месяц), определяющие правильную дату. Вывести знак Зодиака, соответствующий этой дате: «Водолей»
        // (20.1–18.2), «Рыбы» (19.2–20.3), «Овен» (21.3–19.4), «Телец» (20.4–20.5),
        // «Близнецы» (21.5–21.6), «Рак» (22.6–22.7), «Лев» (23.7–22.8), «Дева»
        // (23.8–22.9), «Весы» (23.9–22.10), «Скорпион» (23.10–22.11), «Стрелец»
        // (23.11–21.12), «Козерог» (22.12–19.1).
        static int EnterMonthDay(string name, int month_for_day = 0)
        {
            Console.WriteLine("Enter " + name);
            while (true)
            {
                switch (name)
                {
                    case "month":
                        try
                        {
                            int month = int.Parse(Console.ReadLine());
                            if (month <= 0 && month > 12) throw new FormatException("Not correct format of month - " + month);
                            return month;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }; break;
                    case "day":
                        try
                        {
                            int count_of_days = 0;
                            switch (month_for_day)
                            {
                                case 2: count_of_days = 28; break;
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                case 12: count_of_days = 31; break;
                                case 4:
                                case 6:
                                case 9:
                                case 11: count_of_days = 30; break;
                                default: throw new FormatException("Not correct format of month - " + month_for_day);
                            }
                            int day = int.Parse(Console.ReadLine());
                            if (day <= 0 && day > count_of_days) throw new FormatException("Not correct format of month");
                            return day;
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }; break;
                    default: Console.WriteLine("Not correct parametr " + name); return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            int month = EnterMonthDay("month");
            if (month == 0) return;
            int day = EnterMonthDay("day", month);
            if (day == 0) return;
            switch (month)
            {
                case 1:
                    {
                        if (day < 20) Console.WriteLine("Козерог"); else Console.WriteLine("Водолей"); break;
                    }
                case 2:
                    {
                        if (day < 19) Console.WriteLine("Водолей");   else Console.WriteLine("Рыбы");     break;
                    }
                case 3:
                    {
                        if (day < 21) Console.WriteLine("Рыбы");      else Console.WriteLine("Овен");     break;
                    }
                case 4:
                    {
                        if (day < 20) Console.WriteLine("Овен");      else Console.WriteLine("Телец");    break;
                    }
                case 5:
                    {
                        if (day < 21) Console.WriteLine("Телец");     else Console.WriteLine("Близнецы"); break;
                    }
                case 6:
                    {
                        if (day < 22) Console.WriteLine("Близнецы");  else Console.WriteLine("Рак");      break;
                    }
                case 7:
                    {
                        if (day < 23) Console.WriteLine("Рак");       else Console.WriteLine("Лев");      break;
                    }
                case 8:
                    {
                        if (day < 23) Console.WriteLine("Лев");       else Console.WriteLine("Дева");     break;
                    }
                case 9:
                    {
                        if (day < 23) Console.WriteLine("Дева");      else Console.WriteLine("Весы");     break;
                    }
                case 10:
                    {
                        if (day < 23) Console.WriteLine("Весы");     else Console.WriteLine("Скорпион"); break;
                    }
                case 11:
                    {
                        if (day < 23) Console.WriteLine("Скорпион"); else Console.WriteLine("Стрелец");  break;
                    }
                case 12:
                    {
                        if (day < 22) Console.WriteLine("Стрелец");  else Console.WriteLine("Козерог");  break;
                    }
                default: Console.WriteLine("Non known date"); break;
            }
        }
    }
}
