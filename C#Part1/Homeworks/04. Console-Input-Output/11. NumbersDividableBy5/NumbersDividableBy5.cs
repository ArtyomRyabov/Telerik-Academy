using System;

class NumbersDividableBy5
{
    static void Main()
    {
        // Write a program that reads two positive integer numbers and prints how many numbers p exist       
        // between them such that the reminder of the division by 5 is 0.

        Console.WriteLine("Enter two positive integer numbers:");
        Console.Write("First: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Last: ");
        int last = int.Parse(Console.ReadLine());
        int p = 0;

        for (int i = first; i <= last; i++)
        {
            if (i % 5 == 0)
            {
                p++;
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
        Console.WriteLine("The numbers between {0} and {1} with reminder 0 of their" +
                " division by 5 are: {2}", first, last, p);
    }
}

