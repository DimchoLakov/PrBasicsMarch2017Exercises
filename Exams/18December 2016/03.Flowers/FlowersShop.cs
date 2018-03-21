using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class FlowersShop
    {
        static void Main(string[] args)
        {
            double hrizantemi = double.Parse(Console.ReadLine());
            double rozi = double.Parse(Console.ReadLine());
            double laleta = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine().ToLower();

            double priceHrizantemi = 0.0d;
            double priceRozi = 0.0d;
            double priceLaleta = 0.0d;
            double priceFlowers = 0.0d;
            double flowersAmount = hrizantemi + rozi + laleta;

            if (season == "spring" || season == "summer")
            {
                priceHrizantemi = hrizantemi * 2;
                priceRozi = rozi * 4.1;
                priceLaleta = laleta * 2.5;
                priceFlowers = priceHrizantemi + priceRozi + priceLaleta;
            }
            else if (season == "autumn" || season == "winter")
            {
                priceHrizantemi = hrizantemi * 3.75;
                priceRozi = rozi * 4.5;
                priceLaleta = laleta * 4.15;
                priceFlowers = priceHrizantemi + priceRozi + priceLaleta;
            }
            if (holiday == "y")
            {
                priceFlowers = priceFlowers + (priceFlowers * 0.15);
            }            
            if (laleta > 7 && season == "spring")
            {
                priceFlowers = priceFlowers - (priceFlowers * 0.05);
            }
            if (rozi >= 10 && season == "winter")
            {
                priceFlowers = priceFlowers - (priceFlowers * 0.1);
            }
            if (flowersAmount > 20)
            {
                priceFlowers = priceFlowers - (priceFlowers * 0.2);
            }

            Console.WriteLine("{0:f2}", priceFlowers + 2);


        }
    }
}
