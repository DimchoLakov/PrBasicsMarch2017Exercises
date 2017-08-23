using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimeters
{
    class InchToCent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter inches:");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine($"{inches} inches converted to centimeters {centimeters}");
        }
    }
}
