using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = ((4 * n) - 2);
            int width = ((12 * n) - 5);
            #region First Half
            for (int row = 0; row < 2 * n; row++)
            {
                Console.WriteLine(new string('.', (width - (row * 6)) / 2) +  new string('#', 1 + row * 6) + new string('.', (width - (row * 6)) / 2));
            }
            #endregion

            #region Middle
            for (int row = 0; row < n - 2; row++)
            {
                Console.WriteLine("|" + new string('.', row * 3 + 2) + new string('#', width - 6 - row * 6) + new string('.', row * 3 + 3));
            }
            #endregion

            #region Last Half
            for (int row = 1; row <= n - 1; row++)
            {
                Console.WriteLine("|" + new string('.', (width - (n * 6 + 1)) / 2 - 1) + new string('#', n * 6 + 1) + new string('.', (width - (n * 6 + 1)) / 2));
                if (row == n - 1)
                {
                    Console.WriteLine("@" + new string('.', (width - (n * 6 + 1)) / 2 - 1) + new string('#', n * 6 + 1) + new string('.', (width - (n * 6 + 1)) / 2));
                }
            }
            #endregion
        }
    }
}
