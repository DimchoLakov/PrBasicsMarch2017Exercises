using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrainingLab
{
    class SeatsInClassRoom
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double h = length * 100;
            double w = (width * 100) - 100;
            double rows = (int)(h / 120);
            double tables = (int)(w / 70);
            double seats = (rows * tables) - 3;
            Console.WriteLine(seats);
        }
    }
}
