using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculations
{
    class AreaSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter length of square's side:");
            double sideOfSquare = double.Parse(Console.ReadLine());
            double areaOfSquare = sideOfSquare * sideOfSquare;
            Console.WriteLine("Area of square is:");
            Console.WriteLine(areaOfSquare);
        }
    }
}
