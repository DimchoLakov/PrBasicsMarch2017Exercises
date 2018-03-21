using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LettersCombination
{
    class LettersCombination
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char stopLetter = char.Parse(Console.ReadLine());
            int combinationCounter = 0;
            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        if (i != stopLetter && j != stopLetter && k != stopLetter)
                        {
                            Console.Write($"{i}{j}{k} ");
                            combinationCounter++;
                        }
                    }
                }
            }
            Console.WriteLine(combinationCounter);
        }
    }
}
