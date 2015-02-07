using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
{
    static void Main()
    {
        // Write a program that finds the maximal increasing sequence in an array.

        Console.WriteLine("Enter the number of elements in an array:");
        int number = int.Parse(Console.ReadLine());

        List<int> intList = new List<int>();
        int counter = 1;
        int maxCounter = 1;
        int minValue = 0;
        int maxValue = 0;
        int[] array = new int[number];
        Console.WriteLine("Enter the elements:");

        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                continue;
            }
            else
            {
                if (array[i] - array[i - 1] == 1)
                {
                    maxValue = array[i];
                    counter++;
                    if (counter == maxCounter)
                    {
                        intList.Add(array[i]);
                    }
                    if (counter > maxCounter)
                    {
                        intList.Clear();
                        intList.Add(array[i]);
                        maxCounter = counter;
                    }
                }
                else
                {
                    minValue = array[i];
                    counter = 1;
                }
            }
        }

        foreach (int element in intList)
        {
            for (int i = (element - (maxCounter - 1)); i <= element; i++)
            {
                if (i < (element))
                {
                    Console.Write("{0}, ", i);
                }
                else
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}

