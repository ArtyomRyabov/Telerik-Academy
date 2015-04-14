using System;

class CompareCharArrays
{
    static void Main()
    {
        // Write a program that compares two char arrays lexicographically (letter by letter).

        Console.WriteLine("Enter the first array:");
        string first = Console.ReadLine();
        char[] firstArray = first.ToCharArray();
        Console.WriteLine("Enter the second array:");
        string second = Console.ReadLine();
        char[] secondArray = second.ToCharArray();

        if (firstArray.Length >= secondArray.Length)
        {
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("The second array is before the first.");
                    return;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first array is before the second.");
                    return;
                }
            }
            if (firstArray.Length == secondArray.Length)
            {
                Console.WriteLine("The two arrays are equal.");
            }
            else
            {
                Console.WriteLine("The second array is before the first.");
            }
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("The second array is before the first.");
                    return;
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first array is before the second.");
                    return;
                }
            }
            Console.WriteLine("The first array is before the second.");
        }
    }
}

