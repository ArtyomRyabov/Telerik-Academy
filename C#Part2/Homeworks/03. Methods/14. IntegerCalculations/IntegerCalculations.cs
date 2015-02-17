// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("The integer with minimum value is: {0}", IntegersMinimumValue(-2, 0, 2, 4, 6, 8, 10));
        Console.WriteLine("The integer with maximum value is: {0}", IntegersMaximumValue(-2, 0, 2, 4, 6, 8, 10));
        Console.WriteLine("The integer with average value is: {0}", IntegersAverageValue(-2, 0, 2, 4, 6, 8, 10));
        Console.WriteLine("The sum of the integers is: {0}", IntegersSum(-2, 0, 2, 4, 6, 8, 10));
        Console.WriteLine("The product of the integers is: {0}", IntegersProduct(-2, 0, 2, 4, 6, 8, 10));
    }

    private static int IntegersProduct(params int[] args)
    {
        int product = 1;

        for (int i = 0; i < args.Length; i++)
        {
            product *= args[i];
        }
        return product;
    }

    private static int IntegersSum(params int[] args)
    {
        int sum = 0;

        for (int i = 0; i < args.Length; i++)
        {
            sum += args[i];
        }
        return sum;
    }

    private static double IntegersAverageValue(params int[] args)
    {
        double sum = 0;

        for (int i = 0; i < args.Length; i++)
        {
            sum += args[i];
        }

        double average = sum / args.Length;
        return average;
    }

    private static int IntegersMaximumValue(params int[] args)
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

    private static int IntegersMinimumValue(params int[] args)
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

