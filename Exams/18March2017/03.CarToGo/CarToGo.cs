using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string carClass = null;
            string carType = null;
            if (budget <= 100)
            {
                carClass = "Economy class";
                if (season == "summer")
                {
                    carType = "Cabrio";
                    budget = budget * 0.35;
                }
                else if (season == "winter")
                {
                    carType = "Jeep";
                    budget = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                if (season == "summer")
                {
                    carType = "Cabrio";
                    budget = budget * 0.45;
                }
                else if (season == "winter")
                {
                    carType = "Jeep";
                    budget = budget * 0.8;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                budget = budget * 0.9;
            }
            Console.WriteLine($"{carClass}\n{carType} - {budget:f2}");
        }
    }
}
