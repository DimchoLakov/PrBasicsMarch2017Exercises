using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter length of triangle's side:");
            double sideOfTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter triangle's height:");
            double height = double.Parse(Console.ReadLine());
            double area = (sideOfTriangle * height) / 2 ;
            Console.WriteLine("Area = " + Math.Round(area, 2));
        }
    }
}
