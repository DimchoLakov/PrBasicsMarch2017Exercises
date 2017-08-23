using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyballl
{
    class Program
    {
        static void Main(string[] args)
        {
            string leapOrNormalYear = Console.ReadLine().ToLower();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsHome = int.Parse(Console.ReadLine());

            double weekendsInSofia = (48 - weekendsHome) * 0.75; // 48 уикенда в годината - уикендите в родния град * 3/4 от уикендите,когато не е на работа
            double holidaysInSofia = (holidays * 2) / 3.0; // 2/3 от празничните дни в София
            double totalPlay = weekendsInSofia + holidaysInSofia + weekendsHome;
            if (leapOrNormalYear == "leap")
            {
                double leapYearPlay = totalPlay + (totalPlay * 0.15);
                Console.WriteLine($"{Math.Floor(leapYearPlay)}");
            }
            else if (leapOrNormalYear == "normal")
            {
                Console.WriteLine($"{Math.Floor(totalPlay)}");
            }
            
        }
    }
}
