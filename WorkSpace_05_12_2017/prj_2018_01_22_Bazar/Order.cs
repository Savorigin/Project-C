using System;

namespace Bazar
{
    class Order
    {
        public static Products maxWeightPrice10(Products[] order)
        {
            Products maxWeight = new Products();
            for (int i = 0; i < order.Length; i++)
            {
                if (order[i].Price < 10)
                    if (maxWeight.Weight < order[i].Weight) maxWeight = order[i];
            }
            return maxWeight;
        }
    }
}
