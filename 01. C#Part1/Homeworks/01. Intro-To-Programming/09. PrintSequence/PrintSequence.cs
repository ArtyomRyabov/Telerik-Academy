using System;

class PrintSequence
{
    static void Main()
    {
        // Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

        int num = 2;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i % 2 == 0 ? num : -num);
            num++;
        }
    }
}

