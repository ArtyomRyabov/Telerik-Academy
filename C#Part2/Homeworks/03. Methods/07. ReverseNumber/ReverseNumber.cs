// Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine(ReversedecimalNumber(number)); 
    }

    private static decimal ReversedecimalNumber(decimal number)
    {
        char[] array = number.ToString().ToCharArray();
        char[] reversedArray = new char[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[array.Length - 1 - i] = array[i];
        }

        string reversedString = new string(reversedArray);
        decimal reversedDecimal = decimal.Parse(reversedString);
        return reversedDecimal;
    }
}

