using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBExam19March2017Evening
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            double grapeArea = double.Parse(Console.ReadLine());
            double kilosPerSqMeter = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double grape = grapeArea * kilosPerSqMeter;
            double totalGrape = grape - waste;
            double rakia = totalGrape * 0.45;
            double litersRakia = rakia / 7.5;
            double grapeSale = totalGrape * 0.55;

            double profitRakia = litersRakia * 9.8;
            double profitGrape = grapeSale * 1.5;

            Console.WriteLine($"{profitRakia:f2}");
            Console.WriteLine($"{profitGrape:f2}");

        }
    }
}
