namespace StringBuilder.Extensions
{
    using System;
    using System.Text;

    public class Test
    {
        public static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.Append("Testing StringBuilder.Substring");
            Console.WriteLine(test);

            test = test.Substring(0, 31);    
            Console.WriteLine(test);               // Must return the original substring

            test = test.Substring(22, 9);
            Console.WriteLine(test);               // Must return "Substring"

            test = test.Substring(5, 0);       // Must return null
            Console.WriteLine(test);
        }
    }
}
