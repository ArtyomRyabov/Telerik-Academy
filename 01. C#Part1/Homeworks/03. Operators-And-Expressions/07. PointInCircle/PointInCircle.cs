using System;

class Program
{
    static void Main()
    {
        // Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

        Console.WriteLine("Enter (x, y) coordinates of a point:");
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        double radius = 2;
        bool result = Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2);
        Console.WriteLine("The point is in the circle: {0}", result);
    }
}

