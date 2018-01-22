using System;

namespace Bazar
{
    class Products
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public Products(string type, string name, double price, double weight)
        {
            Type = type;
            Name = name;
            Price = price;
            Weight = weight;
        }
        public Products(): this("", "", 0.0, 0.0) {}
        public void Print()
        {
            Console.WriteLine("Product " + this.Type + " name " + this.Name + " price " + this.Price + " weight " + this.Weight);
        }
    }
}
