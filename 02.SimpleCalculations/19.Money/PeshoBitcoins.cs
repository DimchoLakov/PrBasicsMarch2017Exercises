using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Money
{
    class PeshoBitcoins
    {
        static void Main(string[] args)
        {
            int bitcoinsAmount = int.Parse(Console.ReadLine());
            double yuanAmount = double.Parse(Console.ReadLine());
            double commisionAmount = double.Parse(Console.ReadLine());

            double bitcoinsToLeva = bitcoinsAmount * 1168; // 1 bitcoin = 1168 lev
            double yuanToDollar = yuanAmount * 0.15; // 1 yuan = 0.15 dollar
            double yuanToLeva = yuanToDollar * 1.76; // 1 yuan = 0.15 * 1.76 = 0.264 lev

            double totalLeva = bitcoinsToLeva + yuanToLeva; 
            double euros = totalLeva / 1.95;
            double commision = commisionAmount / 100;
            Console.WriteLine(euros - (euros * commision));
                       
        }
    }
}
