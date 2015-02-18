// Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Converted to binary: {0}", DecimalToBinaryNumber(decimalNumber));
    }

    private static string DecimalToBinaryNumber(long decimalNumber)
    {
        string binaryNumber = string.Empty;

        while (decimalNumber > 0)
        {
            byte remainder = (byte)(decimalNumber % 2);
            decimalNumber /= 2;
            binaryNumber = remainder + binaryNumber;
        }

        return binaryNumber;
    }
}

