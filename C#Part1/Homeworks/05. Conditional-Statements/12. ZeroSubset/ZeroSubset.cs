using System;

class ZeroSubset
{
    static void Main()
    {
        // We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
        // Assume that repeating the same subset several times is not a problem.

        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        int e = int.Parse(Console.ReadLine());

        int zeroSum = 0;

        if (a + b == 0)
        {
            Console.WriteLine("Result: {0} + {1} = 0", a, b);
            zeroSum++;
        }
        if (a + c == 0)
        {
            Console.WriteLine("Result: {0} + {1} = 0", a, c);
            zeroSum++;
        }
        if (a + d == 0)
        {
            Console.WriteLine("Result: {0} + {1} = 0", a, d);
            zeroSum++;
        }
        if (a + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} = 0", a, e);
            zeroSum++;
        }
        if (b + c == 0)
        {
            Console.WriteLine("Result: {0} + {1} = 0", b, c);
            zeroSum++;
        }
        if (b + d == 0)
        {
            Console.WriteLine("Result: {0} + {1} = 0", b, d);
            zeroSum++;
        }
        if (b + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} = 0", b, e);
            zeroSum++;
        }
        if (c + d == 0)
        {
            Console.WriteLine("Result: {0} + {1} = 0", c, d);
            zeroSum++;
        }
        if (c + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} = 0", c, e);
            zeroSum++;
        }
        if (d + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} = 0", d, e);
            zeroSum++;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} = 0", a, b, c);
            zeroSum++;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} = 0", a, b, d);
            zeroSum++;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} = 0", a, b, e);
            zeroSum++;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} = 0", a, c, d);
            zeroSum++;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} = 0", a, c, e);
            zeroSum++;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} = 0", a, d, e);
            zeroSum++;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} = 0", b, c, d);
            zeroSum++;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} = 0", b, c, e);
            zeroSum++;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} = 0", b, d, e);
            zeroSum++;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} = 0", c, d, e);
            zeroSum++;
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} + {3} = 0", a, b, c, d);
            zeroSum++;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} + {3} = 0", a, b, c, e);
            zeroSum++;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} + {3} = 0", a, b, d, e);
            zeroSum++;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} + {3} = 0", a, c, d, e);
            zeroSum++;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} + {3} = 0", b, c, d, e);
            zeroSum++;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("Result: {0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            zeroSum++;
        }
        if (zeroSum == 0)
        {
            Console.WriteLine("No zero subset!");
        }
    }
}


