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


        Console.WriteLine("Last digit as a word is: {0}", LastDigitAsWord(lastDigit));
    }

    private static string LastDigitAsWord(int lastDigit)
    {
        switch (lastDigit)
        {
            case 0:
                return "zero";
                break;
            case 1:
                return "one";
                break;
            case 2:
                return "two";
                break;
            case 3:
                return "three";
                break;
            case 4:
                return "four";
                break;
            case 5:
                return "five";
                break;
            case 6:
                return "six";
                break;
            case 7:
                return "seven";
                break;
            case 8:
                return "eight";
                break;
            case 9:
                return "nine";
                break;
            default:
                return string.Empty;
        }
    }
}

