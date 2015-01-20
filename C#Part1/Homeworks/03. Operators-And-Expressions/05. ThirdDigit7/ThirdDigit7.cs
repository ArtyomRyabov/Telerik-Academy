using System;

class ThirdDigit7
{
    static void Main()
    {
        // Write an expression that checks for given integer if its third digit from right-to-left is 7.
        
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        bool check = (number % 1000) / 100 == 7;
        Console.WriteLine("Third digit from right-to-left is 7? \n{0}", check);
    }
}


