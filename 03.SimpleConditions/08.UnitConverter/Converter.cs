using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.UnitConverter
{
    class Converter
    {
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            string inputUnits = Console.ReadLine().ToLower();
            string outputUnits = Console.ReadLine().ToLower();
            double intermediateMeters = 0.0d;

            #region Input
            if (inputUnits == "mm")
            {
                intermediateMeters = inputNumber / 1000;
            }
            else if (inputUnits == "cm")
            {
                intermediateMeters = inputNumber / 100;
            }
            else if (inputUnits == "mi")
            {
                intermediateMeters = inputNumber / 0.000621371192;
            }
            else if (inputUnits == "in")
            {
                intermediateMeters = inputNumber / 39.3700787;
            }
            else if (inputUnits == "km")
            {
                intermediateMeters = inputNumber / 0.001;
            }
            else if (inputUnits == "ft")
            {
                intermediateMeters = inputNumber / 3.2808399;
            }
            else if (inputUnits == "yd")
            {
                intermediateMeters = inputNumber / 1.0936133;
            }
            else if (inputUnits == "m")
            {
                intermediateMeters = inputNumber;
            }
            #endregion

            #region Output
            double finalMeters = 0.0d;

            if (outputUnits == "mm")
            {
                finalMeters = intermediateMeters * 1000;
            }
            else if (outputUnits == "cm")
            {
                finalMeters = intermediateMeters * 100;
            }
            else if (outputUnits == "mi")
            {
                finalMeters = intermediateMeters * 0.000621371192;
            }
            else if (outputUnits == "in")
            {
                finalMeters = intermediateMeters * 39.3700787;
            }
            else if (outputUnits == "km")
            {
                finalMeters = intermediateMeters * 0.001;
            }
            else if (outputUnits == "ft")
            {
                finalMeters = intermediateMeters * 3.2808399;
            }
            else if (outputUnits == "yd")
            {
                finalMeters = intermediateMeters * 1.0936133;
            }
            else if (outputUnits == "m")
            {
                finalMeters = intermediateMeters;
            }

            #endregion
            Console.WriteLine(finalMeters);
        }
    }
}
