using System;
using System.Numerics;

class Expression
{
    static void Main()
    {
        // In combinatorics, the number of ways to choose k different members out of a group of n different 
        // elements (also known as the number of combinations) is calculated by the following formula: n! / (k! * (n-k)!). 
        // For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
        // Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
        // Try to use only two loops.

        Console.WriteLine("Enter n (100 > n > k):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k (k > 1):");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nMinK = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;

            if (i <= k)
            {
                kFactorial *= i;
            }
        }

        for (int i = 1; i <= (n - k); i++)
        {
            nMinK *= i;
        }

        BigInteger expression = nFactorial / (kFactorial * nMinK);
        Console.WriteLine("n! / (k! * (n-k)!) = {0}", expression);
    }
}

