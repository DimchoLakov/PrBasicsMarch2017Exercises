using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TransportPrice
{
    class TaxiBusOrTrain
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine().ToLower();
            double taxiInitialPrice = 0.7d;
            double busPrice = 0.09d;
            double trainPrice = 0.06d;

            double lowestPrice = 0.0;
            if (dayOrNight == "day")
            {
                if (kilometers > 0 && kilometers < 20)
                {
                    lowestPrice = taxiInitialPrice + (kilometers * 0.79);
                }
                else if (kilometers >= 20 && kilometers < 100)
                {
                    lowestPrice = kilometers * busPrice;
                }
                else if (kilometers >= 100)
                {
                    lowestPrice = kilometers * trainPrice;
                }
            }
            else if (dayOrNight == "night")
            {
                if (kilometers > 0 && kilometers < 20)
                {
                    lowestPrice = taxiInitialPrice + (kilometers * 0.9);
                }
                else if (kilometers >= 20 && kilometers < 100)
                {
                    lowestPrice = kilometers * busPrice;
                }
                else if (kilometers >= 100)
                {
                    lowestPrice = kilometers * trainPrice;
                }
            }
            Console.WriteLine(lowestPrice);
        }
    }
}
