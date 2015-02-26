// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

namespace P20.Palindromes
{
    using System;
    using System.Linq;

    class Palindromes
    {
        static void Main()
        {
            string text = "U2U2@A Santa lived as a devil at NASA.@so sos@Dammit, I'm mad!@" +
                                            "ABBA@a12345678987654321a@Oh, No!";
            string[] input = text.Split('@').ToArray();

            ExtractPolindromes(input);
        }

        private static void ExtractPolindromes(string[] input)
        {
            Console.WriteLine("Polindromes extracted from the input:\n");

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
