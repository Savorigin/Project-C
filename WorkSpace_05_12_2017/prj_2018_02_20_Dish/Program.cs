using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_2018_02_20_Dish
{
    delegate void OrderDish(Dish dish);
    class Oficiant
    {
        static public void GetOrderDish(Dish dish)
        {
            dish.Description += " Order dish";
            dish.Price += 0.5;
        }
        static public void ServiceDish(Dish dish)
        {
            dish.Description += " Service dish";
            dish.Price += 1.5;
        }
        static public void TakeMoney(Dish dish)
        {
            dish.Description += " TakeMoney";
            dish.Price += 0.2;
        }
        static public void GiveMoney(Dish dish)
        {
            dish.Description += " GiveMoney";
            dish.Price = -dish.Price;
        }
    }
    class ShefCooker
    {
        static public void CookDish(Dish dish)
        {
            dish.Description += " CookDish";
            dish.Price += 5.0;
        }

    }
    class SmallCooker
    {
        static public void CleanProduct(Dish dish)
        {
            dish.Description += " CleanProduct";
            dish.Price += 0.1;
        }
        static public void PrepareProduct(Dish dish)
        {
            dish.Description += " PrepareProduct";
            dish.Price += 0.1;
        }
        static public void GiveDish(Dish dish)
        {
            dish.Description += " GiveDish";
            dish.Price += 0.1;
        }
    }
    class Client
    {
        public string Name { get; set; }
        public string Job { get; set; }
    }
    class OrderDishEvent
    {
        public event OrderDish orders;
        public void OnOrder(Dish dish)
        {
            if (orders != null) orders(dish);
        }
    }
    class Program
    {
        static OrderDish MakeFryedPotato()
        {
            OrderDish potatoFree = Oficiant.GetOrderDish;
            potatoFree += SmallCooker.CleanProduct;
            potatoFree += SmallCooker.PrepareProduct;
            potatoFree += ShefCooker.CookDish;
            potatoFree += Oficiant.ServiceDish;
            potatoFree += Oficiant.TakeMoney;
            return potatoFree;
        }
        static void Order(Client client, OrderDish orderDish)
        {
            if (client.Job == "Taxes")
            {
                orderDish -= Oficiant.TakeMoney;
                orderDish += (Dish d) =>
                {
                    d.Price = 0;
                };
            }
            if (client.Job == "Police")
            {
                orderDish -= Oficiant.TakeMoney;
                orderDish += Oficiant.GiveMoney;
            }
        }
        static void Main(string[] args)
        {
            Dish potatoDish = new Dish
            {
                Description = "Potato",
                Price = 0.15
            };

            OrderDishEvent orderEvent = new OrderDishEvent();
            //OrderDish potatoFree = MakeFryedPotato();
            orderEvent.orders += MakeFryedPotato();

            Client vasya = new Client()
            {
                Job = "Police"
            };

            Client masha = new Client()
            {
                Job = "Taxes"
            };

            //Order(vasya, potatoFree);
            //potatoFree(potatoDish);
            orderEvent.orders -= (dish) => { dish.Price = 11; };
            orderEvent.OnOrder(potatoDish);

            Console.WriteLine(potatoDish.Description);
            Console.WriteLine(potatoDish.Price);
        }
    }
}
