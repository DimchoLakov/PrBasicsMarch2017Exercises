using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = 2 * (n - 2) + 1;
            int leftRightWing = n - 1;

            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine(new string('-', leftRightWing - 1) + "\\" + " " + "/" + new string('-', leftRightWing - 1));
                }
                else
                {
                    Console.WriteLine(new string('*', leftRightWing - 1) + "\\" + " " + "/" + new string('*', leftRightWing - 1));
                }
            }
            Console.WriteLine(new string(' ', leftRightWing) + "@" + new string(' ', leftRightWing));
            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.WriteLine(new string('-', leftRightWing - 1) + "/" + " " + "\\" + new string('-', leftRightWing - 1));
                }
                else
                {
                    Console.WriteLine(new string('*', leftRightWing - 1) + "/" + " " + "\\" + new string('*', leftRightWing - 1));
                }
            }
        }
    }
}
