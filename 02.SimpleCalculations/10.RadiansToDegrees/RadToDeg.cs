using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class RadToDeg
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter radians:");
            double radians = double.Parse(Console.ReadLine()); 
            double degrees = (radians * 180) / Math.PI;
            Console.WriteLine("Degrees:" + Math.Round(degrees, MidpointRounding.ToEven));
        }
    }
}
