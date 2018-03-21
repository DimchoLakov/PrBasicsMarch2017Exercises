using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = (4 * n) + 4;
            int width = (3 * n) + 1;
            int heightWithoutFirstAndLastRows = height - 3 - (n * 2);            

            #region First line
            Console.WriteLine("+" + new string('~', n - 2) + "+" + new string('.', width - n));            
            #endregion

            #region First half            
            for (int row = 0; row < heightWithoutFirstAndLastRows; row++)
            {
                Console.Write("|");
                for (int i = 0; i < row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("\\" + new string('~', n - 2) + "\\");
                for (int i = heightWithoutFirstAndLastRows; i > row + 1 ; i--)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }

            #endregion

            #region Second half

            for (int row = 0; row < heightWithoutFirstAndLastRows; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write(".");
                }
                Console.Write("\\");
                for (int i = heightWithoutFirstAndLastRows; i > row + 1; i--)
                {
                    Console.Write(".");
                }
                Console.WriteLine("|" + new string('~', n - 2) + "|");                
            }

            #endregion

            #region Last line
            Console.WriteLine(new string('.', width - n) + "+" + new string('~', n - 2) + "+");
            #endregion
        }
    }
}
