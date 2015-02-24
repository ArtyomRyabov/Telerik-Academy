// Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
// percentage and in scientific notation. Format the output aligned right in 15 symbols.

namespace P11.FormatNumber
{
    using System;

    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine("{0,15:D} (decimal)", number);
            Console.WriteLine("{0,15:X} (hexadecimal)", number);
            Console.WriteLine("{0,15:P} (percentage)", number / (double)100);
            Console.WriteLine("{0,15:E} (scientific notation)", number);
        }
    }
}
