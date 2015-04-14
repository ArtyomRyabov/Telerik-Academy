using System;
using System.Collections.Generic;

class SubsetKwithSumS
{
    static void Main()
    {
        // Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
        // Find in the array a subset of K elements that have sum S or indicate about its absence.

        Console.WriteLine("Enter number for 'sum':");
        int wantedSum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements' number in 'sum':");
        int elementsNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array's number of elements:");
        int number = int.Parse(Console.ReadLine());

        int subsetsCounter = 0;
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
            if ((sum == wantedSum) && (subset.Count == elementsNumber))
            {
                subsetsCounter++;
                if (subsetsCounter == 1)
                {
                    Console.WriteLine("Yes, there is/are a subset(s) of {0} elements of the array that has sum ({1}):", 
                                        elementsNumber, wantedSum);
                }
                Console.WriteLine("Subset {0} ==> " + (string.Join(", ", subset)), subsetsCounter);
            }
            sum = 0;
            subset.Clear();
        }

        if (subsetsCounter == 0)
        {
            Console.WriteLine("No, there is not a subset of array's elements that has sum ({0}).", wantedSum);
        }
    }
}

