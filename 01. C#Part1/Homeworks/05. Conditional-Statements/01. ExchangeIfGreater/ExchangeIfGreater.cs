using System;

class ExchangeIfGreater
{
    static void Main()
    {
        // Write an if-statement that takes two double variables a and b and exchanges
        // their values if the first one is greater than the second one. As a result 
        // print the values a and b, separated by a space.

        Console.Write("Enter the first value: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second value: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }
        Console.WriteLine(a + " " + b);
    }
}
