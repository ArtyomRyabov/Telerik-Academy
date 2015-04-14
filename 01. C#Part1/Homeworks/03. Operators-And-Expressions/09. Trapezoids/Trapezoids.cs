using System;

class Trapezoids
{
    static void Main()
    {
        // Write an expression that calculates trapezoid's area by given sides a and b and height h.

        Console.Write("Enter number for side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number for side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number for height h: ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("Trapezoid's area with sides {0} and {1} and height {2} is: {3}", a, b, h, area);
    }
}

