using System;
using System.Numerics;

class DivideFactorials
{
    static void Main()
    {
        // Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
        // Use only one loop.

        Console.WriteLine("Enter n (100 > n > k):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k (k > 1):");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;

            if (i <= k)
            {
                kFactorial *= i;
            }
        }

        BigInteger division = nFactorial / kFactorial;
        Console.WriteLine("n!/k! = {0}", division);
    }
}

