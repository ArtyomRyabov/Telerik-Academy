using System;

class CheckBit
{
    static void Main()
    {
        // Write a Boolean expression that returns if the bit at position p (counting from 0, 
        // starting from the right) in given integer number n, has value of 1.

        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.Write("Enter checked bit's position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        bool isZero = (mask & n) == 0;
        Console.WriteLine("The bit at position {0} is '1': {1}", p, !(isZero));
    }
}

