using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            #region First Half
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");
                for (int col = 0; col < row - 1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            #endregion

            #region Second Half

            for (int row = n - 1; row > 0; row--)
            {
                Console.Write(new string(' ', n - row));
                Console.Write('*');
                for (int i = 0; i < row - 1; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
