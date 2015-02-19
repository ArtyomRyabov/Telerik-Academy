// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();

        Console.WriteLine("Converted to hexadecimal: {0}", BinaryToHexadecimalNumber(binaryNumber));
    }

    private static string BinaryToHexadecimalNumber(string binaryNumber)
    {
        string hexadecimalNumber = string.Empty;

        while (binaryNumber.Length % 4 != 0)
        {
            binaryNumber = '0' + binaryNumber;
        }

        for (int i = 0; i < binaryNumber.Length; i += 4)
        {
            string temp = string.Empty;

            for (int j = i; j < i + 4; j++)
            {
                temp += binaryNumber[j];

                switch (temp)
                {
                    case "0000": hexadecimalNumber += '0'; break;
                    case "0001": hexadecimalNumber += '1'; break;
                    case "0010": hexadecimalNumber += '2'; break;
                    case "0011": hexadecimalNumber += '3'; break;
                    case "0100": hexadecimalNumber += '4'; break;
                    case "0101": hexadecimalNumber += '5'; break;
                    case "0110": hexadecimalNumber += '6'; break;
                    case "0111": hexadecimalNumber += '7'; break;
                    case "1000": hexadecimalNumber += '8'; break;
                    case "1001": hexadecimalNumber += '9'; break;
                    case "1010": hexadecimalNumber += 'A'; break;
                    case "1011": hexadecimalNumber += 'B'; break;
                    case "1100": hexadecimalNumber += 'C'; break;
                    case "1101": hexadecimalNumber += 'D'; break;
                    case "1110": hexadecimalNumber += 'E'; break;
                    case "1111": hexadecimalNumber += 'F'; break;
                }
            }
        }

        return hexadecimalNumber;
    }
}

