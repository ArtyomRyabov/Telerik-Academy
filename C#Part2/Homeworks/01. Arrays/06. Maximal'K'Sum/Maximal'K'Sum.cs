using System;

class Program
{
    static void Main()
    {
        // Write a program that reads two integer numbers N and K and an array of N elements from the console.
        // Find in the array those K elements that have maximal sum.

        Console.WriteLine("Enter two integer numbers N and K (N > K):");
        Console.Write("N = ");
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        Console.Write("K = ");
        int k = Math.Abs(int.Parse(Console.ReadLine()));
        Console.WriteLine("Enter 'N' array numbers:");

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Array.Reverse(array);

        Console.Write("Result: ");

        for (int i = 0; i < k; i++)
        {
            if (i == (k - 1))
            {
                Console.WriteLine(array[i]);
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}

