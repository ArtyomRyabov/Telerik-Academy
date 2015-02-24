// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
// operation over the first letter of the string with the first of the key, the second – with the second, etc.
// When the last key character is reached, the next is the first.

namespace P07.EncodeDecode
{
    using System;
    using System.Text;

    class EncodeDecode
    {
        static void Main()
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the key:");
            string key = Console.ReadLine();

            string encoded = Encoding(input, key);
            Console.WriteLine("Encoded: {0}", encoded);
            Console.WriteLine("Decoded: {0}", Decoding(encoded, key));
        }

        private static string Decoding(string encoded, string key)
        {
            StringBuilder decoded = new StringBuilder();

            for (int i = 0; i < encoded.Length; i++)
            {
                decoded.Append((char)(encoded[i] ^ key[i % key.Length]));
            }

            return decoded.ToString();
        }

        private static string Encoding(string input, string key)
        {
            StringBuilder encoded = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                encoded.Append((char)(input[i] ^ key[i % key.Length]));
            }

            return encoded.ToString();
        }
    }
}
