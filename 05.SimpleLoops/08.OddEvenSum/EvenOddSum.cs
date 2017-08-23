using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class EvenOddSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += numbers;
                }
                else
                {
                    oddSum += numbers;
                }
            }
            int difference = Math.Abs(evenSum - oddSum);
            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes \nSum = {oddSum}");
            }
            else
            {
                Console.WriteLine($"No \nDiff = {difference}");
            }
        }
    }
}
