// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.

namespace P10.UnicodeCharacters
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Result: ");

            foreach (char item in input)
            {
                Console.Write(String.Format("\\u{0:x4}", (int)item));
            }

            Console.WriteLine();
        }
    }
}
