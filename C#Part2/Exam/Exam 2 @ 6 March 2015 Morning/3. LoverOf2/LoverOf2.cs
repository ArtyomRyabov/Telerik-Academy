namespace P3.LoverOf2
{
    using System;
    using System.Linq;
    using System.Numerics;

    class LoverOf2
    {
        static byte rows, cols;
        static BigInteger[,] field;

        static void Main()
        {
            rows = byte.Parse(Console.ReadLine());
            cols = byte.Parse(Console.ReadLine());
            short numberOfMoves = short.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int[] codes = line.Split(' ').Select(x => int.Parse(x)).ToArray();
            field = new BigInteger[rows, cols];

            FillTheField();

            Console.WriteLine(CollectTheValues(codes));
        }

        static void FillTheField()
        {
            BigInteger startNumber = 1;

            for (int i = rows - 1; i >= 0; i--)
            {
                BigInteger currentNumber = startNumber;

                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = currentNumber;
                    currentNumber *= 2;
                }

                startNumber *= 2;
            }
        }

        static BigInteger CollectTheValues(int[] codes)
        {
            int coeff = Math.Max(rows, cols);
            int row = rows - 1;
            int col = 0;
            BigInteger values = field[row, col];
            field[row, col] = 0;

            foreach (int code in codes)
            {
                int targetRow = code / coeff;
                int targetCol = code % coeff;

                if (targetRow < row)
                {
                    while (targetRow < row)
                    {
                        row--;
                        values += field[row, col];
                        field[row, col] = 0;
                    }
                }
                else if (targetRow > row)
                {
                    while (targetRow > row)
                    {
                        row++;
                        values += field[row, col];
                        field[row, col] = 0;
                    }
                }

                if (targetCol < col)
                {
                    while (targetCol < col)
                    {
                        col--;
                        values += field[row, col];
                        field[row, col] = 0;
                    }
                }
                else if (targetCol > col)
                {
                    while (targetCol > col)
                    {
                        col++;
                        values += field[row, col];
                        field[row, col] = 0;
                    }
                }
            }

            return values;
        }
    }
}
