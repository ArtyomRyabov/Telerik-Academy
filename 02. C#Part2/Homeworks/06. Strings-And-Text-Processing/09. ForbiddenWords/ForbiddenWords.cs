// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

namespace P09.ForbiddenWords
{
    using System;

    class ForbiddenWords
    {
        static void Main()
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine("\nEnter the forbidden words, separated by space:");
            string[] words = Console.ReadLine().ToLower().Split(' ', ',', '.');

            Console.WriteLine("\nResult:");
            Console.WriteLine(ChangeForbiddenWords(text, words));
        }

        private static string ChangeForbiddenWords(string text, string[] words)
        {
            foreach (string word in words)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            return text;
        }
    }
}
