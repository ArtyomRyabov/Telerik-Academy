namespace StringBuilder.Substring
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

            test = test.Substring(0, 31);      // Must return Substring equal to the original StringBuilder
            Console.WriteLine(test);

            test = test.Substring(22, 9);      // Must return "Substring"
            Console.WriteLine(test);               

            test = test.Substring(5, 0);       // Must return null
            Console.WriteLine(test);
        }
    }
}
