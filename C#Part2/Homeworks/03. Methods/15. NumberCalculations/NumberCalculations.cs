// Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
// Use generic method (read in Internet about generic methods in C#).


using System;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("The integer with minimum value is: {0}", IntegersMinimumValue(-2, 1.555f, 2.05d, 4, 6, 8, 10L));
        Console.WriteLine("The integer with maximum value is: {0}", IntegersMaximumValue(-2, 1, 2, 4, 6, 8, 10));
        Console.WriteLine("The integer with average value is: {0}", IntegersAverageValue(-2.234m, 1.4444444444m, 2.4m, 4.66m, 6m, 8m, 10m));
        Console.WriteLine("The sum of the integers is: {0}", IntegersSum(-2.4m, 1L, 2u, 4.2m, 6, 8, 10));
        Console.WriteLine("The product of the integers is: {0}", IntegersProduct(-2, 1.2f, 2L, 4.2d, 6u, 8.8, -10));
    }

    private static T IntegersProduct<T>(params T[] args)
    {
        dynamic product = 1;

        for (int i = 0; i < args.Length; i++)
        {
            product *= args[i];
        }
        return product;
    }

    private static T IntegersSum<T>(params T[] args)
    {
        dynamic sum = 0;

        for (int i = 0; i < args.Length; i++)
        {
            sum += args[i];
        }
        return sum;
    }

    private static T IntegersAverageValue<T>(params T[] args)
    {
        dynamic sum = 0;

        for (int i = 0; i < args.Length; i++)
        {
            sum += args[i];
        }

        T average = sum / args.Length;
        return average;
    }

    private static T IntegersMaximumValue<T>(params T[] args)
    {
        dynamic maxValue = int.MinValue;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] > maxValue)
            {
                maxValue = args[i];
            }
        }

        return maxValue;
    }

    private static T IntegersMinimumValue<T>(params T[] args)
    {
        dynamic minValue = int.MaxValue;

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

