using System;

class DivideBy7And5
{
    static void Main()
    {
        // Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
        // by 7 and 5 at the same time.

        Console.Write("Enter an integer to check: ");
        int number = int.Parse(Console.ReadLine());
        bool check = (number % 5 == 0) && (number % 7 == 0);
        Console.WriteLine("{0} can be divided (without remainder) by 7 and 5 at the same time: {1}", number, check);

    }
}

