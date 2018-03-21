using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    p1++;
                }
                if (currentNumber % 3 == 0)
                {
                    p2++;
                }
                if (currentNumber % 4 == 0)
                {
                    p3++;
                }
            }
            double percentageOne = p1 / n * 100;
            double percentageTwo = p2 / n * 100;
            double percentageThree = p3 / n * 100;
            Console.WriteLine($"{percentageOne:f2}%\n{percentageTwo:f2}%\n{percentageThree:f2}%");
        }
    }
}
