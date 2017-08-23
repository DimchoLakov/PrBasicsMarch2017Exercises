using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Company
{
    class CompanyProject
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());
            int workersOvertime = int.Parse(Console.ReadLine());

            double workingHours = Math.Floor((daysAvailable - (daysAvailable * 0.1)) * 8);
            double overtimeHours =  workersOvertime * 2 * daysAvailable;
            double totalWorkingHours = workingHours + overtimeHours;

            if (totalWorkingHours >= hoursNeeded)
            {
                double leftHours = totalWorkingHours - hoursNeeded;
                Console.WriteLine("Yes!{0} hours left.", leftHours);
            }
            else if (totalWorkingHours < hoursNeeded)
            {
                double notEnoughHours = hoursNeeded - totalWorkingHours;
                Console.WriteLine($"Not enough time!{notEnoughHours} hours needed.");
            }            
        }
    }
}
