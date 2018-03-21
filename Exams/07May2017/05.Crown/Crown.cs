using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Crown
{
    class Crown
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (2 * n) - 1;
            int height = (n / 2) + 4;

            #region First Two Lines

            Console.WriteLine("@" + new string(' ', (width - 3) / 2) + "@" + new string(' ', (width - 3) / 2) + "@");
            Console.WriteLine("**" + new string(' ', (width - 5) / 2) + "*" + new string(' ', (width - 5) / 2) + "**");

            #endregion

            #region Middle

            for (int row = 0; row < n / 2 - 2; row++)
            {
                Console.WriteLine("*" + new string('.', row + 1) + "*" + new string(' ',(width - 6 - 2 * (row + 1) - (row * 2 + 1)) / 2) + "*" + new string('.', row * 2 + 1) + "*" + new string(' ', (width - 6 - 2 * (row + 1) - (row * 2 + 1)) / 2) + "*" + new string('.', row + 1) + "*");
            }

            #endregion

            #region Last Four Lines
            Console.WriteLine("*" + new string('.', n / 2 - 1) + "*" + new string('.', width - 2 * (n / 2 - 1) - 4) + "*" + new string('.', n / 2 - 1) + "*");
            Console.WriteLine("*" + new string('.', n / 2) + new string('*', n / 2 - 2) + "." + new string('*', n / 2 - 2) + new string('.', n / 2) + "*");
            for (int row = 0; row < 2; row++)
            {
                Console.WriteLine(new string('*', width));
            }

            #endregion
        }
    }
}
