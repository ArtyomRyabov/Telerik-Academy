// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace P02.EnterNumbers
{
    using System;

    class EnterNumbers
    {
        private static int ReadNumber(int start, int end)
        {
            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
            catch (FormatException)
            {
                throw new FormatException();
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException();
            }

            return number;
        }

        static void Main()
        {
            byte start = 1;
            byte end = 100;
            byte lenght = 10;

            Console.WriteLine("Enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100");

            try
            {
                for (int i = 1; i <= lenght; i++)
                {
                    byte enteredNumber = (byte)ReadNumber(start, end);

                    if (enteredNumber == start || enteredNumber == end)
                    {
                        throw new Exception("Your number should not be equal to previous one nor equal to end number!");
                    }

                    if (enteredNumber >= (end - lenght + i))
                    {
                        throw new OverflowException("This number is too big. You do not have enough space for the next numbers.");
                    }
                     
                    start = enteredNumber;
                }
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine(aore.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
