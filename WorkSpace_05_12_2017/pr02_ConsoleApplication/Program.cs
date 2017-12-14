using System;

namespace pr02_ConsoleApplication
{
    class Program
    {
        // Case10. Робот может перемещаться в четырех направлениях («С» — север,
        // «З» — запад, «Ю» — юг, «В» — восток) и принимать три цифровые ко-
        // манды: 0 — продолжать движение, 1 — поворот налево, –1 — поворот на-
        // право.Дан символ C — исходное направление робота и целое число N —
        // посланная ему команда.Вывести направление робота после выполнения
        // полученной команды.
        static char EnterCurrentDirection()
        {
            Console.WriteLine("Enter current direction");
            Console.WriteLine("N. North");
            Console.WriteLine("S. South");
            Console.WriteLine("E. East");
            Console.WriteLine("W. West");
            while (true)
            {
                char ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 'n':
                    case 'N': return 'N';
                    case 's':
                    case 'S': return 'S';
                    case 'e':
                    case 'E': return 'E';
                    case 'w':
                    case 'W': return 'W';
                    default: break;
                }
            }
        }
        static char EnterDifferentTurn(char ct)
        {
            Console.WriteLine("Enter turn");
            Console.WriteLine("0. Continue");
            Console.WriteLine("1. Left");
            Console.WriteLine("-1. Right");
            Console.WriteLine("2. Stop");
            while (true)
            {
                int dir = int.Parse(Console.ReadLine());
                switch (dir)
                {
                    case 0:
                        {
                            switch (ct)
                            {
                                case 'N':
                                case 'S':
                                case 'E':
                                case 'W':
                                default: break;
                            }
                            break;
                        }
                    case 1: // left
                        {
                            switch (ct)
                            {
                                case 'N': ct = 'E'; break;
                                case 'S': ct = 'W'; break;
                                case 'E': ct = 'S'; break;
                                case 'W': ct = 'N'; break;
                                default: break;
                            }
                            break;
                        }
                    case -1:
                        {
                            switch (ct)
                            {
                                case 'N': ct = 'W'; break;
                                case 'S': ct = 'E'; break;
                                case 'E': ct = 'N'; break;
                                case 'W': ct = 'S'; break;
                                default: break;
                            }
                            break;
                        }
                    case 2: return ct;
                    default: break;
                }
                Console.WriteLine("Current direction = " + ct.ToString());
            }
        }
        static void Main(string[] args)
        {
            char ct = EnterCurrentDirection();
            Console.WriteLine("Current direction = " + ct.ToString());
            char nt = EnterDifferentTurn(ct);
            Console.WriteLine("Next direction = " + nt.ToString());
        }
    }
}
