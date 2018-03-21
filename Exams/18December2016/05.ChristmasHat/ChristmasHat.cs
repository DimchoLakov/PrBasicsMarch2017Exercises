using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;
            int heigth = 2 * n + 5;

            Console.WriteLine(new string('.', (width - 3) / 2) + "/" + "|" + "\\" + new string('.', (width - 3) / 2));
            Console.WriteLine(new string('.', (width - 3) / 2) + "\\" + "|" + "/" + new string('.', (width - 3) / 2));
            for (int row = 0; row < 2 * n; row++)
            {
                Console.WriteLine(new string('.', (width - 3) / 2 - row) + "*" + new string('-', row) + "*" + new string('-', row) + "*" + new string('.', (width - 3) / 2 - row));
            }
            Console.WriteLine(new string('*', width));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', width));
        }
    }
}
