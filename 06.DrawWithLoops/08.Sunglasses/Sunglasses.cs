using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            #region Top Line     
                    
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

            #endregion


            #region Middle

            for (int row = 1; row <= n - 2; row++)
            {
                if (row == (n - 1) / 2)
                {
                    Console.Write("*");
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write("*");
                    Console.Write(new string('|', n));
                    Console.Write("*");
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', (2 * n) - 2));
                    Console.Write("*");
                    Console.WriteLine();
                }
                
            }
            #endregion


            #region Bot Line

            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

            #endregion
        }
    }
}
