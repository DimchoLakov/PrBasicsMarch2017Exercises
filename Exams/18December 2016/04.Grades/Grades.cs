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
            double students = double.Parse(Console.ReadLine());
            double groupOne = 0.0d;
            double groupTwo = 0.0d;
            double groupThree = 0.0d;
            double groupFour = 0.0d;
            double sumGrades = 0.0d;
            double average = 0.0d;

            for (int i = 0; i < students; i++)
            {
                double studentGrades = double.Parse(Console.ReadLine());

                sumGrades += studentGrades;

                if (studentGrades >= 2 && studentGrades <3)
                {
                    groupOne++;
                }
                else if (studentGrades >= 3 && studentGrades < 4)
                {
                    groupTwo++;
                }
                else if (studentGrades >= 4 && studentGrades < 5)
                {
                    groupThree++;
                }
                else if (studentGrades >= 5)
                {
                    groupFour++;
                }
            }
            double topStudents = (groupFour / students) * 100;
            double between4And5 = (groupThree / students) * 100;
            double between3And4 = (groupTwo / students) * 100;
            double fail = (groupOne / students) * 100;
            average = sumGrades / students;

            Console.WriteLine($"Top students: {topStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4And5:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3And4:f2}%");
            Console.WriteLine($"Fail: {fail:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
