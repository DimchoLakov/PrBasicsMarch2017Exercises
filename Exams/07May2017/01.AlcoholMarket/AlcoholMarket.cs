using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());            
            double beerLiters = double.Parse(Console.ReadLine());
            double wineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice = rakiaPrice - (rakiaPrice * 0.4);
            double beerPrice = rakiaPrice - (rakiaPrice * 0.8);

            double whiskeyQuantity = whiskeyPrice * whiskeyLiters;
            double rakiaQuantity = rakiaPrice * rakiaLiters;
            double wineQuantity = winePrice * wineLiters;
            double beerQuantity = beerPrice * beerLiters;
            double total = whiskeyQuantity + rakiaQuantity + wineQuantity + beerQuantity;
            Console.WriteLine($"{total:f2}");
        }
    }
}
