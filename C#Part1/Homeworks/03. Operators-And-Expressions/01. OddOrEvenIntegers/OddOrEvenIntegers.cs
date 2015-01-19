using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        // Write an expression that checks if given integer is odd or even.

        Console.WriteLine("Enter an integer:");
        int entered = int.Parse(Console.ReadLine());

        if (entered % 2 == 0)
        {
            Console.WriteLine("The integer is even.");
        }
        else
        {
            Console.WriteLine("The integer is odd.");
        }

        // another solution:
        Console.WriteLine();
        bool check = (entered % 2 != 0);
        Console.WriteLine("This is an odd integer: " + check);
    }
}

