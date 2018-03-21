using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (2 * n + 3);
            #region First Half
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('*', row + 1) + "\\" + new string('-', width - 2 - (2 * (row + 1))) + "/" +new string('*', row + 1));
            }
            #endregion

            #region Middle
            for (int row = 0; row < n / 3; row++)
            {
                Console.WriteLine("|" + new string('*', n / 2 + row) + "\\" + new string('*', width - 4 - 2 *(n / 2) - 2 * row) + "/" + new string('*', n / 2 + row) + "|");
            }
            #endregion

            #region Last Half
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('-', row + 1) + "\\" + new string('*', width - 2 - (2 * (row + 1))) + "/" + new string('-', row + 1));
            }
            #endregion
        }
    }
}
