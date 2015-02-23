// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

namespace P03.CorrectBrackets
{
    using System;

    class CorrectBrackets
    {
        static void Main()
        {
            Console.WriteLine("Enter an expression:");
            string input = Console.ReadLine();

            Console.WriteLine(CheckBrackets(input) ? "The brackets are put correctly!" : "The brackets are put incorrectly!"); 
        }

        private static bool CheckBrackets(string input)
        {
            int countOpeningBrackets = 0;
            int countClosingBrackets = 0;

            if (input.IndexOf(')') < input.IndexOf('('))
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (((i > 0) && (input[i] == ')') && (input[i - 1] != ')')) && (input[i - 1] < '0' || input[i - 1] > '9'))
                {
                    return false;
                }

                if (input[i] == '(')
                {
                    countOpeningBrackets++;
                }
                else if (input[i] == ')')
                {
                    countClosingBrackets++;
                }

                if (countClosingBrackets > countOpeningBrackets)
                {
                    return false;
                }
            }

            if ((countOpeningBrackets == countClosingBrackets) && (countOpeningBrackets > 0))
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
    }
}
