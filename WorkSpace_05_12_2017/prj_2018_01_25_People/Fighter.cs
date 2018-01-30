using System;

namespace People
{
    class Fighter: Human
    {
        public int Power { get; set; }
        public Fighter() : base()
        {
            Console.WriteLine("Enter Power");
            Power = int.Parse(Console.ReadLine());
        }
        public Fighter(string name, int power): base(name)
        {
            Power = power;
        }
        public void Fight()
        {
            Console.WriteLine("Fighting...");
        }
        public override void print()
        {
            //Console.WriteLine("Fighter " + Name);
            Console.WriteLine(this);
        }
    }
}
