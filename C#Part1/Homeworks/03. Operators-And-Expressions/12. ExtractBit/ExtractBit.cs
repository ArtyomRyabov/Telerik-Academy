using System;

class ExtractBit
{
    static void Main()
    {
        // Write an expression that extracts from given integer n the value of given bit at index p.

        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.Write("Enter checked bit's position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int bit = (n & mask) >> p;
        Console.WriteLine("The bit at position '{0}' of number '{1}' is: '{2}'", p, n, bit);
    }
}

