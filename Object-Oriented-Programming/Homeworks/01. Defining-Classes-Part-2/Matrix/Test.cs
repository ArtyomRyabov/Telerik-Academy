namespace Matrix
{
    using System;

    class Test
    {
        static void Main()
        {
            GenericMatrix<int> firstMatrix = new GenericMatrix<int>(3, 2);     // Empty matrix

            firstMatrix[0, 0] = 1;       // Filling the matrix
            firstMatrix[0, 1] = 2;
            firstMatrix[1, 0] = 3;
            firstMatrix[1, 1] = 4;
            firstMatrix[2, 0] = 5;
            firstMatrix[2, 1] = 0;

            Console.WriteLine("first matrix with zero element:\n");
            Console.WriteLine(firstMatrix);
            Console.Write("The matrix does not contain zero element: ");    // Testing true / false             

            if (firstMatrix)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            firstMatrix[0, 0] = 1;       // Filling the matrix
            firstMatrix[0, 1] = 2;
            firstMatrix[1, 0] = 3;
            firstMatrix[1, 1] = 4;
            firstMatrix[2, 0] = 5;
            firstMatrix[2, 1] = 6;

            Console.WriteLine("\nfirst matrix without zero element:\n");
            Console.WriteLine(firstMatrix);
            Console.Write("The matrix does not contain zero element: ");

            if (firstMatrix)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            GenericMatrix<int> secondMatrix = new GenericMatrix<int>(3, 2);

            secondMatrix[0, 0] = 10;
            secondMatrix[0, 1] = 10;
            secondMatrix[1, 0] = 10;
            secondMatrix[1, 1] = 10;
            secondMatrix[2, 0] = 10;
            secondMatrix[2, 1] = 10;

            Console.WriteLine("\nsecond matrix:\n");
            Console.WriteLine(secondMatrix);

            Console.WriteLine("first matrix + second matrix:\n");
            Console.WriteLine(firstMatrix + secondMatrix);        // Matrices addition

            Console.WriteLine("first matrix - second matrix:\n");
            Console.WriteLine(firstMatrix - secondMatrix);        // Matrices subtraction

            GenericMatrix<int> thirdMatrix = new GenericMatrix<int>(2, 4);

            thirdMatrix[0, 0] = 10;
            thirdMatrix[0, 1] = 10;
            thirdMatrix[0, 2] = 10;
            thirdMatrix[0, 3] = 10;
            thirdMatrix[1, 0] = 10;
            thirdMatrix[1, 1] = 10;
            thirdMatrix[1, 2] = 10;
            thirdMatrix[1, 3] = 10;

            Console.WriteLine("third matrix:\n");
            Console.WriteLine(thirdMatrix);

            Console.WriteLine("second matrix * third matrix:\n");
            Console.WriteLine(secondMatrix * thirdMatrix);    // Matrices multiplication
        }
    }
}
