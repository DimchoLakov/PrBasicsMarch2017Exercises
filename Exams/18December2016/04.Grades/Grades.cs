using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double between2And3 = 0.0d;
            double between3And4 = 0.0d;
            double between4And5 = 0.0d;
            double over5 = 0.0d;
            double grades = 0.0d;
            for (int i = 1; i <= students; i++)
            {
                double studentsGrades = double.Parse(Console.ReadLine());
                grades += studentsGrades;
                if (studentsGrades >= 2 && studentsGrades < 3)
                {
                    between2And3++;
                }
                else if (studentsGrades >= 3 && studentsGrades < 4)
                {
                    between3And4++;
                }
                else if (studentsGrades >= 4 && studentsGrades < 5)
                {
                    between4And5++;
                }
                else if (studentsGrades >= 5)
                {
                    over5++;
                }
            }
            double average = grades / students;
            double between2And3Percentage = (between2And3 / students) * 100.00;
            double between3And4Percentage = (between3And4 / students) * 100.00;
            double between4And5Percentage = (between4And5 / students) * 100.00;
            double over5Percentage = (over5 / students) * 100.00;
            Console.WriteLine($"Top students: {over5Percentage:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4And5Percentage:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3And4Percentage:f2}%");
            Console.WriteLine($"Fail: {between2And3Percentage:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
