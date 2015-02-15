// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second integer:");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third integer:");
        int third = int.Parse(Console.ReadLine());

        int maxNumber = GetMaxNumber(GetMaxNumber(first, second), third);
        Console.WriteLine("The biggest number is: {0}", maxNumber);
    }

    static int GetMaxNumber(int one, int two)
    {
        if (one >= two)
        {
            return one;
        }
        else
        {
            return two;
        }
    }
}

