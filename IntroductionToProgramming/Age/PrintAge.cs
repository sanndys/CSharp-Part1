using System;
using System.Globalization;

namespace Age 
{
    class PrintAge
    {
        static void Main()
        {
            DateTime currentDate = DateTime.Now;

            string input = (Console.ReadLine());
            string dateFormat = "MM'.'dd'.'yyyy";
            DateTime birthDate = DateTime.ParseExact(input, dateFormat, CultureInfo.InvariantCulture);

            int age = (int)((currentDate - birthDate).TotalDays / 365.25);
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}