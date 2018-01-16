using System;

namespace Animals
{
    class Cat
    {
        public string name;
        public double weight;
        private int personalID;
        private static int ID = 0;
        private double diametr;
        private const double MAX_WEIGHT = 9.0;
        public Cat(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
            this.diametr = weight / 2;
        }
        public void eat(double food)
        {
            this.weight += food;
            this.diametr = weight / 2;
            Console.Write($"Cat {this.name} eating food {food}");
            Console.WriteLine($", diametr = {this.diametr}");
        }
        public bool isAlive() { return this.weight > 0; }
        public void SetDead() { this.weight = 0; this.diametr = weight / 2; }
        public void eat(Mouse mouseFood)
        {
            if (!isAlive()) return;
            this.weight += mouseFood.weight;
            this.diametr = weight / 2;
            mouseFood.SetDeadAndKiller(this);
            Console.Write($"Cat {this.name} eating mouse " + mouseFood.name);
            Console.WriteLine($", diametr = {this.diametr}");
            if (this.weight > MAX_WEIGHT)
            {
                Console.WriteLine($"BABAHHHHHH ..... Cat {this.name} DEAD .....");
                this.SetDead();
            }

        }
        public void print()
        {
            if (!isAlive()) Console.WriteLine("Cat = " + this.name + ", DEAD .....");
            else Console.WriteLine($"Cat {this.name}, {this.weight}, {this.diametr}");
        }
    }
}
