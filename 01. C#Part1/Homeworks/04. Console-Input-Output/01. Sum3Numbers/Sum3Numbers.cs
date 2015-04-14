using System;

class Sum3Numbers
{
    static void Main()
    {
        // Write a program that reads 3 real numbers from the console and prints their sum.

        Console.WriteLine("Enter 3 real numbers (a, b, c):");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("The sum of {0}, {1} and {2} is {3}.", a, b, c, sum);
    }
}

