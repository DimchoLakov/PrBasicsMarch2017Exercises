using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (5 * n);
            int height = ((3 * n) + 2);

            #region First Half            
            for (int row = 0; row < n; row++)
            {
                if (row == 0)
                {
                    Console.WriteLine(new string('.', n - row) + new string('*', width - (2 * (n - row))) + new string('.', n - row));
                }
                else
                {
                    Console.WriteLine(new string('.', n - row) + "*" + new string('.', width - (2 * (n - row)) - 2) + "*" + new string('.', n - row));
                }
            }
            #endregion

            #region Middle Line
            Console.WriteLine(new string('*', width));
            #endregion

            #region Second Half

            for (int row = 1; row <= height - 1 - n; row++)
            {
                if (row >= 1 && row < height - 1 - n)
                {
                    Console.WriteLine(new string('.', row) + "*" + new string('.', width - 2 * row - 2) + "*" + new string('.', row));
                }
                else
                {
                    Console.WriteLine(new string('.', row) + "*" + new string('*', width - 2 * row - 2) + "*" + new string('.', row));
                }
            }

            #endregion
        }
    }
}
