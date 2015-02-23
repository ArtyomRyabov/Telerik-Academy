//Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int number = int.Parse(Console.ReadLine());
        int digit = number % 10;
        int lastDigit = Math.Abs(digit);

        Console.WriteLine("The last digit as a word is: {0}", LastDigitAsWord(lastDigit));
    }

    private static string LastDigitAsWord(int lastDigit)
    {
        switch (lastDigit)
        {
            case 0:
                return "zero";
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return string.Empty;
        }
    }
}

