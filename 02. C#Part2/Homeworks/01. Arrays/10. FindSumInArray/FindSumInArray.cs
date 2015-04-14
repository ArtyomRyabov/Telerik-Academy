using System;
using System.Collections.Generic;

class FindSumInArray
{
    static void Main()
    {
        // Write a program that finds in given array of integers a sequence of given sum S (if present).

        Console.WriteLine("Enter number for 'sum':");
        int S = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array's number of elements:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements:");
        int[] array = new int[number];
        int sum = 0;
        List<int> sumList = new List<int>();

        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sequences in the array with sum = {0}:", S);

        for (int i = 0; i < number; i++)
        {
            for (int j = i; j < number; j++)
            {
                sumList.Add(array[j]);
                sum += array[j];

                if ((sum == S) && (sumList.Count > 1))
                {
                    Console.WriteLine(string.Join(", ", sumList));
                }
                else
                {
                    continue;
                }
            }
            sum = 0;
            sumList.Clear();
        }
    }
}

