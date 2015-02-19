// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Enter a number between ({0} <= number <= {1})", short.MinValue, short.MaxValue);
        int decimalNumber = int.Parse(Console.ReadLine());

        if ((decimalNumber < short.MinValue) || (decimalNumber > short.MaxValue))
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            Console.WriteLine("Converted to binary: {0}", ShortToBinaryNumber(decimalNumber));
        }
    }

    private static string ShortToBinaryNumber(int decimalNumber)
    {
        string binaryNumber = string.Empty;

        if (decimalNumber == 0)
        {
            return "0";
        }
        else if (decimalNumber < 0)
        {
            decimalNumber = (short.MinValue + Math.Abs(decimalNumber)) * -1;

            while (decimalNumber > 0)
            {
                byte remainder = (byte)(decimalNumber % 2);
                decimalNumber /= 2;
                binaryNumber = remainder + binaryNumber;
            }

            binaryNumber = "1" + binaryNumber.PadLeft(15, '0');
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

        return binaryNumber = binaryNumber.PadLeft(16, '0');
    }
}

