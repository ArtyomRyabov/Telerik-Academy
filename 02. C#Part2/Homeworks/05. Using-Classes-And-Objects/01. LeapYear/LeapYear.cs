// Write a program that reads a year from the console and checks whether it is a leap one.
// Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter a year to check if it is a leap one:");
        int year = 0;

        if (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Invalid year!");
            Main();
        }
        else if (year >= 1 && year <= 9999)
        {
            IsLeapYearInRange(year);
        }
        else
        {
            IsLeapYearOutOfRange(year);
        }
    }

    private static void IsLeapYearOutOfRange(int year)
    {
        Console.WriteLine(year % 4 == 0 ? true : false);
    }

    private static void IsLeapYearInRange(int year)
    {
        bool isLeapYear = DateTime.IsLeapYear(year);
        Console.WriteLine(isLeapYear);
    }
}

