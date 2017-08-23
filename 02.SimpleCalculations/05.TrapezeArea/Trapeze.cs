using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezeArea
{
    class Trapeze
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter base of trapeze:");
            double lengthOfBaseOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter side of trapeze:");
            double lengthOfBaseTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter height of trapeze:");
            double lengthOfHeight = double.Parse(Console.ReadLine());
            double areaOfTrapeze = (lengthOfBaseOne + lengthOfBaseTwo) * lengthOfHeight / 2;
            Console.WriteLine("The area of trapeze is:" + areaOfTrapeze);
        }
    }
}
