using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinationsCounter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationsCounter} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicNumber}");
        }
    }
}
