namespace StringBuilder.Substring
{
    using System;
    using System.Text;

    public static class StringBuilderSubstringExtention
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder output = new StringBuilder();

            if ((index == 0) && (length == input.Length))
            {
                return input;
            }

            try
            {
                for (int i = index; i < index + length; i++)
                {
                    output.Append(input[i]);
                }
            }
            catch (IndexOutOfRangeException eore)
            {
                Console.WriteLine(eore);         // (index < 0) || (index >= input.Length)
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine(aore);         // (length < 0) || (index + length > input.Length)
            }

            return output;
        }
    }
}
