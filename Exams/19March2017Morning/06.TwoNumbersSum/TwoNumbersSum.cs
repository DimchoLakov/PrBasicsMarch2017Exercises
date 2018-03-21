using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TwoNumbersSum
{
    class TwoNumbersSum
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            for (int i = start; i >= end; i--)
            {
                for (int k = start; k >= end; k--)
                {
                    combinations++;
                    if (i + k == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {k} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
