using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());
            double sectorA = 0.0d;
            double sectorB = 0.0d;
            double sectorV = 0.0d;
            double sectorG = 0.0d;
            double totalFansInSectors = 0.0d;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine().ToLower();
                totalFansInSectors += i;
                if (sector == "a")
                {
                    sectorA++;
                }
                else if (sector == "b")
                {
                    sectorB++;
                }
                else if (sector == "v")
                {
                    sectorV++;
                }
                else if (sector == "g")
                {
                    sectorG++;
                }
            }
            double sectorAPercentage = (sectorA / fans) * 100;
            double sectorBPercentage = (sectorB / fans) * 100;
            double sectorVPercentage = (sectorV / fans) * 100;
            double sectorGPercentage = (sectorG / fans) * 100;
            double fansPercentage = (fans / stadiumCapacity) * 100.0;
            Console.WriteLine($"{sectorAPercentage:f2}%");
            Console.WriteLine($"{sectorBPercentage:f2}%");
            Console.WriteLine($"{sectorVPercentage:f2}%");
            Console.WriteLine($"{sectorGPercentage:f2}%");
            Console.WriteLine($"{fansPercentage:f2}%");
        }
    }
}
