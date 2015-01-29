using System;

class RandomNumbers
{
    static void Main()
    {
        // Write a program that enters 3 integers n, min and max (min != max) and prints n random 
        // numbers in the range [min...max].

        Console.Write("Number of integers to be entered: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min integer: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max integer (max > min): ");
        int max = int.Parse(Console.ReadLine());
        Random numbers = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers.Next(min, max + 1) + " ");
        }
        Console.WriteLine();
    }
}

