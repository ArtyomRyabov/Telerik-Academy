using System;

class SumFiveNumbers
{
    static void Main()
    {
        // Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

        Console.Write("Enter 5 numbers in a single line, separated by a space: ");
        string numbers = Console.ReadLine();
        string[] splitNumbers = numbers.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;

        for (int i = 0; i < splitNumbers.Length; i++)
        {
            sum += double.Parse(splitNumbers[i]);
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}

