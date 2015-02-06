using System;

class CompareArrays
{
    static void Main()
    {
        // Write a program that reads two integer arrays from the console and compares them element by element.

        Console.WriteLine("Enter two integer arrays (number > 0):");
        int first = int.Parse(Console.ReadLine());
        int[] firstArray = new int[first];
        int second = int.Parse(Console.ReadLine());
        int[] secondArray = new int[second];

        Console.WriteLine("Enter the elements of the first array:");

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the elements of the second array:");

        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        int counter = 0;

        for (int i = 0; i < firstArray.Length; i++)
        {
            for (int j = 0; j < secondArray.Length; j++)
            {
                if ((firstArray[i] == secondArray[j]) && (i == j))
                {
                    counter++;
                    Console.WriteLine("The arrays have equal element ({0}) at equal index {1}.", firstArray[i], i);
                }
                if ((firstArray[i] == secondArray[j]) && (i != j))
                {
                    counter++;
                    Console.WriteLine("The arrays have equal element ({0}) at index {1} (for the first) and {2} (for the second).",
                                      firstArray[i], i, j);
                }
            }
        }
        if ((firstArray.Length == secondArray.Length) && (counter == (firstArray.Length)))
        {
            Console.WriteLine("The arrays have equal length and elements.");
        }
        if ((firstArray.Length == secondArray.Length) && (counter != (firstArray.Length)))
        {
            Console.WriteLine("The arrays have equal length, but different elements.");
        }
        if ((firstArray.Length != secondArray.Length) && (counter == 0))
        {
            Console.WriteLine("The arrays have different length and zero equal elements.");
        }
        if ((firstArray.Length != secondArray.Length) && (counter != 0))
        {
            Console.WriteLine("The arrays have different length.");
        }
    }
}

