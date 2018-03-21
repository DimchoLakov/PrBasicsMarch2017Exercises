using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int elderPeople = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int night = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine().ToLower();
            int allPeople = elderPeople + students;
            double priceElderPeople = 0.0d;
            double priceStudents = 0.0d;
            if (transport == "train")
            {
                priceElderPeople = elderPeople * 24.99;
                priceStudents = students * 14.99;
                if (allPeople >= 50)
                {
                    priceElderPeople = (elderPeople * 24.99) - ((elderPeople * 24.99) * 0.5);
                    priceStudents = (students * 14.99) - (students * 14.99 * 0.5);
                }
            }
            else if (transport == "bus")
            {
                priceElderPeople = elderPeople * 32.5;
                priceStudents = students * 28.5;
            }
            else if (transport == "boat")
            {
                priceElderPeople = elderPeople * 42.99;
                priceStudents = students * 39.99;
            }
            else if (transport == "airplane")
            {
                priceElderPeople = elderPeople * 70.0;
                priceStudents = students * 50.0;
            }
            double hotel = night * 82.99;
            double totalPrice = (hotel + ((priceStudents + priceElderPeople) * 2)) + ((hotel + ((priceStudents + priceElderPeople) * 2)) * 0.1);
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
