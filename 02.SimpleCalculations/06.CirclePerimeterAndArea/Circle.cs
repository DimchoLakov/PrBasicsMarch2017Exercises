using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class Circle
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Please enter radius of circle:");
              double radius = double.Parse(Console.ReadLine());
              double area = radius * radius * Math.PI;
              Console.WriteLine($"The area of circle is: {Math.Round(area, 2)}");
              double perimeter = 2 * Math.PI * radius;
              Console.WriteLine($"The perimeter of circle is:{Math.Round(perimeter, 3)}");
        }
    }
}
