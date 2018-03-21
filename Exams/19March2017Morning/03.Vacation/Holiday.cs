using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Holiday
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
                        
            double price = budget;

            if (season == "summer")
            {
                if (budget <= 1000)
                {
                    price = budget * 0.65;
                    Console.WriteLine("Alaska - Camp - {0:f2}", price);
                }
                else if (budget > 1000 && budget <= 3000)
                {
                    price = budget * 0.8;
                    Console.WriteLine("Alaska - Hut - {0:f2}", price);
                }
                else if (budget > 3000)
                {
                    price = budget * 0.9;
                    Console.WriteLine("Alaska - Hotel - {0:f2}", price);
                }
            }
            else if (season == "winter")
            {
                if (budget <= 1000)
                {
                    price = budget * 0.45;
                    Console.WriteLine("Morocco - Camp - {0:f2}", price);
                }
                else if (budget > 1000 && budget <= 3000)
                {
                    price = budget * 0.6;
                    Console.WriteLine("Morocco - Hut - {0:f2}", price);
                }
                else if (budget > 3000)
                {
                    price = budget * 0.9;
                    Console.WriteLine("Morocco - Hotel - {0:f2}", price);
                }
            }
        }
    }
}
