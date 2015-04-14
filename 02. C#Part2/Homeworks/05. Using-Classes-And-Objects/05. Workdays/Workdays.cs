// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Linq;

class Workdays
{
    static void Main()
    {
        Console.WriteLine("Enter a date (DD/MM/YYYY) untill 01.01.2016:");
        DateTime start = DateTime.Today;
        DateTime end = new DateTime();
        bool isEnd = DateTime.TryParse(Console.ReadLine(), out end);

        if ((end < start) || (end.Year > start.Year))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int counter = CountWorkingDays(start, end);
        Console.WriteLine("There are {0} workdays between {1:dd/MM/yyyy} and {2:dd/MM/yyyy}.", counter, start, end);
    }

    static int CountWorkingDays(DateTime start, DateTime end)
    {
        int counter = 0;

        while (start <= end)
        {
            counter++;

            if (allHolidays.Contains(start) || start.DayOfWeek == DayOfWeek.Saturday || start.DayOfWeek == DayOfWeek.Sunday)
            {
                counter--;
            }

            if (allWorkingWeekends.Contains(start))
            {
                counter++;
            }

            start = start.AddDays(1);
        }

        return counter;
    }

    static readonly DateTime[] allHolidays =
    {
        new DateTime(2015, 1, 1), new DateTime(2015, 1, 2), new DateTime(2015, 3, 2), new DateTime(2015, 3, 3), 
        new DateTime(2015, 4, 10), new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
        new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 21), new DateTime(2015, 9, 22),
        new DateTime(2015, 12, 24), new DateTime(2015, 12, 25), new DateTime(2015, 12, 31)
    };

    static readonly DateTime[] allWorkingWeekends =
    {
        new DateTime(2015, 1, 24), new DateTime(2015, 3, 21), new DateTime(2015, 9, 12), new DateTime(2015, 12, 21)
    };
}

