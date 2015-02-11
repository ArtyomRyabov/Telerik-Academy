using System;
using System.Collections.Generic;

class RemoveElementsFromArray
{
    static void Main()
    {
        // Write a program that reads an array of integers and removes from it a minimal number of elements in such a way 
        // that the remaining array is sorted in increasing order. Print the remaining sorted array.

        Console.WriteLine("Enter array's number of elements:");
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        List<int> finalList = new List<int>();
        List<int> currentList = new List<int>();
        int counter = 0;
        int maxCounter = 0;
        int lastMember = 0;
        int all = Math.Pow(2, number) - 1;

        for (int i = 1; i <= all; i++)
        {
            for (int j = 0; j < number; j++)
            {
                int mask = 1 & (i >> j);

                if (mask == 1)
                {
                    if (counter == 0)
                    {
                        lastMember = array[j];
                        currentList.Add(array[j]);
                        counter++;
                    }
                    else
                    {
                        if (array[j] >= lastMember)
                        {
                            lastMember = array[j];
                            currentList.Add(array[j]);
                            counter++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            if (counter > maxCounter)
            {
                finalList.Clear();
                finalList.AddRange(currentList);
                currentList.Clear();
                maxCounter = counter;
            }
            counter = 0;
            lastMember = 0;
            currentList.Clear();
        }

        Console.WriteLine("Remaining sorted array is: {0}", string.Join(", ", finalList));
    }
}

