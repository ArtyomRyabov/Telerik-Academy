namespace DivisibleBy7And3
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Division
    {
        public static IEnumerable<int> DivisibleBy7And3WithLambda(int[] numbers, int firstDivider, int secondDivider)
        {
            return numbers.Where(number => (number % 3 == 0 && number % 7 == 0));
        }

        public static IEnumerable<int> DivisibleBy7And3WithLINQ(int[] numbers, int firstDivider, int secondDivider)
        {
            return from number in numbers
                   where number % 3 == 0 && number % 7 == 0
                   select number;
        }

        public static void Main()
        {
            int[] integerArray = new int[] { 3, 7, 14, 21, 28, 42, 84 };

            Console.WriteLine("All the numbers in array:");
            Console.WriteLine(string.Join(" ", integerArray));

            Console.WriteLine("Numbers divisible by 3 and 7 (using lambda):");
            Console.WriteLine(string.Join(" ", DivisibleBy7And3WithLambda(integerArray, 3, 7)));

            Console.WriteLine("Numbers divisible by 3 and 7 (using LINQ):");
            Console.WriteLine(string.Join(" ", DivisibleBy7And3WithLINQ(integerArray, 3, 7)));
        }
    }
}
