using System;

class MaximalSum
{
    static void Main()
    {
        // Write a program that reads a rectangular matrix of size N x M and finds in it the 
        // square 3 x 3 that has maximal sum of its elements.

        Console.WriteLine("Enter rows' number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter columns' number:");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("matrix[{0},{1}] = ", i, j);
                int element = int.Parse(Console.ReadLine());
                matrix[i, j] = element;
            }
        }

        int row = 0;
        int col = 0;

        Console.WriteLine("The matrix is:");

        for (row = 0; row < matrix.GetLength(0); row++)
        {
            for (col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] <= 9)
                {
                    Console.Write(" {0}   ", matrix[row, col]);
                }
                else 
                {
                    Console.Write(" {0}  ", matrix[row, col]);
                }
            }
            Console.WriteLine();
        }

        int maxSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] +
                          matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] +
                          matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine("The maximal sum is: {0}", maxSum);
        Console.WriteLine("The square with maximal sum is:");
        Console.WriteLine(" {0}  {1}  {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine(" {0}  {1}  {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine(" {0}  {1}  {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
    }
}

