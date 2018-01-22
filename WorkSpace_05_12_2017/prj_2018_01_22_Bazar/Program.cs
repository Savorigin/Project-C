using System;

namespace Bazar
{
    class Program
    {
        static void Main(string[] args)
        {
            Products[] Basket = new Products[10];
            Basket[0] = new Products("Fruit", "Apple", 15.0, 2.0);
            Basket[1] = new Products("Fruit", "Pinapple", 25.0, 1.5);
            Basket[2] = new Products("Fruit", "Banana", 35.0, 3.5);
            Basket[3] = new Products("Vegetable", "Potato", 8.0, 6.0);
            Basket[4] = new Products("Vegetable", "Carrot", 11.0, 2.5);
            Basket[5] = new Products("Technics", "Phone", 1000.0, 0.1);
            Basket[6] = new Products("Technics", "TV", 5500.0, 5.0);
            Basket[7] = new Products("Technics", "Refrigerator", 10000.0, 25.0);
            Basket[8] = new Products("Household chemicals", "Powder", 150.0, 3.0);
            Basket[9] = new Products("Household chemicals", "Toothpaste", 35.0, 0.2);

            Products maxWeight = Order.maxWeightPrice10(Basket);
            maxWeight.Print();
        }
    }
}