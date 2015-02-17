// Extend the previous program to support also substraction and multiplication of polynomials.

using System;

class SubtractingPolynomials
{
    static void Main()
    {
        Console.WriteLine("Enter number of coefficients for the first polynomial:");
        int firstCoefNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coefficients reversed way:");
        decimal[] firstPolynomial = new decimal[firstCoefNum];
        WritePolynomial(firstPolynomial);
        Console.WriteLine(new string('-', 50));
        Console.Write("First Polynomial: ");
        PrintPolynomial(firstPolynomial);
        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Enter number of coefficients for the second polynomial:");
        int secondCoefNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coefficients reversed way:");
        decimal[] secondPolynomial = new decimal[secondCoefNum];
        WritePolynomial(secondPolynomial);
        Console.WriteLine(new string('-', 50));
        Console.Write("Second Polynomial: ");
        PrintPolynomial(secondPolynomial);
        Console.WriteLine(new string('-', 50));

        decimal[] substractPolynomials = new decimal[MaxLength(firstPolynomial, secondPolynomial)];
        Substract(firstPolynomial, secondPolynomial, substractPolynomials);
        Console.WriteLine(new string('-', 50));
        Console.Write("Substract polynomials: ");
        PrintPolynomial(substractPolynomials);
        Console.WriteLine(new string('-', 50));

        decimal[] multiplyPolynomials = new decimal[firstPolynomial.Length + secondPolynomial.Length];
        Multiply(firstPolynomial, secondPolynomial, multiplyPolynomials);
        Console.WriteLine(new string('-', 50));
        Console.Write("Multiply polynomials: ");
        PrintPolynomial(multiplyPolynomials);
        Console.WriteLine(new string('-', 50));
    }

    static void Multiply(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] multiplyPolynomials)
    {
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            for (int j = 0; j < secondPolynomial.Length; j++)
            {
                int index = i + j;
                multiplyPolynomials[index] += (firstPolynomial[i] * secondPolynomial[j]);
            }
        }
    }

    private static int MaxLength(decimal[] firstPolynomial, decimal[] secondPolynomial)
    {
        int maxLength = 0;

        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            maxLength = firstPolynomial.Length;
        }
        else
        {
            maxLength = secondPolynomial.Length;
        }

        return maxLength;
    }

    static void Substract(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] substractPolynomials)
    {
        int minLenght = 0;

        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            minLenght = secondPolynomial.Length;
        }
        else
        {
            minLenght = firstPolynomial.Length;
        }

        for (int i = 0; i < minLenght; i++)
        {
            substractPolynomials[i] = firstPolynomial[i] - secondPolynomial[i];
        }

        for (int i = minLenght; i < substractPolynomials.Length; i++)
        {
            if (minLenght == firstPolynomial.Length)
            {
                substractPolynomials[i] = -secondPolynomial[i];
            }
            else
            {
                substractPolynomials[i] = firstPolynomial[i];
            }
        }
    }

    static void PrintPolynomial(decimal[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}", polynomial[i]);
            }
            else if (i == 1)
            {
                if (polynomial[i - 1] >= 0)
                {
                    Console.Write("{0}x + ", polynomial[i]);
                }
                else
                {
                    Console.Write("{0}x ", polynomial[i]);
                }
            }
            else if (polynomial[i] != 0 && i > 1)
            {
                if (polynomial[i - 1] >= 0)
                {
                    Console.Write("{0}x^{1} + ", polynomial[i], i);
                }
                else
                {
                    Console.Write("{0}x^{1} ", polynomial[i], i);
                }
            }
        }
    }

    private static void WritePolynomial(decimal[] polynomial)
    {
        for (int i = 0; i < polynomial.Length; i++)
        {
            polynomial[i] = decimal.Parse(Console.ReadLine());
        }
    }
}

