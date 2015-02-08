using System;
using System.Collections.Generic;

class FrequentNumber
{
    static void Main()
    {
        // Write a program that finds the most frequent number in an array.

        Console.WriteLine("Enter elements' number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements:");
        int[] array = new int[number];
        List<int> elements = new List<int>();
        int counter = 1;
        int maxcounter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());            
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    counter++;

                    if (counter == maxcounter)
                    {
                        elements.Add(array[i]);
                    }
                    if (counter > maxcounter)
                    {
                        maxcounter = counter;
                        elements.Clear();
                        elements.Add(array[i]);
                    }
                }
            }
            counter = 1;
        }

        Console.WriteLine("The most frequent number(s) in the array is (are):");

        foreach (int item in elements)
        {
            Console.WriteLine("{0} ({1} times)", item, maxcounter);
        }
    }
}

