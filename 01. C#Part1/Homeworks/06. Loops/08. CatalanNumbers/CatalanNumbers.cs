using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        // Write a program to calculate the n'th Catalan number by given n (1 <= n <= 100). 
        // Cn = (2 * n)! / (n + 1)! * n! 

        Console.WriteLine("Enter a number n (1 <= n <= 100):");
        int n = int.Parse(Console.ReadLine());

        BigInteger divider = 1;
        BigInteger dividend = 1;

        for (int i = (n + 2); i <= (2 * n); i++)     // (2 * n)! / (n + 1)! * n! = (n + 2)!...(2 * n)! / n!
        {
            dividend *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            divider *= i;
        }

        Console.WriteLine("Catalan(n) = {0}", (dividend / divider));
    }
}

