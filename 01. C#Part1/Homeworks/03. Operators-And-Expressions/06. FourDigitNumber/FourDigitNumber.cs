using System;

class FourDigitNumber
{
    static void Main()
    {
        /* Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
         *     Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
         *     Prints on the console the number in reversed order: dcba (in our example 1102).
         *     Puts the last digit in the first position: dabc (in our example 1201).
         *     Exchanges the second and the third digits: acbd (in our example 2101).
         *  The number has always exactly 4 digits and cannot start with 0.
         */

        Console.Write("Input a four-digit number: ");
        int number = int.Parse(Console.ReadLine());

        int a = number / 1000;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;

        if ((number > 9999) | (number < 1000))
        {
            Console.WriteLine("Invalid number!");
            return;
        }

        Console.WriteLine("The sum of the digits is: {0}", a + b + c + d);
        Console.WriteLine("Reversed order of the digits: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("The number with last digit in front: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("The number with exchanged second and third digits: {0}{1}{2}{3}", a, c, b, d);
    }
}

