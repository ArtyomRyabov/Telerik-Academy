using System;

class ModifyBit
{
    static void Main()
    {
        // We are given an integer number n, a bit value v (v=0 or 1) and a position p.
        // Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at 
        // the position p from the binary representation of n while preserving all other bits in n.

        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.Write("Enter checked bit's position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value (0 or 1) to hold on position 'p': ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int maskNumber;

        if (v == 0)
        {
            maskNumber = n & ~(mask);
        }
        else 
        {
            maskNumber = n | mask;
        }
        Console.WriteLine("Result: {0}", maskNumber);
        Console.WriteLine("Binary result:\n{0}", Convert.ToString(maskNumber, 2).PadLeft(32, '0'));
    }
}

