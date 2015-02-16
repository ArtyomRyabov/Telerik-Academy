// Write a method that adds two positive integer numbers represented as arrays of digits 
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;

class NumberAsArray
{
    static void Main()
    {
        Console.WriteLine("Enter the first psitive integer number:");
        string firstNumber = Console.ReadLine();
        Console.WriteLine("Enter the second psitive integer number:");
        string secondNumber = Console.ReadLine();
        List<int> firstSecond = new List<int>();

        int[] first = new int[firstNumber.Length];
        ReverseTheArray(first, firstNumber);
        int[] second = new int[secondNumber.Length];
        ReverseTheArray(second, secondNumber);

        int longestLength = 0;
        if (first.Length >= second.Length)
        {
            longestLength = first.Length;
        }
        else
        {
            longestLength = second.Length;
        }

        SumArrays(first, second, firstSecond, longestLength);

    }

    private static void SumArrays(int[] first, int[] second, List<int> firstSecond, int longestLength)
    {
        int remainder = 0;

        for (int i = 0; i < longestLength; i++)
        {
            if (i >= second.Length)
            {
                firstSecond.Add((first[i] % 10) + remainder);
                remainder = 0;
            }
            else  if (i >= first.Length)
            {
                firstSecond.Add((second[i] % 10) + remainder);
                remainder = 0;
            }
            else
            {
                firstSecond.Add((first[i] + second[i] + remainder) % 10);
            }

            if ((i < first.Length) && (i < second.Length))
            {
                if (first[i] + second[i] + remainder < 10)
                {
                    remainder = 0;
                }
                else
                {
                    remainder = 1;
                }  
            }
        }

        if (remainder == 1)
        {
            firstSecond.Add(remainder);
        }

        firstSecond.Reverse();
        Console.WriteLine("Result: {0}", string.Join(", ", firstSecond));
    }

    private static void ReverseTheArray(int[] array, string str)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[array.Length - 1 - i] = int.Parse(str[i].ToString());
        }

        Console.WriteLine(string.Join(", ", array));
    }
}

