using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int periodOfTime = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            for (int days = 1; days <= periodOfTime; days++)
            {
                if (days % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }
                int patients = int.Parse(Console.ReadLine());
                if (patients >= doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatients += patients - doctors;
                }
                else
                {
                    treatedPatients += patients;
                }                
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
