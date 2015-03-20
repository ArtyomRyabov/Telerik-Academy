namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            List<int> intCollection = new List<int>() { 10, 20, 30, 40, 50 };
            Console.WriteLine("Collection contains: {0}", string.Join(" ", intCollection));
            Console.WriteLine("Sum of collection's items: {0}", intCollection.Sum());
            Console.WriteLine("Product of collection's items: {0}", intCollection.Product());
            Console.WriteLine("Collection's minimal item is: {0}", intCollection.Min());
            Console.WriteLine("Collection's maximal item is: {0}", intCollection.Max());
            Console.WriteLine("Collection's average value is: {0}\n", intCollection.Average());

            List<decimal> decimalCollection = new List<decimal>() { 10.5M, 20.55M, 30.555M, 40, 50 };
            Console.WriteLine("Collection contains: {0}", string.Join(" ", decimalCollection));
            Console.WriteLine("Sum of collection's items: {0}", decimalCollection.Sum());
            Console.WriteLine("Product of collection's items: {0:F2}", decimalCollection.Product());
            Console.WriteLine("Collection's minimal item is: {0}", decimalCollection.Min());
            Console.WriteLine("Collection's maximal item is: {0}", decimalCollection.Max());
            Console.WriteLine("Collection's average value is: {0:F2}\n", decimalCollection.Average());

            List<string> stringCollection = new List<string>() { "10", "20", "30", "40", "50" };
            Console.WriteLine("Collection contains: {0}", string.Join(" ", stringCollection));
            Console.WriteLine("Sum of collection's items: {0}", stringCollection.Sum());
            Console.WriteLine("Product of collection's items: {0}", stringCollection.Product());
            Console.WriteLine("Collection's minimal item is: {0}", stringCollection.Min());
            Console.WriteLine("Collection's maximal item is: {0}", stringCollection.Max());
            Console.WriteLine("Collection's average value is: {0}\n", stringCollection.Average());

            List<char> charCollection = new List<char>() { '1', '2', '3', '4', '5' };            
            Console.WriteLine("Collection contains: {0}", string.Join(" ", charCollection));
            Console.WriteLine("Collection's minimal item is: {0}", charCollection.Min());
            Console.WriteLine("Collection's maximal item is: {0}", charCollection.Max());
            // Next three lines throw 'InvalidCastException':
            // Console.WriteLine("Sum of collection's items: {0}", charCollection.Sum()); 
            // Console.WriteLine("Product of collection's items: {0}", charCollection.Product());
            // Console.WriteLine("Collection's average value is: {0}\n", charCollection.Average());
        }
    }
}
