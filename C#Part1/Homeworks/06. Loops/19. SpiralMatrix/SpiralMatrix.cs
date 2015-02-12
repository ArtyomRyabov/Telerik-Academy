using System;

class SpiralMatrix
{
    static void Main()
    {
        // Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
        // holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

        Console.WriteLine("Enter a positive integer number n (1 <= n <= 20):");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        Console.WriteLine("This is the empty matrix:");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0}  ", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        string direction = "left";
        int number = 1;
        int row = 0;
        int col = 0;

        while (number <= n * n)
        {
            if (direction == "left")
            {
                while ((col < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col++] = number++;
                }
                col--;
                row++;
                direction = "down";
            }
            else if (direction == "down")
            {
                while ((row < n) && (matrix[row, col] == 0))
                {
                    matrix[row++, col] = number++;
                }
                col--;
                row--;
                direction = "right";
            }
            else if (direction == "right")
            {
                while ((col > -1) && (matrix[row, col] == 0))
                {
                    matrix[row, col--] = number++;
                }
                col++;
                row--;
                direction = "up";
            }
            else if (direction == "up")
            {
                while ((row > -1) && (matrix[row, col] == 0))
                {
                    matrix[row--, col] = number++;
                }
                col++;
                row++;
                direction = "left";
            }
        }

        Console.WriteLine("This is the spiral matrix:");

        for (row = 0; row < matrix.GetLength(0); row++)
        {
            for (col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] <= 9)
                {
                    Console.Write("{0}   ", matrix[row, col]);
                }
                else if ((matrix[row, col] <= 99) && (matrix[row, col] >= 10))
                {
                    Console.Write("{0}  ", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

