using System;

class AllocateArray
{
    static void Main()
    {
        // Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
        // Print the obtained array on the console.

        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;

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


