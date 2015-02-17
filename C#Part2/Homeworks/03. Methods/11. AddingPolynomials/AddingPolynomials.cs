// Write a method that adds two polynomials. Represent them as arrays of their coefficients.

using System;

class AddPolynomials
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of coefficients for the first polynomial:");
        int firstNumC = int.Parse(Console.ReadLine());
        decimal[] firstPolynomial = new decimal[firstNumC];
        Console.WriteLine("Enter the coefficients:");
        WritePolynomial(firstPolynomial);
        Console.WriteLine(new string('-', 50));
        Console.Write("First polinomial: ");
        PrintPolynomial(firstPolynomial);
        Console.WriteLine(new string('-', 50));

        decimal[] reversedFirstArray = new decimal[firstPolynomial.Length];
        for (int i = 0; i < reversedFirstArray.Length; i++)
        {
            reversedFirstArray[i] = firstPolynomial[firstPolynomial.Length - 1 - i];
        }
        Console.WriteLine("Reversed first polynomial coefficients: {0}", string.Join(", ", reversedFirstArray));

        Console.WriteLine("Enter number of coefficients for the second polynomial:");
        int secondNumC = int.Parse(Console.ReadLine());
        decimal[] secondPolynomial = new decimal[secondNumC];
        Console.WriteLine("Enter the coefficients:");
        WritePolynomial(secondPolynomial);
        Console.WriteLine(new string('-', 50));
        Console.Write("Second polinomial: ");
        PrintPolynomial(secondPolynomial);
        Console.WriteLine(new string('-', 50));

        decimal[] reversedSecondArray = new decimal[secondPolynomial.Length];
        for (int i = 0; i < reversedSecondArray.Length; i++)
        {
            reversedSecondArray[i] = secondPolynomial[secondPolynomial.Length - 1 - i];
        }
        Console.WriteLine("Reversed second polynomial coefficients: {0}", string.Join(", ", reversedSecondArray));

        PolynomialsSum(reversedFirstArray, reversedSecondArray, MaxLength(firstPolynomial, secondPolynomial));
        Console.WriteLine(new string('-', 50));
    }

    private static int MaxLength(decimal[] firstPolynomial, decimal[] secondPolynomial)
    {
        int maxLength = 0;

        if (firstPolynomial.Length >= secondPolynomial.Length)
        {
            maxLength = firstPolynomial.Length;
        }
        else
        {
            maxLength = secondPolynomial.Length;
        }

        return maxLength;
    }

    private static void PolynomialsSum(decimal[] reversedFirstArray, decimal[] reversedSecondArray, int usedLength)
    {
        decimal[] sum = new decimal[usedLength];

        for (int i = 0; i < usedLength; i++)
        {
            if (i > reversedFirstArray.Length - 1)
            {
                sum[i] = reversedSecondArray[i];
            }
            else if (i > reversedSecondArray.Length - 1)
            {
                sum[i] = reversedFirstArray[i];
            }
            else
            {
                sum[i] = reversedFirstArray[i] + reversedSecondArray[i];
            }
        }

        decimal[] reversedSum = new decimal[usedLength];

        for (int i = 0; i < usedLength; i++)
        {
            reversedSum[usedLength - i - 1] = sum[i];
        }

        Console.WriteLine(new string('-', 50));
        Console.Write("Polynomials' sum: ");
        PrintPolynomial(reversedSum);
    }

    private static void PrintPolynomial(decimal[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write("{0}", array[i]);
            }
            else if (i == array.Length - 2)
            {
                Console.Write("{0}x + ", array[i]);
            }
            else
            {
                Console.Write("{0}x^{1} + ", array[i], (array.Length - 1 - i));
            }
        }

        Console.WriteLine();
    }

    private static void WritePolynomial(decimal[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = decimal.Parse(Console.ReadLine());
        }
    }
}

