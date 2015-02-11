using System;

class QuickSort
{
    static void Main()
    {
        // Write a program that sorts an array of strings using the Quick sort algorithm.

        Console.WriteLine("Enter array's number of elements:");
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];

        Console.WriteLine("Enter the array:");
        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Quicksort(array, 0, array.Length - 1);

        Console.WriteLine("After sorting: {0}", string.Join(", ", array));
    }

    static void Quicksort(int[] array, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = array[left + (right - left) / 2];

        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }
            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int swap = array[i];
                array[i] = array[j];
                array[j] = swap;
                i++;
                j--;
            }
        }
        if (left < j)
        {
            Quicksort(array, left, j);
        }
        if (i < right)
        {
            Quicksort(array, i, right);
        }
    }
}

