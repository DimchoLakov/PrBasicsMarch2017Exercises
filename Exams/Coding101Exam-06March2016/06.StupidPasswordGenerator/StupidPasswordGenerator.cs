using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());  
                      
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int symb = 97; symb < l + 97; symb++)
                    {
                        for (int symb2 = 97; symb2 < l + 97; symb2++)
                        {
                            for (int big = Math.Max(i, j) + 1; big <= n ; big++)
                            {
                                Console.Write($"{i}{j}{(char)symb}{(char)symb2}{big}" + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
