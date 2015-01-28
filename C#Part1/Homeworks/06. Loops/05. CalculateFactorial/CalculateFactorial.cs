using System;

class CalculateFactorial
{
    static void Main()
    {
        // Write a program that, for a given two integer numbers n and x, calculates 
        // the sum S = 1 + 1!/x + 2!/x^2 + … + n!/x^n.
        // Use only one loop. Print the result with 5 digits after the decimal point.

        Console.WriteLine("Enter integer n (n > 0):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer x:");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1m;
        long factorial = 1L;
        long xPow = 1L;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xPow *= x;
            sum += ((decimal)factorial / xPow);
        }
        Console.WriteLine("{0:F5}", sum);
    }
}

