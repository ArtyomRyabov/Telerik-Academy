using System;

class FillTheMatrix
{
    static void Main()
    {
        /* Write a program that fills and prints a matrix of size (n, n) as shown below:

             Example for n=4:
         
             a)                   b)                    c)                     d)*
             1 5  9 13            1 8  9 16             7 11 14 16             1 12 11 10
             2 6 10 14            2 7 10 15             4  8 12 15             2 13 16  9
             3 7 11 15            3 6 11 14             2  5  9 13             3 14 15  8
             4 8 12 16            4 5 12 13             1  3  6 10             4  5  6  7 
         */

        Console.WriteLine("Enter integer number n (20 > n > 0):");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        Console.WriteLine("This is the empty matrix:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}  ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // a)
        Console.WriteLine("This is the matrix according to first condition:");
        int number = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++, number++)
            {
                matrix[row, col] = number;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
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

        // b)
        number = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = number++;
                }
            }
            else
            {
                for (int row = (matrix.GetLength(0) - 1); row >= 0; row--)
                {
                    matrix[row, col] = number++;
                }
            }
        }

        Console.WriteLine("This is the matrix according to second condition:");

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
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

        // c)
        number = 1;

        for (int row = (n - 1); row >= 0; row--)
        {
            int tempRow = row;

            for (int col = 0; col < (n - row); col++)
            {
                matrix[tempRow, col] = number++;
                tempRow++;
            }
        }

        number = n * n;

        for (int row = 0; row < (n - 1); row++)
        {
            int tempRow = row;

            for (int col = (n - 1); tempRow >= 0; col--)
            {
                matrix[tempRow, col] = number--;
                tempRow--;
            }
        }

        Console.WriteLine("This is the matrix according to third condition:");

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
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

        // d)
        int[,] newMatrix = new int[n, n];

        int newRow = 0;
        int newCol = 0;
        number = 1;

        do
        {
            while ((newRow < n) && (newMatrix[newRow, newCol] == 0))
            {
                newMatrix[newRow++, newCol] = number++;
            }
            newRow--;
            newCol++;

            while ((newCol < n) && (newMatrix[newRow, newCol] == 0))
            {
                newMatrix[newRow, newCol++] = number++;
            }
            newCol--;
            newRow--;

            while ((newRow > -1) && (newMatrix[newRow, newCol] == 0))
            {
                newMatrix[newRow--, newCol] = number++;
            }
            newRow++;
            newCol--;

            while ((newCol >= 0) && (newMatrix[newRow, newCol] == 0))
            {
                newMatrix[newRow, newCol--] = number++;
            }
            newCol++;
            newRow++;

        } while (number <= n * n);

        Console.WriteLine("This is the matrix according to fourth condition:");

        for (newRow = 0; newRow < newMatrix.GetLength(0); newRow++)
        {
            for (newCol = 0; newCol < newMatrix.GetLength(1); newCol++)
            {
                if (newMatrix[newRow, newCol] <= 9)
                {
                    Console.Write("{0}   ", newMatrix[newRow, newCol]);
                }
                else if ((newMatrix[newRow, newCol] <= 99) && (newMatrix[newRow, newCol] >= 10))
                {
                    Console.Write("{0}  ", newMatrix[newRow, newCol]);
                }
                else
                {
                    Console.Write("{0} ", newMatrix[newRow, newCol]);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

