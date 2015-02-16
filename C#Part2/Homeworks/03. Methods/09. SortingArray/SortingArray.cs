// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

using System;

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Enter array's elements number:");
        int elementsNumber = int.Parse(Console.ReadLine());
        int[] array = new int[elementsNumber];

        FillTheArray(array);

        PrintArray(array);

        Console.WriteLine("Enter index to find max element from index to the end of the array:");
        int index = int.Parse(Console.ReadLine());
        int maxIndex = ArrayMaxElement(array, index);
        int maxElement = array[maxIndex];
        Console.WriteLine("The maximal element is: {0}", maxElement);

        SortDescending(array);

        SortAscending(array);
    }

    private static void SortAscending(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int temp = array[i];
            array[i] = array[ArrayMaxElement(array, array.Length - 1 - i)];
            array[ArrayMaxElement(array, array.Length - 1 - i)] = temp;
        }

        Console.WriteLine("The array sorted ascending: {0}", string.Join(", ", array));
    }

    private static void SortDescending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int temp = array[i];
            array[i] = array[ArrayMaxElement(array, i)];
            array[ArrayMaxElement(array, i)] = temp;
        }

        Console.WriteLine("The array sorted descending: {0}", string.Join(", ", array));
    }

    private static int ArrayMaxElement(int[] array, int index)
    {
        int maxElement = int.MinValue;
        int maxIndex = 0;

        for (int i = array.Length -1; i >= index; i--)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    private static void FillTheArray(int[] array)
    {
        Console.WriteLine("Enter array's elements:");
        int element = 0;

        for (int i = 0; i < array.Length; i++)
        {
            element = int.Parse(Console.ReadLine());
            array[i] = element;
        }
    }

    private static void PrintArray(int[] array)
    {
        Console.WriteLine("The array is: {0}", string.Join(", ", array));
    }
}

