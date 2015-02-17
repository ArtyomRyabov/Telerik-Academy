// Write a method that returns the index of the first element in array that is larger than its neighbours, 
// or -1, if there’s no such element. Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter array's elements number:");
        int elementsNumber = int.Parse(Console.ReadLine());
        int[] array = new int[elementsNumber];

        FillTheArray(array);

        PrintArray(array);

        CheckFirstLargerThanNeighbours(array);
    }

    private static void CheckFirstLargerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if ((i > 0) && (i < array.Length - 1) && (LargerThanNeighbours.IfLargerThanNeighbours(array, i)))
            {
                Console.Write("The index of the first element in array that is larger than its neighbours is: {0}", i);
                return;
            }
        }

        Console.WriteLine("-1 (There is no element that is larger than its neighbours.)");
    }

    //private static bool IfLargerThanNeighbours(int[] array, int i)
    //{
    //    bool result = ((array[i] > array[i - 1]) && (array[i] > array[i + 1]));
    //    return result;
    //}

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

