using System;

class ExchangeVariableValues
{
    static void Main()
    {
        // Declare two integer variables a and b and assign them with 5 and 10 and after that 
        // exchange their values by using some programming logic.
        // Print the variable values before and after the exchange.

        int a = 5;
        int b = 10;
        Console.WriteLine("Before the exchange: a = {0} and b = {1}", a, b);
        a = a - b;
        b = a + b;
        a = b - a;
        Console.WriteLine("After the exchange: a = {0} and b = {1}", a, b);
    }
}

