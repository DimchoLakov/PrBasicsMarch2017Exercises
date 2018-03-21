using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (double i = 0; i < n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());

                if (numbers < 200)
                {
                    p1 += 1;
                }
                else if (numbers >= 200 && numbers < 400)
                {
                    p2 += 1;
                }
                else if (numbers >= 400 && numbers < 600)
                {
                    p3 += 1;
                }
                else if (numbers >= 600 && numbers < 800)
                {
                    p4 += 1;
                }
                else if (numbers >= 800)
                {
                    p5 += 1;
                }
            }
            double percentP1 = (p1 / n) * 100;
            double percentP2 = (p2 / n) * 100;
            double percentP3 = (p3 / n) * 100;
            double percentP4 = (p4 / n) * 100;
            double percentP5 = (p5 / n) * 100;

            Console.WriteLine($"{percentP1:f2}%");
            Console.WriteLine($"{percentP2:f2}%");
            Console.WriteLine($"{percentP3:f2}%");
            Console.WriteLine($"{percentP4:f2}%");
            Console.WriteLine($"{percentP5:f2}%");
        }
    }
}
