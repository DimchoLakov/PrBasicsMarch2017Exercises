using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Date
{
    class StringsConcatenate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter where are you from:");
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
