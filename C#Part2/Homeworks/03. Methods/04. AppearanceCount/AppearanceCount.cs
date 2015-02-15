// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Enter array's elements number:");
        int elementsNumber = int.Parse(Console.ReadLine());
        int[] array = new int[elementsNumber];

        FillTheArray(array);

        PrintArray(array);

        Console.WriteLine("Enter the element to count:");
        int countedElement = int.Parse(Console.ReadLine());

        int counter = ElementAppearances(array, countedElement);
        Console.WriteLine("Number ({0}) appears {1} time(s) in the array.", countedElement, counter);

        // test "ElementAppearances Method"
        Console.WriteLine();
        Console.WriteLine(new String('-', 40));
        Console.WriteLine();

        Console.WriteLine(@"An array includes { 5, 5, 5, 5, 5, 5 }. 
It will be tested with ""ElementAppearances Method"", 
to see if the last one is working properly.");
        Console.WriteLine();

        int[] testArray = new int[] { 5, 5, 5, 5, 5, 5 };

        if ((counter = ElementAppearances(testArray, 5)) == 6)
        {
            Console.WriteLine("Result: Test counter = {0} => \"ElementAppearances Method\" is working properly.", 
                              (counter = ElementAppearances(testArray, 5)));
        }
        else
        {
            Console.WriteLine("Result: Test counter = {0} => ElementAppearances Method is NOT working properly.",
                              (counter = ElementAppearances(testArray, 5)));
        }
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

    private static int ElementAppearances(int[] array, int countedElement)
    {
        int counter = 0;

        foreach (int element in array)
        {
            if (element == countedElement)
            {
                counter++;
            }
        }

        return counter;
    }

    private static void PrintArray(int[] array)
    {
        Console.WriteLine("The array is: {0}", string.Join(", ", array));
    }
}

