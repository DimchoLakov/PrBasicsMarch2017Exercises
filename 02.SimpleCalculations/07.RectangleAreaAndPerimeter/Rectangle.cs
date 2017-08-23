using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAreaAndPerimeter
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value for x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for y1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for y2");
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Abs(x1 - x2);
            double length = Math.Abs(y1 - y2);
            double area = width * length;
            double perimeter = 2 * (width + length);
            // Math.Round rounds to a certain number after floating point
            Console.WriteLine("Area = " + Math.Round(area, 2));
            //"{0:f5}, var" rounds the first {0} variable to fifth number after floating point
            Console.WriteLine("Perimeter {0:f2}", Math.Round(perimeter, 2));
        }
    }
}
