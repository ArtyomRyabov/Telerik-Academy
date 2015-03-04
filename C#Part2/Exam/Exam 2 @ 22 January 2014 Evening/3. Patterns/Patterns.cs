namespace P3.Patterns
{
    using System;
    using System.Text;

    class Patterns
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            FillTheMatrix(matrix, n);

            long biggestSum = long.MinValue;
            long currentSum = long.MinValue;
            bool doesPatternExist = false;

            for (int row = 0; row < (matrix.GetLength(0) - 2); row++)
            {
                for (int col = 0; col < (matrix.GetLength(1) - 4); col++)
                {
                    if (IsPattern(matrix, row, col))
                    {
                        currentSum = PatternSum(matrix, row, col);

                        if (currentSum > biggestSum)
                        {
                            biggestSum = currentSum;
                        }

                        doesPatternExist = true;
                    }
                }
            }

            if (doesPatternExist == true)
            {
                Console.WriteLine("YES {0}", biggestSum);
            }
            else
            {
                Console.WriteLine("NO {0}", MainDiagonalNumbersSum(matrix));
            }
        }

        private static void FillTheMatrix(int[,] matrix, int n)
        {
            for (int row = 0; row < n; row++)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }
        }

        static bool IsPattern(int[,] matrix, int row, int col)
        {
            bool isPattern = ((matrix[row, col] + 1 == matrix[row, col + 1]) && (matrix[row, col] + 2 == matrix[row, col + 2]) &&
                              (matrix[row, col] + 3 == matrix[row + 1, col + 2]) && (matrix[row, col] + 4 == matrix[row + 2, col + 2]) &&
                              (matrix[row, col] + 5 == matrix[row + 2, col + 3]) && (matrix[row, col] + 6 == matrix[row + 2, col + 4]));

            return isPattern;
        }

        private static long PatternSum(int[,] matrix, int row, int col)
        {
            long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + 
                       matrix[row + 1, col + 2] + matrix[row + 2, col + 2] + 
                       matrix[row + 2, col + 3] + matrix[row + 2, col + 4];

            return sum;
        }

        static long MainDiagonalNumbersSum(int[,] matrix)
        {
            long diagonalSum = 0;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    diagonalSum += matrix[col, col];
                }

            return diagonalSum;
        }
    }
}
