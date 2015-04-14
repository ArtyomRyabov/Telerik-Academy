using System;

class MatrixOfNumbers
{
    static void Main()
    {
        // Write a program that reads from the console a positive integer number n (1 <= n <= 20) and prints 
        // a matrix like in the examples. Use two nested loops.

        Console.WriteLine("Enter a positive integer number n (1 <= n <= 20):");
        int n = int.Parse(Console.ReadLine());

        if (!(n >= 1) || !(n <= 20))
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                if (i < 10)
                {
                    Console.Write(" " + i + " ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                for (int j = (i + 1); j <= (i + (n - 1)); j++)
                {
                    if (j < 10)
                    {
                        Console.Write(" " + j + " ");
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

