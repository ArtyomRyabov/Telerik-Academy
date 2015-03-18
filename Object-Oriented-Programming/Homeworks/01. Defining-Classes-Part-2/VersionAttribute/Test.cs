namespace VersionAttribute
{
    using System;

    [Version("Test", "0.02")]
    [Version("Test", "0.01")]
    public class Test
    {
        public static void Main()
        {
            Type type = typeof(Test);
            object[] attributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine("Name: {0} / Version {1}", attribute.Name, attribute.Version);
            }
        }
    }
}
