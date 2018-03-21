using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string destination = null;
            string holidayType = null;

            if (budget > 0 && budget <= 100)
            {
                if (season == "summer")
                {
                    budget = budget * 0.3;
                    destination = "Bulgaria";
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    budget = budget * 0.7;
                    destination = "Bulgaria";
                    holidayType = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    budget = budget * 0.4;
                    destination = "Balkans";
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    budget = budget * 0.8;
                    destination = "Balkans";
                    holidayType = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                budget = budget * 0.9;
                destination = "Europe";
                holidayType = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}\n{holidayType} - {budget:f2}");
        }
    }
}
