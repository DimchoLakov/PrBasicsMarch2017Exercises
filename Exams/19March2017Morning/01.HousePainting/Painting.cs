using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam19March2017Morning
{
    class Painting
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double frontDoor = 1.2 * 2;
            double sideWindows = 1.5 * 1.5 * 2;
            double backWall = x * x;
            double frontWall = (x * x) - frontDoor;
            double sideWalls = (2 * x * y) - sideWindows;
            double houseArea = backWall + frontWall + sideWalls;
            double roofSides = 2 * x * y;
            double roofTriangles = 2 * ((x * h) / 2);
            double roofArea = roofSides + roofTriangles;
            double greenPaint = houseArea / 3.4;
            double redPaint = roofArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
