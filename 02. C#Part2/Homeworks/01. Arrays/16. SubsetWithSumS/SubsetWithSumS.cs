using System;
using System.Collections.Generic;

class SubsetWithSumS
{
    static void Main()
    {
        // We are given an array of integers and a number S.
        // Write a program to find if there exists a subset of the elements of the array that has a sum S.

        Console.WriteLine("Enter number for 'sum':");
        int wantedSum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array's number of elements:");
        int number = int.Parse(Console.ReadLine());

        int counter = 0;
        int sum = 0;
        int[] array = new int[number];
        List<int> subset = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter element № {0}", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        int allSubsets = (int)Math.Pow(2, number) - 1;

        for (int i = 0; i < allSubsets; i++)
        {
            for (int j = 0; j <= number; j++)
            {
                int mask = (i & (1 << j));
                int bit = mask >> j;

                if (bit == 1)
                {
                    sum += array[j];
                    subset.Add(array[j]);
                }
            }
            if ((sum == wantedSum) && (subset.Count > 1))
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine("Yes, there is/are a subset(s) of array's elements that has sum ({0}):", wantedSum);
                }
                Console.WriteLine(string.Join(", ", subset));                
            }
            sum = 0;
            subset.Clear();
        }

        if (counter == 0)
        {
            Console.WriteLine("No, there is not a subset of array's elements that has sum ({0}).", wantedSum);
        }
    }
}

