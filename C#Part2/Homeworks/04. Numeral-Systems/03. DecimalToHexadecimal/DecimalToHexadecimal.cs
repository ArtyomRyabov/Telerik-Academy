// Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Converted to hexadecimal: {0}", DecimalToHexadecimalNumber(decimalNumber));
    }

    private static string DecimalToHexadecimalNumber(long decimalNumber)
    {
        string hexadecimalNumber = string.Empty;

        if (decimalNumber == 0)
        {
            return Convert.ToString(decimalNumber);
        }

        while (decimalNumber > 0)
        {
            byte remainder = (byte)(decimalNumber % 16);
            decimalNumber /= 16;

            if ((remainder <= 9) && (remainder >= 0))
            {
                hexadecimalNumber = (char)(remainder + '0') + hexadecimalNumber;
            }
            else if ((remainder <= 15) && (remainder >= 10))
            {
                hexadecimalNumber = (char)(remainder - 10 + 'A') + hexadecimalNumber;
            }  
        }

        return hexadecimalNumber;
    }
}

