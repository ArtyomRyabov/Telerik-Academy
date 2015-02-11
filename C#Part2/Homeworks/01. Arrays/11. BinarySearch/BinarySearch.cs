using System;

class BinarySearch
{
    static void Main()
    {
        // Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm

        Console.WriteLine("Enter number of elements of the array:");
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the element to find its index:");
        int element = int.Parse(Console.ReadLine());

        Array.Sort(array);
        Console.WriteLine("Sorted array is: {0}", (string.Join(", ", array)));

        int index = BinSearch(array, element);
        Console.WriteLine((index > -1) ? ("The index is of element ({0}) is: {1}"): ("Invalid input!"),element, index);
    }

    public static int BinSearch(int[] array, int element)
    {
        int start = 0;
        int end = (array.Length - 1);

        while (start <= end)
        {
            int middle = (start + end) / 2;
            if (array[middle] == element)
            {
                return middle;
            }
            else if (array[middle] > element)
            {
                end = middle - 1;
            }
            else
            {
                start = middle + 1;
            }
        }
        return -1;
    }
}

