using System;

namespace Shop
{
    class OrderProduct
    {
        public static Product maxPriceProduct(Product[] orderProduct)
        {
            Product maxPriceProductInOrder = orderProduct[0];
            for (int i = 1; i < orderProduct.Length; i++)
            {
                if (maxPriceProductInOrder.GetPrice() < orderProduct[i].GetPrice()) { maxPriceProductInOrder = orderProduct[i]; }
            }
            return maxPriceProductInOrder;
        }
        public static Product minWeightProduct(Product[] orderProduct)
        {
            Product minWeightProductInOrder = orderProduct[0];
            foreach (var item in orderProduct)
            {
                if (minWeightProductInOrder.Weight > item.Weight) { minWeightProductInOrder = orderProduct[0]; }
            }
            return minWeightProductInOrder;
        }
        public static double totalPrice(Product[] orderProduct)
        {
            double totalPriceOrder = 0;
            foreach (var item in orderProduct)
            {
                totalPriceOrder += item.GetPrice();
            }
            return totalPriceOrder;
        }
        public static double totalPriceVegetable(Product[] orderProduct)
        {
            double totalPriceVegetableInOrder = 0;
            foreach (var item in orderProduct)
            {
                if (item.Type == "Vegetable")
                    totalPriceVegetableInOrder += item.GetSum();
            }
            return totalPriceVegetableInOrder;
        }
    }
}
