using System;

class QuadraticEquation
{
    static void Main()
    {
        // Write a program that reads the coefficients a, b and c of a quadratic equation 
        // ax^2 + bx + c = 0 and solves it (prints its real roots).

        Console.WriteLine("Enter value of \"a\";");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of \"b\";");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value of \"c\";");
        double c = double.Parse(Console.ReadLine());

        double discriminant = Math.Pow(b, 2) - (4 * a * c);

        if (discriminant < 0)
        {
            Console.WriteLine("No real roots.");
        }
        else if (discriminant > 0)
        {
            double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
        else
        {
            double x = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x);
        }
    }
}

