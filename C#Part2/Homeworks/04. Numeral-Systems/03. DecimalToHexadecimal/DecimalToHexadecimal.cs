// Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Converted to hexademical: {0}", DecimalToHexademicalNumber(decimalNumber));
    }

    private static string DecimalToHexademicalNumber(long decimalNumber)
    {
        string hexademicalNumber = string.Empty;

        while (decimalNumber > 0)
        {
            byte remainder = (byte)(decimalNumber % 16);
            decimalNumber /= 16;

            if ((remainder <= 9) && (remainder >= 0))
            {
                hexademicalNumber = (char)(remainder + '0') + hexademicalNumber;
            }
            else if ((remainder <= 15) && (remainder >= 10))
            {
                hexademicalNumber = (char)(remainder - 10 + 'A') + hexademicalNumber;
            }  
        }
        
        return hexademicalNumber;
    }
}

