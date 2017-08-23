using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            #region First line
            Console.Write("+" + " ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-" + " ");
            }
            Console.WriteLine("+");            
            #endregion

            #region Middle

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|" + " ");
                for (int columns = 0; columns < n - 2; columns++)
                {
                    Console.Write("-" + " ");
                }
                Console.WriteLine("|");               
            }

            #endregion
           
            #region Last line
            Console.Write("+" + " ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-" + " ");
            }
            Console.WriteLine("+");
            #endregion


        }
    }
}
