using System;

class NumberComparer
{
    static void Main()
    {
        // Write a program that gets two numbers from the console and prints the greater of them.
        // Try to implement this without if statements.

        Console.WriteLine("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is: {0}", Math.Max(a, b));
    }
}

