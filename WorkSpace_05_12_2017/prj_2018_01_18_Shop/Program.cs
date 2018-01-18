using System;

namespace Shop
{
    /// <summary>
    /// Класс Product содержит поля  
    //      - тип продукта(фрукты, овощи, бытовая химия, техника)
    //      - наименование(яблоки, бананы, компьютер, телефон)
    //      - вес 
    //      - цена
    // Создать 4 продукта.
    //      1) Найти с максимальным весом
    //      2) Найти с минимальной ценой
    //      3) Найти с общую стоимость всех продуктов
    /// </summary>
    class Program
    {
        /*static int i;
        int j;*/
        static void Main(string[] args)
        {
            /*i = 0;
            Program pr = new Program;
            pr.j = 0;*/
            Currency.USD = 28.8;
            Currency.EUR = 35.5;
            Product banana = new Product("Fruit", "Banana", 35.00, 1.000);
            Product phone = new Product("Technics", "IPhone", 10000, 0.100);
            Console.WriteLine(banana.Name + " price = " + banana.GetPrice());
            Console.WriteLine(phone.Name + " price = " + phone.GetPrice());
            Currency.USD = 38.8;
            Console.WriteLine(banana.Name + " price = " + banana.GetPrice());
            Console.WriteLine(phone.Name + " price = " + phone.GetPrice());
            phone.Name = "Motorola";
            Product apple = new Product("Vegetable", "Apple", 30.00, 2.000);
            Product powder = new Product("Household chemicals", "Powder", 105.00, 3.000);

            Product MaxWeight = banana;
            if (MaxWeight.Weight < phone.Weight) { MaxWeight = phone; }
            if (MaxWeight.Weight < apple.Weight) { MaxWeight = apple; }
            if (MaxWeight.Weight < powder.Weight) { MaxWeight = powder; }

            Console.WriteLine("Max weight:");
            MaxWeight.print();

            Product MinPrice = banana;
            if (MinPrice.GetPrice() > phone.GetPrice()) { MinPrice = phone; }
            if (MinPrice.GetPrice() > apple.GetPrice()) { MinPrice = apple; }
            if (MinPrice.GetPrice() > powder.GetPrice()) { MinPrice = powder; }

            Console.WriteLine("Min price:");
            MinPrice.print();

            double Sum = 0;
            Sum += banana.GetSum();
            Sum += phone.GetPrice();
            Sum += apple.GetSum();
            Sum += powder.GetSum();
            Console.WriteLine("Sum: " + Sum);

            Product[] orderProduct = new Product[4];
            orderProduct[0] = banana;
            orderProduct[1] = phone;
            orderProduct[2] = apple;
            orderProduct[3] = powder;

            Console.WriteLine("Max price:");
            OrderProduct.maxPriceProduct(orderProduct).print();

            Console.WriteLine("Min weight:");
            OrderProduct.minWeightProduct(orderProduct).print();

            Console.WriteLine("Total price: " + OrderProduct.totalPrice(orderProduct));
            Console.WriteLine("Total sum vegetable: " + OrderProduct.totalPriceVegetable(orderProduct));
        }
    }
}
