using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{number}" + " ");
                    number++;
                    if (number > n)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();                
            }
        }
    }
}
