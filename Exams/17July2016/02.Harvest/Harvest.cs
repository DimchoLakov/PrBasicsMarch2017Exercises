using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            double vineyardSqMeters = double.Parse(Console.ReadLine());
            double grapePerSqMeter = double.Parse(Console.ReadLine());
            double neededLitersWine = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grapeAreaSqMeters = vineyardSqMeters * grapePerSqMeter;
            double grapeArea = grapeAreaSqMeters * 0.4;
            double wine = grapeArea / 2.5;
            double diff = Math.Abs(wine - neededLitersWine);
            double wineForPeople = diff / workers;
            if (wine < neededLitersWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }
            else if (wine >= neededLitersWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(wineForPeople)} liters per person.");
            }
        }
    }
}
