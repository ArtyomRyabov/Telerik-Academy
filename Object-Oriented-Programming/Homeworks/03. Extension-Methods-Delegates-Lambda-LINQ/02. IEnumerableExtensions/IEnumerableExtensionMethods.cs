namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensionMethods
    {
        public static decimal Sum<T>(this IEnumerable<T> input)
        {
            decimal sum = 0;

            try
            {
                foreach (T item in input)
                {
                    sum += Convert.ToDecimal(item);
                }
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice);
            }

            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> input)
        {
            decimal product = 1;

            try
            {
                foreach (T item in input)
                {
                    product *= Convert.ToDecimal(item);
                }
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine(ice);
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            T min = input.First();

            foreach (T item in input.Skip(1))
            {
                if (min.CompareTo(item) == 1)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            T max = input.First();

            foreach (T item in input.Skip(1))
            {
                if (max.CompareTo(item) == -1)
                {
                    max = item;
                }
            }
            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> input)
        {
            decimal sum = input.Sum();
            decimal average = sum / input.Count();

            return average;
        }
    }
}
