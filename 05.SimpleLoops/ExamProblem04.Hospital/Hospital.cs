using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProblem04.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());            
            int treated = 0;
            int untreated = 0;
            int doctors = 7;

            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (untreated > treated)
                    {
                        doctors++;
                    }
                    if (patients >= doctors)
                    {
                        treated += doctors;
                        untreated = untreated + (patients - doctors);
                    }
                    else
                    {
                        treated += patients;
                    }
                }
                else
                {
                    if (patients >= doctors)
                    {
                        treated += doctors;
                        untreated = untreated + (patients - doctors);
                    }
                    else
                    {
                        treated += patients;
                   }
                }
                
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
