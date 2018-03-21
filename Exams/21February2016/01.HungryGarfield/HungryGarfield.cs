using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HungryGarfield
{
    class HungryGarfield
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal exchangeRate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            uint pizzaQuantity = uint.Parse(Console.ReadLine());
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());
            uint sandwichQuantity = uint.Parse(Console.ReadLine());

            decimal pizzaMoney = (pizzaPrice / exchangeRate) * pizzaQuantity;
            decimal lasagnaMoney = (lasagnaPrice / exchangeRate) * lasagnaQuantity;
            decimal sandwichMoney = (sandwichPrice / exchangeRate) * sandwichQuantity;

            decimal total = pizzaMoney + lasagnaMoney + sandwichMoney;
            decimal diff = Math.Abs(money - total);
            if (money >= total)
            {
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${diff:f2}.");
            }
            else if (money < total && money >= 0)
            {
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${diff:f2}.");
            }
        }
    }
}
