// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace P24.OrderWords
{
    using System;

    class OrderWords
    {
        static void Main()
        {
            string input = "Write a program that reads a list of words separated by " +
                           "spaces and prints the list in an alphabetical order";
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);

            Console.WriteLine("Input:\n" + input);
            Console.WriteLine("\nOutput:\n{0}\n", string.Join(" ", words));
        }
    }
}
