using System;
using System.Collections.Generic;

class MaximalSum
{
    static void Main()
    {
        // Write a program that finds the sequence of maximal sum in given array.

        Console.WriteLine("Enter number of elements:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements:");
        int[] array = new int[number];
        int currentSum = 0;
        int maxSum = 0;
        List<int> currentList = new List<int>();
        List<int> finalList = new List<int>();

        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < number; i++)
        {
            for (int j = i; j < number; j++)
            {
                currentSum += array[j];
                currentList.Add(array[j]);

                if (currentSum > maxSum)
                {
                    finalList.Clear();
                    maxSum = currentSum;
                    finalList.AddRange(currentList);
                }
            }
            currentSum = 0;
            currentList.Clear();
        }

        Console.Write("Result: ");

        for (int i = 0; i < finalList.Count; i++)
        {
            if (i == (finalList.Count - 1))
            {
                Console.WriteLine(finalList[i]);
            }
            else
            {
                Console.Write(finalList[i] + ", ");
            }
        }
    }
}

