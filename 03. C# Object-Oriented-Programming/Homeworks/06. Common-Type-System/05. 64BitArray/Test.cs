namespace BitArray
{
    using System;

    public class Test
    {
        public static void Main()
        {
            BitArray64 firstArray = new BitArray64(1);
            Console.WriteLine(firstArray);
            Console.WriteLine(firstArray.GetHashCode());
            // firstArray[1] = 2;        throws 'ArgumentOutOfRangeException'
            // firstArray[64] = 1;       throws 'ArgumentOutOfRangeException'
            firstArray[1] = 1; 
            Console.WriteLine(firstArray);

            BitArray64 secondArray = new BitArray64(3);
            Console.WriteLine(secondArray);
            Console.WriteLine(secondArray.GetHashCode());

            Console.WriteLine(firstArray.Equals(secondArray));
            Console.WriteLine(firstArray != secondArray);

            secondArray[0] = 0;

            Console.WriteLine(firstArray.Equals(secondArray));
            Console.WriteLine(firstArray == secondArray);

            BitArray64 thirdArray = new BitArray64(9223372036854251519);
            Console.WriteLine(thirdArray);
            Console.WriteLine(thirdArray.GetHashCode());
        }
    }
}
