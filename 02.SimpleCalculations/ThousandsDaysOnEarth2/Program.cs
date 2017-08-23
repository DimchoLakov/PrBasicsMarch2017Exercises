using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Трябва да се добави колекция - “using System.Globalization;“
using System.Globalization;

namespace After1000Days
{
    class Program
    {
        static void Main()
        {
            //2.въвежда се датата като стринг
            // Console.ReadLine(); - връща винаги стринг
            // за да се въведе число използваме Parse - (int.Parse(Console.ReadLine()); ... double, float, long  и т н т)
            string inputDate = Console.ReadLine();
            //3.използваме клас DateTame даваме му име и както следва по реда метода метода за превръщане ParceExact,
            //в скобите му поставяме зададеният текст(стринг или поредица отсимволи,
            //форматът в които желаем да се появи (по стандарт ни връща ден, месец, година ,час, минута , секунда),
            // накрая му казваме че това всичко независи от култура регион и тнт.)
            //4.чрез метода AddDays - му прибавяме 1000 дни минус деня които сме задали
            DateTime in1000Dayis = DateTime.ParseExact(inputDate, "dd-MM-yyyy",
                CultureInfo.InvariantCulture).AddDays(999);
            //5.отпечатваме на конзолата резултатът – като текст – в желаният формат
            Console.WriteLine(in1000Dayis.ToString("dd-MM-yyyy"));
            // след 1. – всичко останало излиза като падащо меню до курсора и
            //можеш да разгледаш какво има и да си избереш каквото ти трябва
            //надявам се да съм бил полезен!
        }
    }
}