using System;

class MinMaxSumAndAverage
{
    static void Main()
    {
        // Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
        // the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
        // The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
        // The output is like in the examples below.

        Console.WriteLine("Enter number of integers:");
        int n = int.Parse(Console.ReadLine());
        int minNum = int.MaxValue;
        int maxNum = int.MinValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;

            if (number > maxNum)
            {
                maxNum = number;
            }
            if (number < minNum)
            {
                minNum = number;
            }
        }

        Console.WriteLine("min = {0}", minNum);
        Console.WriteLine("max = {0}", maxNum);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", (double)sum / n);
    }
}

