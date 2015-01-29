using System;
class DecimalToBinary
{
    static void Main()
    {
        // Using loops write a program that converts an integer number to its binary representation.
        // The input is entered as long. The output should be a variable of type string.
        // Do not use the built-in .NET functionality.

        Console.Write("Enter an integer number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string binaryNumber = "";

        if (decimalNumber == 0)
        {
            Console.WriteLine(decimalNumber);
            return;
        }

        while (decimalNumber > 0)
        {
            long remainder = decimalNumber % 2;
            decimalNumber /= 2;
            binaryNumber = remainder + binaryNumber;
        }
        Console.WriteLine(binaryNumber);
    }
}

