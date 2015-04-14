using System;

class RandomizedNumbers
{
    static void Main()
    {
        // Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
        // You might need to use arrays.

        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        bool[] printed = new bool[n + 1];
        Random r = new Random();

        for (int i = 1; i <= n; i++)
        {
            int numbers = r.Next(1, n + 1);
            if (printed[numbers])
            {
                i--;
            }
            else
            {
                Console.Write(numbers + " ");
                printed[numbers] = true;
            }
        }
        Console.WriteLine();
    }
}

