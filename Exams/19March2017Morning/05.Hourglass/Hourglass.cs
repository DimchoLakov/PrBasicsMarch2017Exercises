using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hourglass
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            #region First Line
            Console.WriteLine(new string('*', 2 * n + 1));
            #endregion

            #region Second Line
            Console.WriteLine("." + "*" + new string(' ', 2 * n - 3) + "*" + ".");
            #endregion

            #region First Half


            for (int row = 0; row < n - 2; row++)
            {
                Console.Write(new string('.', row + 2) + "*");               
                Console.Write(new string('@', 2 * n - 1 - (2 * (row + 2))));
                Console.WriteLine("*" + new string('.', row + 2));
            }

            #endregion

            #region Middle Line
            Console.WriteLine(new string('.', n) + "*" + new string('.', n));
            #endregion

            #region Second Half

            for (int row = 0; row < n - 2; row++)
            {
                Console.WriteLine(new string('.', n - 1 - row) + "*" + new string(' ', row) + "@" + new string(' ', row) + "*" + new string('.', n - 1 - row));
            }

            #endregion

            #region Penultimate Line
            Console.WriteLine("." + "*" + new string('@', 2 * n - 3) + "*" + ".");
            #endregion

            #region Last Line
            Console.WriteLine(new string('*', 2 * n + 1));
            #endregion
        }
    }
}
