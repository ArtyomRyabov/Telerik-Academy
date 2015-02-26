// Write a program that reads a string from the console and replaces all series of consecutive 
// identical letters with a single one.

namespace P23.SeriesOfLetters
{
    using System;
    using System.Text;

    class SeriesOfLetters
    {
        static void Main()
        {
            string input = "aaaaabbbbbcdddeeeedssaa" + "abcdedsa" + "aaaaabbbbbcdddeeeedssaa" + "abcdedsa";
            StringBuilder result = new StringBuilder();
           
            Console.WriteLine("Result: {0}", ReplaceLetters(input, result));
        }

        private static string ReplaceLetters(string input, StringBuilder result)
        {
            result.Append(input[0]);

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i + 1] != input[i])
                {
                    result.Append(input[i + 1]);
                }
            }

            return result.ToString();
        }
    }
}