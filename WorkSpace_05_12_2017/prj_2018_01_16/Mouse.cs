using System;

namespace Animals
{
    class Mouse
    {
        // Default privat
        // string name;
        // double weight;
        // int year;
        public string name;
        public double weight;
        public int year;
        public Cat killer;
        private int personalID;
        private static int ID = 1111;
        public Mouse(string name, double weight, int year)
        {
            this.name = name;
            this.weight = weight;
            this.year = year;
            this.personalID = ID;
            ID++;
        }
        public Mouse(string name): this(name, 2.5, 4)
        {
            /*this.name = name;
            this.weight = 2.5;
            this.year = 4;*/
        }
        public Mouse(): this("Anonimous", 1.0, 1)
        {
            /*this.name = "Anonimous";
            this.weight = 1.0;
            this.year = 1;*/
        }
        public void SetDeadAndKiller(Cat killer)
        {
            this.weight = 0;
            this.killer = killer;
        }
        public void print()
        {
            if (this.weight == 0) Console.WriteLine("Mouse = " + this.name + "(" + this.personalID + "," + ID + "), DEAD ..... Who is killer? -> " + killer.name);
            else Console.WriteLine("Mouse = " + this.name + "(" + this.personalID + "," + ID + "), " + this.weight + ", " + this.year);
        }
        public void eat(double food)
        {
            // this.weight = this.weight + food;
            this.weight += food;
            Console.WriteLine("Mouse " + this.name + " eating food = " + food);
        }
    }
}
