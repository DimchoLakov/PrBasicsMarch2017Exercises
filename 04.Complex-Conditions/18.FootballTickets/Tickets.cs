using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.FootballTickets
{
    class Tickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());            
            double transportMoney = 0.0d;                        
            double ticketPriceVip = people * 499.99;
            double ticketPriceNormal = people * 249.99;
            
            switch (category)
            {
                case "vip":
                    if (people >= 1 && people <= 4)
                    {
                        transportMoney = budget * 0.75;
                        double moneyLeft = budget - transportMoney;
                        if (moneyLeft < ticketPriceVip)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketPriceVip));
                        }
                        else
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(moneyLeft - ticketPriceVip));
                        }
                    }
                    else if (people > 4 && people <= 9)
                    {
                        transportMoney = budget * 0.6;
                        double moneyLeft = budget - transportMoney;
                        if (moneyLeft < ticketPriceVip)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketPriceVip));
                        }
                        else
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(moneyLeft - ticketPriceVip));
                        }
                    }
                    else if (people > 9 && people <= 24)
                    {
                        transportMoney = budget * 0.5;
                        double moneyLeft = budget - transportMoney;
                        if (moneyLeft < ticketPriceVip)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketPriceVip));
                        }
                        else
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(moneyLeft - ticketPriceVip));
                        }
                    }
                    else if (people > 24 && people <= 49)
                    {
                        transportMoney = budget * 0.4;
                        double moneyLeft = budget - transportMoney;
                        if (moneyLeft < ticketPriceVip)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketPriceVip));
                        }
                        else
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(moneyLeft - ticketPriceVip));
                        }
                    }
                    else if (people > 49)
                    {
                        transportMoney = budget * 0.25;
                        double moneyLeft = budget - transportMoney;
                        if (moneyLeft < ticketPriceVip)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketPriceVip));
                        }
                        else
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(moneyLeft - ticketPriceVip));
                        }
                    }
                    break;
                case "normal":
                    if (people >= 1 && people <= 4)
                    {
                        transportMoney = budget * 0.75;
                        double moneyLeft = budget - transportMoney;
                        if (moneyLeft < ticketPriceNormal)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketPriceNormal));
                        }
                        else
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(moneyLeft - ticketPriceNormal));
                        }
                    }
                    else if (people > 4 && people <= 9)
                    {
                        transportMoney = budget * 0.6;
                        double moneyLeft = budget - transportMoney;
                        if (moneyLeft < ticketPriceNormal)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketPriceNormal));
                        }
                        else
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(moneyLeft - ticketPriceNormal));
                        }
                    }
                    else if (people > 9 && people <= 24)
                    {
                        transportMoney = budget * 0.5;
                        double moneyLeft = budget - transportMoney;
                        if (moneyLeft < ticketPriceNormal)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketPriceNormal));
                        }
                        else
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(moneyLeft - ticketPriceNormal));
                        }
                    }
                    else if (people > 24 && people <= 49)
                    {
                        transportMoney = budget * 0.4;
                        double moneyLeft = budget - transportMoney;
                        if (moneyLeft < ticketPriceNormal)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketPriceNormal));
                        }
                        else
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(moneyLeft - ticketPriceNormal));
                        }
                    }
                    else if (people > 49)
                    {
                        transportMoney = budget * 0.25;
                        double moneyLeft = budget - transportMoney;
                        if (moneyLeft < ticketPriceNormal)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyLeft - ticketPriceNormal));
                        }
                        else
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(moneyLeft - ticketPriceNormal));
                        }
                    }
                    break;                
            }
        }
    }
}
