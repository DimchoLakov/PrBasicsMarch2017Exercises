using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class Areas
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = squareSide * squareSide;
                Console.WriteLine(Math.Round(squareArea, 3));
            }
            else if (figure == "rectangle")
            {
                double rectangleSideA = double.Parse(Console.ReadLine());
                double rectangleSideB = double.Parse(Console.ReadLine());
                double rectnalgeArea = rectangleSideA * rectangleSideB;
                Console.WriteLine(Math.Round(rectnalgeArea, 3));
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * r * r;
                Console.WriteLine(Math.Round(circleArea, 3));
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double triangleArea = (a * h) / 2;
                Console.WriteLine(Math.Round(triangleArea, 3));
            }
        }
    }
}
