using System;
using System.Collections.Generic;

class MaximalSequence
{
    static void Main()
    {
        // Write a program that finds the maximal sequence of equal elements in an array.

        Console.WriteLine("Enter the number of elements in an array:");
        int number = int.Parse(Console.ReadLine());

        int[] array = new int[number];
        List<int> intList = new List<int>();
        int maxElement = 0;
        int counter = 0;
        int maxCount = 0;
        int current = 0;
        Console.WriteLine("Enter the elements:");

        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

            if (array[i] == current)
            {
                counter++;
                if (counter == maxCount)
                {
                    maxCount = counter;
                    maxElement = array[i];
                    intList.Add(array[i]);
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    maxElement = array[i];
                    intList.Clear();
                    intList.Add(array[i]);
                }
            }
            else
            {
                counter = 1;
                current = array[i];
            }
        }

        Console.WriteLine("The maximal sequence of equal elements in the array:");

        foreach (int element in intList)
        {
            for (int i = 0; i < maxCount; i++)
            {
                if (i < maxCount - 1)
                {
                    Console.Write("{0}, ", element);
                }
                else
                {
                    Console.WriteLine("{0}", element);
                }
            }
        }
    }
}

