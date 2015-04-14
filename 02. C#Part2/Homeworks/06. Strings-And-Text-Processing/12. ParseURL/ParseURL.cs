// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
// and extracts from it the [protocol], [server] and [resource] elements.

namespace P12.ParseURL
{
    using System;

    class ParseURL
    {
        static void Main()
        {
            Console.WriteLine("Enter a URL address:");
            string url = Console.ReadLine();

            int firstIndex = url.IndexOf(':');
            Console.WriteLine("[protocol] = {0}", url.Substring(0, firstIndex));

            int secondIndex = url.IndexOf("/", (firstIndex + 3));
            Console.WriteLine("[server] = {0}", url.Substring((firstIndex + 3), (secondIndex - (firstIndex + 3))));

            Console.WriteLine("[resource] = {0}", url.Substring(secondIndex));
        }
    }
}
