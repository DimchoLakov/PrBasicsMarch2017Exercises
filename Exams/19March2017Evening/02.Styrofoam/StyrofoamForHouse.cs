using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Styrofoam
{
    class StyrofoamForHouse
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            double windowsNumber = double.Parse(Console.ReadLine()) * 2.4;
            double sqMeterPerPack = double.Parse(Console.ReadLine());
            double priceForPack = double.Parse(Console.ReadLine());

            double styroArea = ((houseArea - windowsNumber) + (0.1 * (houseArea - windowsNumber)));
            double packetsNeeded = Math.Ceiling(styroArea / sqMeterPerPack);
            double price = packetsNeeded * priceForPack;
            double moneyLeft = budget - price;
            double spentMoney = budget - moneyLeft;
            double moneyNotEnough = price - budget;
            if (price < budget)
            {
                Console.WriteLine("Spent: {0:f2}", spentMoney);
                Console.WriteLine("Left: {0:f2}", moneyLeft);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", moneyNotEnough);
            }
        }
    }
}
