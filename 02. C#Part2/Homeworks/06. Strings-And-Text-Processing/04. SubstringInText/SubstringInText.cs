// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

namespace P04.SubstringInText
{
    using System;

    class SubstringInText
    {
        static void Main()
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter a substring:");
            string subString = Console.ReadLine();

            Console.WriteLine("This text contains substring \"{0}\" {1} times.", subString, CountSubstring(text, subString));
        }

        private static int CountSubstring(string text, string subString)
        {
            int count = 0;

            for (int i = 0; i < (text.Length - subString.Length + 1); i++)
            {
                if (text.Substring(i, subString.Length).ToLower().Equals(subString.ToLower()))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
