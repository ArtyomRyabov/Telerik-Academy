namespace RangeExceptions
{
    using System;
    using System.Globalization;

    public class Sample
    {
        public static void Main()
        {
            Console.WriteLine("Enter an integer number in range [0 - 100]");
            int number = int.Parse(Console.ReadLine());

            try
            {
                if (number < 0 || number > 100)
                {
                    throw new InvalidRangeException<int>(0, 100);
                }
                else
                {
                    Console.WriteLine("Your number is accepted");
                }
            }
            catch (InvalidRangeException<int> ire)
            {
                Console.WriteLine(ire.Message);
            }

            Console.WriteLine("\nEnter a date in range [1.1.1980 - 31.12.2013]");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);

            try
            {
                if (date < start || date > end)
                {
                    throw new InvalidRangeException<DateTime>(start, end);
                }
                else
                {
                    Console.WriteLine("Your date is accepted");
                }
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine(ire.Message);
            }
        }
    }
}
