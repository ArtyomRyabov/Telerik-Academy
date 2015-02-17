// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter number of integers:");
        int elementsNumber = int.Parse(Console.ReadLine());
        int[] array = new int[elementsNumber];
        Console.WriteLine("Enter the integers:");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Choose start index:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose end index:");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("The integer with minimum value is: {0}", MinimunValue(array, start, end));
        Console.WriteLine("The integer with maximum value is: {0}", MaximunValue(array, start, end));
        Console.WriteLine("The integer with average value is: {0}", AverageValue(array, start, end));
        Console.WriteLine("The sum of the integers is: {0}", Sum(array, start, end));
        Console.WriteLine("The product of the integers is: {0}", Product(array, start, end));
    }

    private static int Product(int[] array, int start, int end)
    {
        int product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            if ((i >= start) && (i <= end))
            {
                product *= array[i];
            }
        }
        return product;
    }

    private static int Sum(int[] array, int start, int end)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if ((i >= start) && (i <= end))
            {
                sum += array[i];
            }
        }
        return sum;
    }

    private static double AverageValue(int[] array, int start, int end)
    {
        double sum = 0;
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if ((i >= start) && (i <= end))
            {
                sum += array[i];
                counter++;
            }
        }

        double average = sum / counter;
        return average;
    }

    private static int MaximunValue(int[] array, int start, int end)
    {
        int maxValue = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if ((i >= start) && (i <= end) && (array[i] > maxValue))
            {
                maxValue = array[i];
            }
        }

        return maxValue;
    }

    private static int MinimunValue(int[] array, int start, int end)
    {
        int minValue = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] < minValue) && (i >= start) && (i <= end))
            {
                minValue = array[i];
            }
        }

        return minValue;
    }
}

