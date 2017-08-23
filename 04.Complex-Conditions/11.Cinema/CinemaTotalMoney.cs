using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class CinemaTotalMoney
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int totalSeats = rows * columns;
            double premiereProjection = totalSeats * 12;
            double normalProjection = totalSeats * 7.5;
            double discountProjection = totalSeats * 5;
            switch (projection)
            {
                case "premiere":
                    Console.WriteLine($"{premiereProjection:f2}");
                    break;
                case "normal":
                    Console.WriteLine($"{normalProjection:f2}");
                    break;
                case "discount":
                    Console.WriteLine($"{discountProjection:f2}");
                    break;              
            }
        }
    }
}
