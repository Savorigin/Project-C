using System;

namespace People
{
    class Fighter: Human
    {
        public int Power { get; set; }
        public Fighter(string name, int power): base(name)
        {
            Power = power;
        }
        public void Fight()
        {
            Console.WriteLine("Fighting...");
        }
    }
}
