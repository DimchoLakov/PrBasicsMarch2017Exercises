using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());
            double vip = 499.99;
            double normal = 249.99;

            if (people >= 1 && people <= 4)
            {
                budget -= budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                budget -= budget * 0.6;
            }
            else if (people >= 10 && people <= 24)
            {
                budget -= budget * 0.5;
            }
            else if (people >= 25 && people <= 49)
            {
                budget -= budget * 0.4;
            }
            else if (people >= 50)
            {
                budget -= budget * 0.25;
            }
            double ticketPriceVip = vip * people;
            double ticketPriceNormal = normal * people;
            double diffVip = Math.Abs(budget - ticketPriceVip);
            double diffNormal = Math.Abs(budget - ticketPriceNormal);
            if (category == "vip")
            {
                if (budget >= ticketPriceVip)
                {
                    Console.WriteLine($"Yes! You have {diffVip:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {diffVip:f2} leva.");
                }
            }
            else if (category == "normal")
            {
                if (budget >= ticketPriceNormal)
                {
                    Console.WriteLine($"Yes! You have {diffNormal:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {diffNormal:f2} leva.");
                }
            }
        }
    }
}
