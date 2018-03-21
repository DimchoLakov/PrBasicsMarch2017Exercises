using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ControlNumber
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int moves = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int k = m; k >= 1; k--)
                {                  
                    moves++;
                    sum += 2 * i + 3 * k;
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{moves} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        return;
                    }                    
                }                
            }
            Console.WriteLine($"{moves} moves");
        }
    }
}
