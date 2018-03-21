using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('-', 3 * n) + "*" + new string('-', row) + "*" + new string('-', 2 * n - row - 2));
            }
            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine(new string('*', 3 * n + 1) + new string('-', n - 1) + "*" + new string('-', n - 1));
            }
            for (int row = 0; row < n / 2; row++)
            {
                if (row ==  n / 2 - 1)
                {
                    Console.WriteLine(new string('-', 3 * n - row ) + "*" + new string('*', n - 1 + row * 2) + "*" + new string('-', n - 1 - row));
                }
                else
                {
                    Console.WriteLine(new string('-', 3 * n - row) + "*" + new string('-', n - 1 + row * 2) + "*" + new string('-', n - 1 - row));
                }
            }
        }
    }
}
