using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxCombinations
{
    class MaxCombinations
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinationsCounter++;
                    Console.Write($"<{i}-{j}>");
                    if (combinationsCounter == maxCombinations)
                    {
                        return;
                    }
                }
            }
        }
    }
}
