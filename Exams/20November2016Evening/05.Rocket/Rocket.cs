using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            #region First Half
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('.', (3 * n) / 2 - 1 - row) + "/" + new string(' ', row * 2) + "\\" + new string('.', (3 * n) / 2 - 1 - row));
            }
            #endregion
            #region Single Line
            Console.WriteLine(new string('.', n / 2) + new string('*', 2 * n) + new string('.', n / 2));
            #endregion
            #region Middle
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine(new string('.', n / 2) + "|" + new string('\\', 2 * n - 2) + "|" + new string('.', n / 2));
            }
            #endregion
            #region Last Lines
            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine(new string('.', n / 2 - row) + "/" + new string('*', 2 * n - 2 + row * 2) + "\\" + new string('.', n / 2 - row));
            }
            #endregion
        }
    }
}
