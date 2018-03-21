using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LetterCombinations
{
    class LetterCombinations
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char avoidLetter = char.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i != avoidLetter && j != avoidLetter && k != avoidLetter)
                        {
                            Console.Write($"{i}{j}{k} ");
                            combinationsCounter++;
                        }
                    }
                }
            }
            Console.WriteLine(combinationsCounter);
        }
    }
}
