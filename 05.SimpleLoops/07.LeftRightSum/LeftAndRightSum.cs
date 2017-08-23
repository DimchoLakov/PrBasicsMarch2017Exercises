using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < 2 * n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    leftSum += numbers;
                }
                else
                {
                    rightSum += numbers;
                }
            }
            int difference = Math.Abs(leftSum - rightSum);
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
