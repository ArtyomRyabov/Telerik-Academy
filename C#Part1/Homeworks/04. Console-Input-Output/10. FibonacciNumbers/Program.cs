using System;

class Program
{
    static void Main()
    {
        // Write a program that reads a number n and prints on the console the first n members of 
        // the Fibonacci sequence (at a single line, separated by comma and 
        // space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
        // Note: You may need to learn how to use loops.

        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int aNumber = 0;
        int bNumber = 1;
        int sumAB;

        for (int i = 0; i < n; i++)
        {

            Console.Write("{0}, ", aNumber);
            sumAB = aNumber + bNumber;
            aNumber = bNumber;
            bNumber = sumAB;
        }
        Console.WriteLine();
    }
}

