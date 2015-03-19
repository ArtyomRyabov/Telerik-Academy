namespace StringBuilder.Extensions
{
    using System;
    using System.Text;

    public static class StringBuilderSubstringExtention
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder output = new StringBuilder();

            if ((index < 0) || (index >= input.Length))
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            if ((length < 0) || (index + length > input.Length))
            {
                throw new ArgumentOutOfRangeException("Length is out of range");
            }

            if ((index == 0) && (length == input.Length))
            {
                return input;
            }

            for (int i = index; i < index + length; i++)
            {
                output.Append(input[i]);
            }

            return output;
        }
    }
}
