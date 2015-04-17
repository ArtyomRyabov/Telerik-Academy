namespace TheLongestString
{
    using System;
    using System.Linq;

    public class LongestString
    {
        public static void Main()
        {
            string[] array = { "string", "longer string", "the longest string", "this is the longest string" };

            string longest = TheLongestString(array);
            Console.WriteLine(longest);
        }

        public static string TheLongestString(string[] input)
        {
            string result = (from s in input
                             orderby s.Length descending
                             select s).FirstOrDefault();

            return result;
        }
    }
}
