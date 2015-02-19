using System;

class PrimeNumbers
{
    static void Main()
    {
        // Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

        int maxNumber = 10000000;
        bool[] notPrimes = new bool[maxNumber];

        for (int i = 2; i < Math.Sqrt(maxNumber); i++)
        {
            if (notPrimes[i] == false)
            {
                for (int j = i * i; j < maxNumber; j += i)
                {
                    notPrimes[j] = true;
                }
            }
        }

        Console.WriteLine("The prime numbers are yellow and not primes are blue");

        for (int j = 2; j < maxNumber/10000; j++)      // For fast result: change 'maxResult' on this line to 'maxResult / 10000'
        {
            if (notPrimes[j])
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("{0} ", j);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0} ", j);
            }
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
    }
}

