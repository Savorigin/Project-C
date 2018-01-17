using System;

namespace Animals
{
    class Dog
    {
        public string name;
        public double weight;
        public int year;
        static int ID = 0;
        public int personalID;
        private Kind KindOfDog;
        private enum Kind { puppy, dog };
        private const int YEAR_FOR_KIND = 2;
        private const double MAX_WEIGHT = 25;
        public Dog(string name, double weight, int year)
        {
            this.name = name;
            this.weight = weight;
            this.year = year;
            if (year > YEAR_FOR_KIND) this.KindOfDog = Kind.dog;
            else this.KindOfDog = Kind.puppy;
            this.personalID = ID;
            ID++;
        }
        public void print()
        {
            if (isDead()) Console.WriteLine($"Dog name = {this.name}({this.personalID}/{ID}), is DEAD ...");
            else Console.WriteLine($"Dog name {this.name}({this.personalID}/{ID}), weight {this.weight}, year {this.year}, kind {this.KindOfDog.ToString()}");
        }
        public bool isDead()
        {
            if (this.weight == 0) return true; else return false;
        }
        public void eat(double food)
        {
            if (isDead()) return;
            this.weight += food;
            Console.WriteLine($"Dog {this.name} eat food {food}");
            if (this.weight > MAX_WEIGHT) { Console.WriteLine($"Dog {this.name} is DEAD ..."); this.weight = 0; }
        }
    }
}
