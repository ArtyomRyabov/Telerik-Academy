// Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexadecimalNumber = Console.ReadLine();

        Console.WriteLine("Converted to decimal: {0}", HexadecimalToDecimalNumber(hexadecimalNumber));
    }

    private static long HexadecimalToDecimalNumber(string hexadecimalNumber)
    {
        long decimalNumber = 0;

        for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
        {
            if ((hexadecimalNumber[i] >= '0') && (hexadecimalNumber[i] <= '9'))
            {
                long multiplier = (long)Math.Pow(16, (hexadecimalNumber.Length - 1 - i));
                decimalNumber += (hexadecimalNumber[i] - '0') * multiplier;
            }
            else if ((hexadecimalNumber[i] >= 'A') && (hexadecimalNumber[i] <= 'F'))
            {
                long multiplier = (long)Math.Pow(16, (hexadecimalNumber.Length - 1 - i));
                decimalNumber += (hexadecimalNumber[i] - 'A' + 10) * multiplier;
            }
        }

        return decimalNumber;
    }
}

