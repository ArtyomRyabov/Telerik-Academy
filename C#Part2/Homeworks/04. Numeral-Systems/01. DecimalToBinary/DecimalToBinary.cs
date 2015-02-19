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

        if (decimalNumber == 0)
        {
            return Convert.ToString(decimalNumber);
        }
        else if (decimalNumber < 0)
        {
            decimalNumber = (long.MinValue + Math.Abs(decimalNumber)) * -1;

            while (decimalNumber > 0)
            {
                byte remainder = (byte)(decimalNumber % 2);
                decimalNumber /= 2;
                binaryNumber = remainder + binaryNumber;
            }

            return binaryNumber;
        }
        else
        {
            while (decimalNumber > 0)
            {
                byte remainder = (byte)(decimalNumber % 2);
                decimalNumber /= 2;
                binaryNumber = remainder + binaryNumber;
            }
        }

        return binaryNumber = binaryNumber.PadLeft(64, '0');
    }
}

