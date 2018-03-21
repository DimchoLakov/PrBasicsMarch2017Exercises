using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string road = Console.ReadLine().ToLower();
            int allPeople = juniors + seniors;
            double juniorsPrice = 0.0d;
            double seniorsPrice = 0.0d;

            if (road == "trail")
            {
                juniorsPrice = juniors * 5.5;
                seniorsPrice = seniors * 7;
            }
            else if (road == "cross-country")
            {
                juniorsPrice = juniors * 8;
                seniorsPrice = seniors * 9.5;
                if (allPeople >= 50)
                {
                    juniorsPrice = juniors * 8 - (juniors * 8 * 0.25);
                    seniorsPrice = seniors * 9.5 - (seniors * 9.5 * 0.25);
                }
            }
            else if (road == "downhill")
            {
                juniorsPrice = juniors * 12.25;
                seniorsPrice = seniors * 13.75;
            }
            else if (road == "road")
            {
                juniorsPrice = juniors * 20;
                seniorsPrice = seniors * 21.5;
            }
            double price = (juniorsPrice + seniorsPrice) - ((juniorsPrice + seniorsPrice) * 0.05);
            Console.WriteLine($"{price:f2}");
        }
    }
}
