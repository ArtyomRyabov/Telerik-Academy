using System;

class SelectionSort
{
    static void Main()
    {
        // Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        // Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
        // smallest from the rest, move it at the second position, etc. 3,2,1,4,5,6

        Console.WriteLine("Enter number of elements:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements:");
        int[] array = new int[number];
        int temporary;

        for (int i = 0; i < number; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                temporary = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temporary;
            }
        }

        Console.Write("Result: ");

        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1)
            {
                Console.Write("{0}, ", array[i]);
            }
            else
            {
                Console.WriteLine("{0}", array[i]);
            }
        }
    }
}

