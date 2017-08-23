using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class Shop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.5;
                }
                else if (fruit == "apple")
                {
                    price = quantity * 1.2;
                }
                else if (fruit == "orange")
                {
                    price = quantity * 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    price = quantity * 1.45;
                }
                else if (fruit == "kiwi")
                {
                    price = quantity * 2.7;
                }
                else if (fruit == "pineapple")
                {
                    price = quantity * 5.5;
                }
                else if (fruit == "grapes")
                {
                    price = quantity * 3.85;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine($"{price:f2}");
            }
            else if (day == "saturday"  || day == "sunday")
            {
                if (fruit == "banana")
                {
                    price = quantity * 2.7;
                }
                else if (fruit == "apple")
                {
                    price = quantity * 1.25;
                }
                else if (fruit == "orange")
                {
                    price = quantity * 0.9;
                }
                else if (fruit == "grapefruit")
                {
                    price = quantity * 1.6;
                }
                else if (fruit == "kiwi")
                {
                    price = quantity * 3;
                }
                else if (fruit == "pineapple")
                {
                    price = quantity * 5.6;
                }
                else if (fruit == "grapes")
                {
                    price = quantity * 4.2;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("{0:f2}", price);
            }
            else if (price == 0)
            {
                Console.WriteLine("error");
            }
        }
    }
}

