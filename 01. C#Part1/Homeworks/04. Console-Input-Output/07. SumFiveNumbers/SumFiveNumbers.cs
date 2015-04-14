using System;

class SumFiveNumbers
{
    static void Main()
    {
        // Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

        // solution 1:

        Console.Write("Enter 5 numbers in a single line, separated by a space: ");
        string numbers = Console.ReadLine();
        string[] splitNumbers = numbers.Split(' ');
        int firstNumber = int.Parse(splitNumbers[0]);
        int secondNumber = int.Parse(splitNumbers[1]);
        int thirdNumber = int.Parse(splitNumbers[2]);
        int fourthNumber = int.Parse(splitNumbers[3]);
        int fifthNumber = int.Parse(splitNumbers[4]);
        int sum = (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber);
        Console.WriteLine("Sum: {0}", sum);

        // solution 2:

        Console.Write("Enter 5 numbers in a single line, separated by a space: ");
        string nums = Console.ReadLine();
        string[] splitnums = nums.Split(' ');

        double sumnums = 0;

        for (int i = 0; i < splitnums.Length; i++)
        {
            sumnums += double.Parse(splitnums[i]);
        }
        Console.WriteLine("Sum: {0}", sumnums);
    }
}

