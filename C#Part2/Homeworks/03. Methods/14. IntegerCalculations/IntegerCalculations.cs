// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("The integer with minimum value is: {0}", MinimunValue(-2, 0, 2, 4, 6, 8, 10));
        Console.WriteLine("The integer with maximum value is: {0}", MaximunValue(-2, 0, 2, 4, 6, 8, 10));
        Console.WriteLine("The integer with average value is: {0}", AverageValue(-2, 0, 2, 4, 6, 8, 10));
        Console.WriteLine("The sum of the integers is: {0}", Sum(-2, 0, 2, 4, 6, 8, 10));
        Console.WriteLine("The product of the integers is: {0}", Product(-2, 0, 2, 4, 6, 8, 10));
    }

    private static int Product(params int[] args)
    {
        int product = 1;

        for (int i = 0; i < args.Length; i++)
        {
            product *= args[i];
        }
        return product;
    }

    private static int Sum(params int[] args)
    {
        int sum = 0;

        for (int i = 0; i < args.Length; i++)
        {
            sum += args[i];
        }
        return sum;
    }

    private static double AverageValue(params int[] args)
    {
        double sum = 0;

        for (int i = 0; i < args.Length; i++)
        {
            sum += args[i];
        }

        double average = sum / args.Length;
        return average;
    }

    private static int MaximunValue(params int[] args)
    {
        int maxValue = int.MinValue;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] > maxValue)
            {
                maxValue = args[i];
            }
        }

        return maxValue;
    }

    private static int MinimunValue(params int[] args)
    {
        int minValue = int.MaxValue;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] < minValue)
            {
                minValue = args[i];
            }
        }

        return minValue;
    }
}

