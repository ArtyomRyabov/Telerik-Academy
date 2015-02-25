// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

namespace P16.DateDifference
{
    using System;
    using System.Globalization;

    class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter the first date [dd.MM.yyyy]: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter the second date [dd.MM.yyyy]: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Result: {0} days", (secondDate - firstDate).Days);
        }
    }
}
