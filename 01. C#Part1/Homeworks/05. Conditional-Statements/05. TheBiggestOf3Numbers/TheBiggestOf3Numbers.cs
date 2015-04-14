using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        // Write a program that finds the biggest of three numbers.

        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("The biggest number is: " + a);
        }
        else if (a <= c && b <= c)
        {
            Console.WriteLine("The biggest number is: " + c);
        }
        else if (a <= b && b >= c)
        {
            Console.WriteLine("The biggest number is: " + b);
        }
    }
}

