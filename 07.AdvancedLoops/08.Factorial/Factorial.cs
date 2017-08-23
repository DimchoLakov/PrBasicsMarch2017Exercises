using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 0 ; i < n; i++)
            {
                factorial += factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
