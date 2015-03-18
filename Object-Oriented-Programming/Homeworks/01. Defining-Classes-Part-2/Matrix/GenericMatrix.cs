namespace Matrix
{
    using System;
    using System.Text;

    public class GenericMatrix<T>
    {                                                 // Problem 8
        private int rows;
        private int cols;
        private T[,] matrix;

        public GenericMatrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Rows must be at least one!");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cols must be at least one!");
                }

                this.cols = value;
            }
        }

        public T this[int row, int col]           // Problem 9
        {
            get
            {
                if (row < 0 || row >= this.Rows)
                {
                    throw new IndexOutOfRangeException("Row is out of range!");
                }

                if (col < 0 || col >= this.Cols)
                {
                    throw new IndexOutOfRangeException("Col is out of range!");
                }

                return this.matrix[row, col];
            }
            set
            {
                if (row < 0 || row >= this.Rows)
                {
                    throw new IndexOutOfRangeException("Row is out of range!");
                }

                if (col < 0 || col >= this.Cols)
                {
                    throw new IndexOutOfRangeException("Col is out of range!");
                }

                this.matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(String.Format("{0} ", this.matrix[row, col]));
                }

                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }

        public static GenericMatrix<T> operator +(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)  // Problem 10
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Matrices must have same size.");
            }

            GenericMatrix<T> result = new GenericMatrix<T>(firstMatrix.rows, firstMatrix.cols);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] + (dynamic)secondMatrix[row, col];
                }
            }

            return result;
        }

        public static GenericMatrix<T> operator -(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Matrices must have same size.");
            }

            GenericMatrix<T> result = new GenericMatrix<T>(firstMatrix.rows, firstMatrix.cols);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] - (dynamic)secondMatrix[row, col];
                }
            }

            return result;
        }

        public static GenericMatrix<T> operator *(GenericMatrix<T> firstMatrix, GenericMatrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new ArgumentException("First matrix cols size and second matrix rows must be the same!");
            }

            GenericMatrix<T> result = new GenericMatrix<T>(firstMatrix.Rows, secondMatrix.Cols);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < secondMatrix.Cols; col++)
                {
                    for (int i = 0; i < firstMatrix.Cols; i++)
                    {
                        result[row, col] += (dynamic)firstMatrix[row, i] * (dynamic)secondMatrix[i, col];
                    }
                }
            }

            return result;
        }

        public static bool operator true(GenericMatrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(GenericMatrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
