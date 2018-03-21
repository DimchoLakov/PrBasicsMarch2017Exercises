using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double kilometeres = double.Parse(Console.ReadLine());
            double wages = 0.0d;
            double salary = 0.0d;
            if (season == "spring" || season == "autumn")
            {
                if (kilometeres > 0 && kilometeres <= 5000)
                {
                    wages = kilometeres *  0.75;
                }
                else if (kilometeres > 5000 && kilometeres <= 10000)
                {
                    wages = kilometeres * 0.95;
                }
                else
                {
                    wages = kilometeres * 1.45;
                }
            }
            else if (season == "summer")
            {
                if (kilometeres > 0 && kilometeres <= 5000)
                {
                    wages = kilometeres * 0.9;
                }
                else if (kilometeres > 5000 && kilometeres <= 10000)
                {
                    wages = kilometeres * 1.1;
                }
                else
                {
                    wages = kilometeres * 1.45;
                }
            }
            else if (season == "winter")
            {
                if (kilometeres > 0 && kilometeres <= 5000)
                {
                    wages = kilometeres * 1.05;
                }
                else if (kilometeres > 5000 && kilometeres <= 10000)
                {
                    wages = kilometeres * 1.25;
                }
                else
                {
                    wages = kilometeres * 1.45;
                }
            }
            salary = ((wages * 4) - (wages * 4) * 0.1);
            Console.WriteLine("{0:f2}", salary);
        }
    }
}
