using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DogHouse
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            double lengthA = double.Parse(Console.ReadLine());
            double heightB = double.Parse(Console.ReadLine());
            double rectangles = (lengthA * (lengthA / 2)) * 2;
            double backSide = ((lengthA / 2) * (lengthA / 2)) + (lengthA / 2) * ((heightB - (lengthA / 2)) / 2);
            double frondSide = backSide - ((lengthA / 5) * (lengthA / 5));
            double roof = (lengthA * (lengthA / 2)) * 2;
            double greenPaint = (rectangles + backSide + frondSide) / 3;
            double redPaint = roof / 5;
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
