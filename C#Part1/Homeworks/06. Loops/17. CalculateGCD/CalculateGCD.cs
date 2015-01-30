using System;
class CalculateGCD
{
    static void Main()
    {
        // Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
        // Use the Euclidean algorithm (find it in Internet).

        Console.Write("Enter integer a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter integer b: ");
        int b = int.Parse(Console.ReadLine());
        int temporary;

        if ((a != 0) && (b != 0))
        {
            while (b != 0)
            {
                temporary = a % b;
                a = b;
                b = temporary;
            }
            Console.WriteLine("GCD(a, b) = {0}", Math.Abs(a));
        }
        else if ((a == 0) && (b != 0))
        {
            Console.WriteLine("GCD(a, b) = {0}", Math.Abs(b));
        }
        else if ((b == 0) && (a != 0))
        {
            Console.WriteLine("GCD(a, b) = {0}", Math.Abs(a));
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

