using System;

class SumNNumbers
{
    static void Main()
    {
        // Write a program that enters a number n and after that enters more n numbers and calculates and 
        // prints their sum. Note: You may need to use a for-loop.

        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}

