using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Grape
{
    class GrapeProduction
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter area:");
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter grape per 1 square meter:");
            double grapePerSqMeter = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter wine needed:");
            int wineNeeded = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how many workers:");
            int workers = int.Parse(Console.ReadLine());
            double oneLiter = 2.5;
            double totalGrape = area * grapePerSqMeter;
            double totalWine = (totalGrape * 0.4) / oneLiter;
            double wineLeft = totalWine - wineNeeded;
            double wineForWorkers = wineLeft / workers;
            double wineNotEnough = wineNeeded - totalWine;
            if (totalWine >= wineNeeded)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineForWorkers)} liters per person.");
            }
            else if (totalWine < wineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNotEnough)} liters wine needed.");
            }
        }
    }
}
