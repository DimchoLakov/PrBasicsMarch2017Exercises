using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RectangleNxNStars
{
    class RectangleNxNStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
