using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int suppliedFood = int.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            double catFoodKg = double.Parse(Console.ReadLine());
            double turtleFoodKg = double.Parse(Console.ReadLine()) / 1000;

            double eatenFood = dogFoodKg * days + catFoodKg * days + turtleFoodKg * days;
            double diff = Math.Abs(eatenFood - suppliedFood);
            if (eatenFood <= suppliedFood)
            {
                Console.WriteLine($"{Math.Floor(diff)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(diff)} more kilos of food are needed.");
            }
        }
    }
}
