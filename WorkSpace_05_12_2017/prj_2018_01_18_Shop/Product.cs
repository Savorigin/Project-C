using System;

namespace Shop
{
    public class Product
    {
        public int Id { get; set; }
        public int Id2 { get; private set; }
        private string type;
        public string Type { get => type; set => type = value; }
        private string name;
        public string Name {
            set { name = value; }
            get { return name.ToLower(); }
        }
        private double price;
        public void SetPrice(double price, double tax_in)
        {
            this.price = price * (1 + tax_in) / Currency.USD;
        }
        public double GetPrice()
        {
            return this.price * Currency.USD * (1.20 + 0.10 + 0.10 + 0.10 + 0.25);
        }
        private double weight;
        public double Weight {
            set { this.weight = value * 1000; }
            get { return weight / 1000; }
        }
        public Product(string type, string name, double price, double weight)
        {
            Type = type;
            this.Name = name;
            this.SetPrice(price, 0.20);
            this.Weight = weight;
        }
        public void print()
        {
            Console.WriteLine(this.Type + " " + this.Name + " price " + this.GetPrice() + " weight " + this.Weight);
        }
        public double GetSum()
        {
            return this.GetPrice() * this.Weight;
        }
    }
}
