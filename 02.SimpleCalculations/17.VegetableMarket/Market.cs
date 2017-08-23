using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.VegetableMarket
{
    class Market
    {
        static void Main(string[] args)
        {
            double priceForKiloVegetables = double.Parse(Console.ReadLine());
            double priceForKiloFruits = double.Parse(Console.ReadLine());
            int vegKilos = int.Parse(Console.ReadLine());
            int fruitKilos = int.Parse(Console.ReadLine());
            double euro = 1.94;
            double totalVeg = (priceForKiloVegetables * vegKilos) / euro;
            double totalFruit = (priceForKiloFruits * fruitKilos) / euro;
            double totalAmount = totalFruit + totalVeg;
            Console.WriteLine(totalAmount);
            
        }
    }
}
