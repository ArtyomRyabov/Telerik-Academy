// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints 
// the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

namespace P17.DateInBulgarian
{
    using System;
    using System.Globalization;

    class DateInBulgarian
    {
        static void Main()
        {
            CultureInfo bulgarian = new CultureInfo("bg-BG");

            Console.WriteLine("Enter a date and time in the format [day.month.year hour:minute:second]:");
            DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy H:m:s", CultureInfo.InvariantCulture);

            DateTime changed = inputDate.AddHours(6).AddMinutes(30);
            
            Console.Write("result: {0} ", changed);
            Console.WriteLine("({0})", bulgarian.DateTimeFormat.GetDayName(changed.DayOfWeek));
        }
    }
}
