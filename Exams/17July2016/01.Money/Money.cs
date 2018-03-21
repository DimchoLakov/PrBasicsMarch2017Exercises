using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Money
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine()) / 100;

            double oneBitcoin = 1168; //lv
            double oneYuan = 0.15; //usd
            double oneDollar = 1.76; //lv
            double oneEuro = 1.95; //lv
            double yuanToDollar = yuans * oneYuan;
            double dollarToLeva = yuanToDollar * oneDollar;
            double bitcoinsToLeva = bitcoins * oneBitcoin;
            double totalLeva = bitcoinsToLeva + dollarToLeva;
            double totalEuro = totalLeva / oneEuro;
            double money = totalEuro - (totalEuro * comission);
            Console.WriteLine(money);                       
        }
    }
}
