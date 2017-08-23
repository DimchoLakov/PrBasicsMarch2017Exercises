using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class CitiesProducts
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quatity = double.Parse(Console.ReadLine());
            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quatity * 0.5);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quatity * 0.4);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(quatity * 0.45);
                }
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quatity * 0.8);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quatity * 0.7);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(quatity * 0.7);
                }
            }
            else if (product == "beer")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quatity * 1.2);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quatity * 1.15);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(quatity * 1.1);
                }
            }
            else if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quatity * 1.45);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quatity * 1.3);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(quatity * 1.35);
                }
            }
            else if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quatity * 1.6);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quatity * 1.5);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(quatity * 1.55);
                }
            }
        }
    }
}
