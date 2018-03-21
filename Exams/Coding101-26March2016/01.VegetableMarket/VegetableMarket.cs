using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding101_26March2016
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            double priceKiloVeg = double.Parse(Console.ReadLine());
            double priceKiloFruit = double.Parse(Console.ReadLine());
            double totalKilosVeg = double.Parse(Console.ReadLine());
            double totalKilosFruit = double.Parse(Console.ReadLine());

            double totalVegs = (priceKiloVeg * totalKilosVeg) / 1.94;
            double totalFruits = (priceKiloFruit * totalKilosFruit) / 1.94;
            double totalPrice = totalVegs + totalFruits;
            Console.WriteLine(totalPrice);
        }
    }
}
