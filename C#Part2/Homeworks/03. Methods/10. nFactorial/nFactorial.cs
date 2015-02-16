//Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Numerics;

class nFactorial
{
    static void Main()
    {
        int[] array = new int[100];

        for (int i = 1; i <= 100; i++)
        {
            Factorial(i);
        }
    }

    private static void Factorial(int i)
    {
        BigInteger factorial = 1;

        for (int j = 1; j <= i; j++)
        {
            factorial *= j; 
        }

        Console.WriteLine("{0}! = {1}", i, factorial);
    }
}

