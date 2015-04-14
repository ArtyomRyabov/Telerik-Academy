using System;

class ExtractThirdBit
{
    static void Main()
    {
        // Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
        // The bits are counted from right to left, starting from bit #0.
        // The result of the expression should be either 1 or 0.

        Console.Write("Enter an unsigned integer: ");
        int number = int.Parse(Console.ReadLine());

        int bitPosition = 3;
        int mask = 1 << bitPosition;
        int numberAndMask = number & mask;
        int bitValue = numberAndMask >> bitPosition;
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The third bit of {0} is: {1}", number, bitValue);

        // short solution:
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The third bit of {0} is: {1}", number, ((number >> 3) & 1));
    }
}

