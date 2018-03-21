using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            int howManyMoves = int.Parse(Console.ReadLine());
            double movesCounter = 0.0d;
            double points = 0.0d;
            double from0To9 = 0.0d;
            double from10To19 = 0.0d;
            double from20To29 = 0.0d;
            double from30To39 = 0.0d;
            double from40To50 = 0.0d;
            double invalidNumbers = 0.0d;
            for (int i = 0; i < howManyMoves; i++)
            {
                int eachMove = int.Parse(Console.ReadLine());
                movesCounter++;
                if (eachMove >= 0 && eachMove <= 9)
                {
                    points += eachMove * 0.2;
                    from0To9++;
                }
                else if (eachMove > 9 && eachMove <= 19)
                {
                    points += eachMove * 0.3;
                    from10To19++;
                }
                else if (eachMove > 19 && eachMove <= 29)
                {
                    points += eachMove * 0.4;
                    from20To29++;
                }
                else if (eachMove > 29 && eachMove <= 39)
                {
                    points += 50;
                    from30To39++;
                }
                else if (eachMove > 39 && eachMove <= 50)
                {
                    points += 100;
                    from40To50++;
                }
                else
                {
                    points /= 2;
                    invalidNumbers++;
                }
            }
            double from0To9Percentage = (from0To9 / movesCounter) * 100;
            double from10To19Percentage = (from10To19 / movesCounter) * 100;
            double from20To29Percentage = (from20To29 / movesCounter) * 100;
            double from30To39Percentage = (from30To39 / movesCounter) * 100;
            double from40To50Percentage = (from40To50 / movesCounter) * 100;
            double invalidNumbersPercentage = (invalidNumbers / movesCounter) * 100;
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {from0To9Percentage:f2}%");
            Console.WriteLine($"From 10 to 19: {from10To19Percentage:f2}%");
            Console.WriteLine($"From 20 to 29: {from20To29Percentage:f2}%");
            Console.WriteLine($"From 30 to 39: {from30To39Percentage:f2}%");
            Console.WriteLine($"From 40 to 50: {from40To50Percentage:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbersPercentage:f2}%");
        }
    }
}
