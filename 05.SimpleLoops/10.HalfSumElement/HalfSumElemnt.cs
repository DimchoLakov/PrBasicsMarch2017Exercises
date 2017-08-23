using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class HalfSumElemnt
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNumber)
                {
                    if (maxNumber != int.MinValue)
                    {
                        sum += maxNumber;
                    } 
                    maxNumber = currentNumber;                    
                }
                else
                {
                    sum += currentNumber;
                }
            }
            int sumOthers = Math.Abs(maxNumber - sum);
            if (sum == maxNumber)
            {
                Console.WriteLine($"Yes \nSum = {maxNumber}");
            }
            else
            {
                Console.WriteLine($"No \nDiff = {sumOthers}");
            }
        }
    }
}
