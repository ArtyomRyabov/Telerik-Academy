// Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();

        Console.WriteLine("Converted to decimal: {0}", BinaryToDecimalNumber(binaryNumber));
    }

    private static long BinaryToDecimalNumber(string binaryNumber)
    {
        long decimalNumber = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            long multiplier = (long)Math.Pow(2, (binaryNumber.Length - 1 - i));
            decimalNumber += (binaryNumber[i] - '0') * multiplier;
        }

        return decimalNumber;
    }
}

