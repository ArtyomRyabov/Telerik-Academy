// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main()
    {
        Random value = new Random();
        Console.WriteLine("Ten random values in the range [100, 200]:");
        Console.ForegroundColor = ConsoleColor.Blue;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0} ", value.Next(100, 201));
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }
}

