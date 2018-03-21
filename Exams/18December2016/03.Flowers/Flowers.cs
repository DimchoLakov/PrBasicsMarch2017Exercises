using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine().ToLower();

            double hrizantemiPrice = 0.0d;
            double roziPrice = 0.0d;
            double laletaPrice = 0.0d;
            double bouquetPrice = 0.0d;
            int allFlowers = hrizantemi + rozi + laleta;
            if (season == "spring" || season == "summer")
            {
                hrizantemiPrice = hrizantemi * 2.0;
                roziPrice = rozi * 4.1;
                laletaPrice = laleta * 2.5;
            }
            else if (season == "autumn" || season == "winter")
            {
                hrizantemiPrice = hrizantemi * 3.75;
                roziPrice = rozi * 4.5;
                laletaPrice = laleta * 4.15;
            }
            bouquetPrice = hrizantemiPrice + roziPrice + laletaPrice;
            if (holiday == "y")
            {
                bouquetPrice += bouquetPrice * 0.15;
            }
            if (laleta > 7 && season == "spring")
            {
                bouquetPrice -= bouquetPrice * 0.05;
            }
            if (rozi >= 10 && season == "winter")
            {
                bouquetPrice -= bouquetPrice * 0.1;
            }
            if (allFlowers > 20)
            {
                bouquetPrice -= bouquetPrice * 0.2;
            }
            double fullBouquetPrice = bouquetPrice + 2;
            Console.WriteLine($"{fullBouquetPrice:f2}");
        }
    }
}
