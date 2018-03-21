using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n + 1) + new string('_', 2 * n + 1) + new string('.', n + 1));
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('.', n - row) + "//" + new string('_', ((2 * n) - 1) + row * 2) + "\\\\" + new string('.', n - row));
            }
            Console.WriteLine("//" + new string('_', ((4 * n) - 6) / 2) + "STOP!" + new string('_', ((4 * n) - 6) / 2) + "\\\\");
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('.', row) + "\\\\" + new string('_', ((4 * n) - 1) - row * 2) + "//" + new string('.', row));
            }            
        }
    }
}
