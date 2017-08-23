using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace ThousandsDaysOnEarth
{
    class OneThousandDays
    {
        static void Main(string[] args)
        {
            string birthDate = Console.ReadLine();
            DateTime after1000Days = DateTime.ParseExact(birthDate, "dd-MM-yyyy", CultureInfo.InvariantCulture).AddDays(999);
            Console.WriteLine(after1000Days.ToString("dd-MM-yyyy"));
        }
    }
}
