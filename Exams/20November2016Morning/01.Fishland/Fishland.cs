using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            double skumriqPricePerKilo = double.Parse(Console.ReadLine());
            double cacaPricePerKilo = double.Parse(Console.ReadLine());
            double palamudKilos = double.Parse(Console.ReadLine());
            double safridKilos = double.Parse(Console.ReadLine());
            int midiKilos = int.Parse(Console.ReadLine());

            double palamudPrice = (skumriqPricePerKilo + skumriqPricePerKilo * 0.6) * palamudKilos;
            double safridPrice = (cacaPricePerKilo + cacaPricePerKilo * 0.8) * safridKilos;
            double midiPrice = midiKilos * 7.5;
            double finalPrice = palamudPrice + safridPrice + midiPrice;
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
