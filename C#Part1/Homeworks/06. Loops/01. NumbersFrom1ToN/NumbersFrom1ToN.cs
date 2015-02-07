using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        // Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
        // on a single line, separated by a space.

        Console.WriteLine("Enter a positive integer n (n > 0):");
        int n = int.Parse(Console.ReadLine());
        int number = 1;

        while (number <= n)
        {
            Console.Write("{0} ", number);
            number++;
        }
        Console.WriteLine();
    }
}

