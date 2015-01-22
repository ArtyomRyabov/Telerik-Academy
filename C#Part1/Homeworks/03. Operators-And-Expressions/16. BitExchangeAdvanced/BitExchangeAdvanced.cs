using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        // Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a 
        // given 32-bit unsigned integer.The first and the second sequence of bits may not overlap.

        Console.Write("Enter an unsignet integer: ");
        string str = Console.ReadLine();
        uint n;
        if (uint.TryParse(str, out n))
        {
            Console.WriteLine("Valid number!");
        }
        else
        {
            Console.WriteLine("Out of range!");
            return;
        }
        Console.WriteLine("Binary representation of number:\n{0}", Convert.ToString(n, 2).PadLeft(32, '0'));

        Console.Write("Enter number [0-31] for the first position (p): ");
        byte p = byte.Parse(Console.ReadLine());
        Console.Write("Enter number [0-31] for the second position (q): ");
        byte q = byte.Parse(Console.ReadLine());
        Console.Write("Number of bits to be changed: ");
        byte k = byte.Parse(Console.ReadLine());

        if (((p + k) > 32) || ((q + k) > 32))
        {
            Console.WriteLine("Out of range!");
            return;
        }
        else if ((p < q) && (p + k >= q) || (q < p) && (q + k >= p) || (p == q))
        {
            Console.WriteLine("Overlapping!");
            return;
        }

        int i;
        uint mask;
        uint bitP;
        uint bitQ;

        for (i = 0; i <= (k-1); i++)
        {
            mask = 1u << (p + i);
            bitP = (mask & n) >> (p + i);
            mask = 1u << (q + i);
            bitQ = (mask & n) >> (q + i);

            if (bitP == 0)
            {
                mask = ~(1u << (q + i));
                n = n & mask;
            }
            else if (bitP == 1)
            {
                mask = 1u << (q + i);
                n = n | mask;
            }
            if (bitQ == 0)
            {
                mask = ~(1u << (p + i));
                n = n & mask;
            }
            else if (bitQ == 1)
            {
                mask = 1u << (p + i);
                n = n | mask;
            }
        }
        Console.WriteLine("Result: {0}", n);
        Console.WriteLine("Binary representation of number:\n{0}", Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}

