using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            #region First Line


            if (n % 2 == 1)
            {
                if (n != 1)
                {
                    Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
                }
                else
                {
                    Console.WriteLine(new string('*', n));
                }
            }
            #endregion


            #region First Half + Second Half
            if (n % 2 == 0)
            {
                for (int row = 0; row < n / 2; row++)
                {
                    Console.WriteLine(new string('-', n / 2 - 1 - row) + "*" + new string('-', 2 * row) + "*" + new string('-', n / 2 - 1 - row));
                }
                for (int row = 0; row < n / 2 - 1; row++)
                {
                    Console.WriteLine(new string('-', 1 + row) + "*" + new string('-', n - 2 * (1 + row) - 2) + "*" + new string('-', 1 + row));
                }
            }
            else if (n % 2 == 1)
            {
                for (int row = 0; row < n / 2; row++)
                {
                    Console.WriteLine(new string('-', n / 2 - 1 - row) + "*" + new string('-', 1 + 2 * row) + "*" + new string('-', n / 2 - 1 - row));
                }
                for (int row = 0; row < n / 2 - 1; row++)
                {
                    Console.WriteLine(new string('-', 1 + row) + "*" + new string('-', n - 2 * (1 + row) - 2) + "*" + new string('-', 1 + row));
                }
            }
            #endregion

            #region Last Line       

            if (n % 2 == 1)
            {
                if (n != 1)
                {
                    Console.WriteLine(new string('-', n / 2) + "*" + new string('-', n / 2));
                }
            }
            #endregion
        }
    }
}
