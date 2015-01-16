using System;

class LongSequence
{
    static void Main()
    {
        // Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
        // You might need to learn how to use loops in C# (search in Internet).

        int number = 2;
        for (int i = 0; i < 1000; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(number + i + ", ");
            }  
            else 
                Console.Write(-(number + i) + ", ");
        }
    }
}

