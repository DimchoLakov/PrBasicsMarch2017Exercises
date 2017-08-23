using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorUSDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            //Makes the background color Yellow
            Console.ForegroundColor = ConsoleColor.Green;
            //Makes all the symbols Green
            
            Console.Write("USD=");
            decimal usd = decimal.Parse(Console.ReadLine());
            usd = usd * 1.79549m;     
            Console.WriteLine("BGN=" + Math.Round(usd, 2));

            // Console.WriteLine("{0:f2}, usd"); <--- another option available which will print the same result.
            Console.ResetColor();
            //Console.ResetColor() -> resets the color for the last line of Console "Press any key to continue"
        }
    }
}
