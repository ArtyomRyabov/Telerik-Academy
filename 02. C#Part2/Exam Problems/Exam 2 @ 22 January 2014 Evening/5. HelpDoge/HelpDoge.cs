namespace P5.HelpDoge
{
    using System;
    using System.Numerics;

    class HelpDoge
    {
        static void Main()
        {
            string[] matrixSize = Console.ReadLine().Split(' ');
            int rows = int.Parse(matrixSize[0]);
            int cols = int.Parse(matrixSize[1]);
            BigInteger[,] matrix = new BigInteger[rows, cols];

            string[] foodCoordinates = Console.ReadLine().Split(' ');
            int foodRow = int.Parse(foodCoordinates[0]);
            int foodCol = int.Parse(foodCoordinates[1]);
            int numberOfEnemies = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEnemies; i++)
            {
                string[] enemiesCoordinates = Console.ReadLine().Split(' ');
                int enemyRow = int.Parse(enemiesCoordinates[0]);
                int enemyCol = int.Parse(enemiesCoordinates[1]);
                matrix[enemyRow, enemyCol] = -1;
            }

            Console.WriteLine(FindAllPossibleWays(matrix, foodRow, foodCol));
        }

        static BigInteger FindAllPossibleWays(BigInteger[,] matrix, int foodRow, int foodCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row == 0 && col == 0) || (matrix [row,col] == -1))
                    {
                        matrix[row,col] += 1;
                    }
                    else if (row > 0 && col > 0)
                    {
                        matrix[row, col] = matrix[row - 1, col] + matrix[row, col - 1];
                    }
                    else if (row == 0 && col > 0)
                    {
                        matrix[row, col] = matrix[row, col - 1];
                    }
                    else if (row > 0 && col == 0)
                    {
                        matrix[row, col] = matrix[row - 1, col];
                    }

                    if (row == foodRow && col == foodCol)
                    {
                        return matrix[row, col];
                    }
                }
            }

            return 0;
        }
    }
}
