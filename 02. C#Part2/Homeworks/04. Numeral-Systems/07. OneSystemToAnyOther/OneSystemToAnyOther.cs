// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.WriteLine("Enter base for numeral system to convert from (36 >= s >= 2):");
        Console.Write("s = ");
        byte s = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter base for numeral system to convert to (d <= 16):");
        Console.Write("d = ");
        byte d = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number to be converted:");
        Console.Write("input: ");
        string numberIn = Console.ReadLine().ToUpper();

        if (s > 36 || s < 2 || d > 16)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            string convertedNumber = (ConvertFromDecimal(ConvertToDecimal(numberIn, s), d));
            Console.WriteLine("output: {0}", convertedNumber); 
        }
    }

    private static string ConvertFromDecimal(long decimalNumber, byte d)
    {
        string convertedNumber = string.Empty;

        if (decimalNumber == 0)
        {
            return Convert.ToString(decimalNumber);
        }

        while (decimalNumber > 0)
        {
            byte remainder = (byte)(decimalNumber % d);
            decimalNumber /= d;

            if ((remainder <= 9) && (remainder >= 0))
            {
                convertedNumber = (char)(remainder + '0') + convertedNumber;
            }
            else if ((remainder <= 36) && (remainder >= 10))
            {
                convertedNumber = (char)(remainder - 10 + 'A') + convertedNumber;
            }
        }

        return convertedNumber;
    }

    private static long ConvertToDecimal(string numberIn, byte s)
    {
        long decimalNumber = 0;

        for (int i = numberIn.Length - 1; i >= 0; i--)
        {
            if ((numberIn[i] >= '0') && (numberIn[i] <= '9'))
            {
                long multiplier = (long)Math.Pow(s, (numberIn.Length - 1 - i));
                decimalNumber += (numberIn[i] - '0') * multiplier;
            }
            else if ((numberIn[i] >= 'A') && (numberIn[i] <= 'Z'))
            {
                long multiplier = (long)Math.Pow(s, (numberIn.Length - 1 - i));
                decimalNumber += (numberIn[i] - 'A' + 10) * multiplier;
            }
        }

        return decimalNumber;
    }
}

