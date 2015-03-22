namespace VersionAttribute
{
    using System;

    [Version(2, 02)]
    public class Test
    {
        public static void Main()
        {
            Type type = typeof(Test);
            object[] attributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine("Version {0}.{1}", attribute.Major, attribute.Minor);
            }

            Console.WriteLine();
        }
    }
}
