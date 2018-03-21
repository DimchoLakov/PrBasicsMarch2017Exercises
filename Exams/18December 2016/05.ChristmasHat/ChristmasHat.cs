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
            #region First Line
            Console.WriteLine(new string('.', 2 * n - 1) + "/" + "|" + "\\" + new string('.', 2 * n - 1));
            #endregion
            #region Second Line
            Console.WriteLine(new string('.', 2 * n - 1) + "\\" + "|" + "/" + new string('.', 2 * n - 1));
            #endregion
            #region Middle
            for (int row = 0; row < 2 * n ; row++)
            {
                Console.WriteLine(new string('.', 2 * n - 1 - row) + "*" + new string('-', row) + "*" + new string('-', row) + "*" + new string('.', 2 * n - 1 - row));
            }
            #endregion
            #region Last Three Lines
            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', 4 * n + 1));
            #endregion
        }
    }
}
