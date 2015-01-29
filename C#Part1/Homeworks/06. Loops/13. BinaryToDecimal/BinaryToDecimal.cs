using System;
class BinaryToDecimal
{
    static void Main()
    {
        // Using loops write a program that converts a binary integer number to its decimal form.
        // The input is entered as string. The output should be a variable of type long.
        // Do not use the built-in .NET functionality.

        Console.Write("Enter a binary integer number: ");
        string binaryNumber = Console.ReadLine();
        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += byte.Parse(binaryNumber[i].ToString()) * (long)Math.Pow(2, ((binaryNumber.Length - 1) - i));
        }
        Console.WriteLine(decimalNumber);
    }
}

