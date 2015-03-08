namespace P2.BunnyFactory
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    class BunnyFactory
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            InputData(numbers);
            NumberOfBunniesAfterMultiplication(numbers);

            Console.WriteLine(string.Join(" ", numbers.ToArray()));
        }

        static List<int> NumberOfBunniesAfterMultiplication(List<int> numbers)
        {
            StringBuilder result = new StringBuilder();
            int numberOfCagesToTake = 0;
            long sum = 0;
            BigInteger product = 1;
            int sumEndIndex = 0;

            while (true)
            {
                if (sumEndIndex > (numbers.Count - (sumEndIndex + 1)))
                {
                    return numbers;
                }

                for (int i = 0; i <= sumEndIndex; i++)
                {
                    numberOfCagesToTake += numbers[i];
                }

                if (numberOfCagesToTake > (numbers.Count - (sumEndIndex + 1)))
                {
                    return numbers;
                }

                for (int i = 0; i < numberOfCagesToTake; i++)
                {
                    sum += numbers[sumEndIndex + 1 + i];
                    product *= numbers[sumEndIndex + 1 + i];
                }

                result.Append(sum).Append(product);                

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i > (sumEndIndex + numberOfCagesToTake))
                    {
                        result.Append(numbers[i]);
                    }
                }

                result.Replace("0", "").Replace("1", "");
                numbers.Clear();

                for (int i = 0; i < result.Length; i++)
                {
                    numbers.Add(int.Parse(result[i].ToString()));
                }

                sumEndIndex++;
                numberOfCagesToTake = 0;
                sum = 0;
                product = 1;
                result.Clear();
            }
        }

        static void InputData(List<int> numbers)
        {
            string line = Console.ReadLine();

            while (line != "END")
            {
                int bunniesNumber = int.Parse(line);
                numbers.Add(bunniesNumber);
                line = Console.ReadLine();
            }
        }
    }
}
