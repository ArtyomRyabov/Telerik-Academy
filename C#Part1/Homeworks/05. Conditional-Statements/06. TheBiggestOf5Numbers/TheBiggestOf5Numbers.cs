using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        // Write a program that finds the biggest of five numbers by using only five if statements.

        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        double e = double.Parse(Console.ReadLine());
       
        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine("The biggest number is: {0}", a);
        }
        else if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine("The biggest number is: {0}", b);
        }
        else if (a <= c && b <= c && c >= d && c >= e)
        {
            Console.WriteLine("The biggest number is: {0}", c);
        }
        else if (a <= d && b <= d && c <= d && d >= e)
        {
            Console.WriteLine("The biggest number is: {0}", d);
        }
        else if (a <= e && b <= e && c <= e && d <= e)
        {
            Console.WriteLine("The biggest number is: {0}", e);
        }
    }
}

