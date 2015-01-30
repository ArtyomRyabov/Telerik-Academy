using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        // Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
        // Your program should work well for very big numbers, e.g. n=100000.

        Console.Write("Enter an integer: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger divider = 5;
        BigInteger sum = 0;
        BigInteger result = 1;
        BigInteger factorial = 1;

        while (result > 0)
        {
            sum += (n / divider);
            result = n / divider;
            divider *= 5;
        }
        Console.WriteLine("trailing zeroes of n!: {0}", sum);

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("n! = {0}", factorial);
    }
}

