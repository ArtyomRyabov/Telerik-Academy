namespace P2.DecreasingAbsoluteDifferences
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            byte numberOfSequences = byte.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSequences; i++)
            {
                string line = Console.ReadLine();
                int[] sequence = line.Split(' ').Select(x => Int32.Parse(x)).ToArray();
                bool isSequence = true;

                for (int j = 1; j < sequence.Length - 1; j++)
                {
                    if (((Math.Abs(sequence[j - 1] - sequence[j]) - Math.Abs(sequence[j] - sequence[j + 1])) > 1) ||
                         (Math.Abs(sequence[j] - sequence[j + 1]) > Math.Abs(sequence[j - 1] - sequence[j])))
                    {
                        isSequence = false;
                        Console.WriteLine("False");
                        break;
                    }
                    else
                    {
                        isSequence = true;
                    }
                }

                if (isSequence == true)
                {
                    Console.WriteLine("True");
                }
            }
        }
    }
}
