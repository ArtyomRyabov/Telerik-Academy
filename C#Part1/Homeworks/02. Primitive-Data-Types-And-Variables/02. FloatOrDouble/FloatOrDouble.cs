using System;

class FloatOrDouble
{
    static void Main()
    {
        // Which of the following values can be assigned to a variable of type float and which to a 
        // variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
        // Write a program to assign the numbers in variables and print them to ensure no precision is lost.

        double first = 34.567839023;
        Console.WriteLine("input:  34.567839023");
        Console.WriteLine("output: {0}", first);

        float second = 12.345f;
        Console.WriteLine("input:  12.345");
        Console.WriteLine("output: {0}", second);

        double third = 8923.1234857;
        Console.WriteLine("input:  8923.1234857");
        Console.WriteLine("output: {0}", third);

        float fourth = 3456.091f;
        Console.WriteLine("input:  3456.091");
        Console.WriteLine("output: {0}", fourth);
    }
}

