using System;

class OddAndEvenProduct
{
    static void Main()
    {
        // You are given n integers (given in a single line, separated by a space). Write a program that checks whether 
        // the product of the odd elements is equal to the product of the even elements.
        // Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

        Console.WriteLine("Enter n integers (given in a single line, separated by a space):");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        long productOdd = 1;
        long productEven = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                productOdd *= int.Parse(numbers[i]);
            }
            else
            {
                productEven *= int.Parse(numbers[i]);
            }
        }

        if (productOdd == productEven)
        {
            Console.WriteLine("product = {0}", productEven);
            Console.WriteLine("result: yes");
        }
        else
        {
            Console.WriteLine("odd_product = {0}\neven_product = {1}", productOdd, productEven);
            Console.WriteLine("result: no");
        }
    }
}


