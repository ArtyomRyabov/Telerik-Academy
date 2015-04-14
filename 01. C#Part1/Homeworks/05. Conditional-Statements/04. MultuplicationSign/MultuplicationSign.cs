using System;

class MultuplicationSign
{
    static void Main()
    {
        // Write a program that shows the sign (+, - or 0) of the product of 
        // three real numbers, without calculating it.
        // Use a sequence of if operators.

        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        int sign = 0;

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Result: {0}", "0");
        }
        else
        {    
            if (a < 0)
            {
                sign++;
            }
            if (b < 0)
            {
                sign++;
            }
            if (c < 0)
            {
                sign++;
            }
            if (sign % 2 == 0)
            {
                Console.WriteLine("Result: {0}", "+");
            }
            else
            {
                Console.WriteLine("Result: {0}", "-");
            }
        }
    }
}

