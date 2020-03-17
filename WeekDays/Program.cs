using System;
using System.Collections.Generic;

namespace WeekDays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> WeekDays = new List<string>()
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            foreach (string day in WeekDays)
                Console.WriteLine(day);

            Console.ReadKey();
        }
    }
}
