using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine()) * 60;
            int minuteExam = int.Parse(Console.ReadLine());
            int hourStudent = int.Parse(Console.ReadLine()) * 60;
            int minuteStudent = int.Parse(Console.ReadLine());

            int timeExam = hourExam + minuteExam;
            int arriveTime = hourStudent + minuteStudent;

            int diff = Math.Abs(arriveTime - timeExam);

            if (arriveTime <= timeExam)
            {
                if (diff == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (diff > 0 && diff <= 30)
                {
                    Console.WriteLine("on time {0} minutes before the start", diff);
                }
                else if (diff > 30 && diff <= 59)
                {
                    Console.WriteLine("early {0:00} minutes before the start", (diff % 60));
                }
                else
                {
                    Console.WriteLine("early {0}:{1:00} hours before the start", (diff / 60), (diff % 60));
                }
            }
            else if (arriveTime > timeExam)
            {
                if (diff > 0 && diff <= 59)
                {
                    Console.WriteLine($"late {diff % 60} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"late {diff / 60}:{diff % 60:00} hours after the start");
                }
            }
        }
    }
}
