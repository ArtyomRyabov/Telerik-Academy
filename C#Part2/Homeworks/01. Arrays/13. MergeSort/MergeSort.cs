using System;

class MergeSort
{
    static void Main()
    {
        // Write a program that sorts an array of integers using the Merge sort algorithm.

        Console.WriteLine("Enter number of elements of the array:");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        array = Splits(array);
        Console.WriteLine("After sorting: {0}", string.Join(", ", array));
    }

    static int[] Splits(int[] array)
    {
        if (array.Length == 1)
        {
            return array;
        }

        int middle = array.Length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[array.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = array[i];
        }

        for (int i = middle, j = 0; i < array.Length; i++, j++)
        {
            rightArray[j] = array[i];
        }

        leftArray = Splits(leftArray);
        rightArray = Splits(rightArray);
        return Merge(leftArray, rightArray);
    }

    static int[] Merge(int[] left, int[] right)
    {
        int leftIndex = 0;
        int rightIndex = 0;
        int[] array = new int[left.Length + right.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (rightIndex == right.Length)
            {
                array[i] = left[leftIndex];
                leftIndex++;
            }
            else if ((leftIndex < left.Length) && (left[leftIndex] <= right[rightIndex]))
            {
                array[i] = left[leftIndex];
                leftIndex++;
            }

            else if (leftIndex == left.Length)
            {
                array[i] = right[rightIndex];
                rightIndex++;
            }
            else if ((rightIndex < right.Length) && (left[leftIndex] >= right[rightIndex]))
            {
                array[i] = right[rightIndex];
                rightIndex++;
            }
        }
        return array;
    }
}

