// Write a program that reads a string, reverses it and prints the result at the console.

namespace P02.ReverseString
{
    using System;
    using System.Linq;

    class ReverseString
    {
        static void Main()
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();

            string reversed = new string(input.Reverse().ToArray());
            Console.WriteLine("Reversed: {0}", reversed);
        }
    }
}
