using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        // A beer time is after 1:00 PM and before 3:00 AM.
        // Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
        // a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer 
        // time according to the definition above or invalid time if the time cannot be parsed. 
        // Note: You may need to learn how to parse dates and times.

        Console.Write("Enter time in format \"hh:mm tt\": ");
        string input = Console.ReadLine();
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");

        try
        {
            DateTime beer = DateTime.ParseExact(input, "h:mm tt", CultureInfo.InvariantCulture);

            if (beer >= startTime || beer < endTime)
            {
                Console.WriteLine("It's beer time!");
            }
            else
            {
                Console.WriteLine("Non-beer time!");
            }
        }
        catch
        {
        Console.WriteLine("Invalid time!");
        }
    }
}

