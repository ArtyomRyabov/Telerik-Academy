// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

namespace P20.Palindromes
{
    using System;

    class Palindromes
    {
        static void Main()
        {
            string[] input = new string[] { "U2U3", "A Santa, lived! as a devil at NASA.", "so so", "Dammit, I'm mad!", 
                                            "ABBA", "a12345678987654321a", "Oh, No!" };
            ExtractPolindromes(input);
        }

        private static void ExtractPolindromes(string[] input)
        {
            Console.WriteLine("Polindromes extracted from the text:\n");

            foreach (string item in input)
            {
                string temp = item.Replace(" ", "").Replace(",", "").Replace("!", "").Replace(".", "").Replace("'", "").ToLower();

                if (isPalindrome(temp))
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
        }

        private static bool isPalindrome(string item)
        {
            for (int i = 0; i < item.Length / 2; i++)
            {
                if (item[i] != item[item.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
