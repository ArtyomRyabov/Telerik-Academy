using System;

class NullValuesArithmetic
{
    static void Main()
    {
        // Create a program that assigns null values to an integer and to a double variable.
        // Try to print these variables at the console.
        // Try to add some number or the null literal to these variables and print the result.

        int? firstValue = null;
        double? secondValue = null;
        Console.WriteLine("Int with 'null' value: ", firstValue);
        Console.WriteLine("Double with 'null' value: ", secondValue);

        firstValue = 32;
        secondValue = 32.32;
        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);

        Console.WriteLine("The result of 32 + null is: {0}", firstValue + null);
        Console.WriteLine("The result of 32.32 + 13 is: {0}", secondValue + 13);
    }
}

