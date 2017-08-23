using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter degrees:");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = ((((celsius * 9)/5)+32));
            Console.WriteLine("Fahrenheit:" + Math.Round(fahrenheit, 2));
        }
    }
}
