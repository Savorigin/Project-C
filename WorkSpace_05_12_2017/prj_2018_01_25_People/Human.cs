using System;

namespace People
{
    class Human
    {
        public string Name { get; set; }
        public Human(string name): base()
        {
            Name = name;
        }
        public virtual void Eat()
        {
            Console.WriteLine("Eating food...");
        }
        public Human()
        {
            Name = "Anonim";
        }
        public override string ToString()
        {
            return $"Human {Name}";
        }
    }
}
