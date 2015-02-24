// Write a program that reads from the console a string of maximum 20 characters. If the length of the string is 
// less than 20, the rest of the //characters should be filled with *. Print the result string into the console.

namespace P06.StringLength
{
    using System;

    class StringLength
    {
        static void Main()
        {
            Console.WriteLine("Enter a string (maximum 20 characters):");
            string input = Console.ReadLine();

            Console.WriteLine("Result: {0}", CheckString(input));
        }

        private static string CheckString(string input)
        {
            if (input.Length >= 20)
            {
                input = input.Substring(0, 20);
            }
            else
            {
                input = input.PadRight(20, '*');
            }

            return input;
        }
    }
}
