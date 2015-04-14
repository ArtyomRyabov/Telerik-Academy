/*  Write a program that reads an integer number and calculates and prints its square root.
        If the number is invalid or negative, print Invalid number.
        In all cases finally print Good bye.
    Use try-catch-finally block.
 */

namespace P01.SquareRoot
{
    using System;

    class SquareRoot
    {
        static void Main()
        {
            CalculateSquareRoot();
        }

        private static void CalculateSquareRoot()
        {
            try
            {
                Console.Write("Enter an integer number: ");
                long number = long.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("sqrt({0}) = {1:F2}",number, Math.Sqrt(number));
                return;
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Invalid number! {0}", oe.Message);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("Invalid number! {0}", ane.Message);
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine("Invalid number! {0}", aore.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid number! {0}", fe.Message);
            }
            finally
            {
                Console.WriteLine("Good Bye!");
            }
        }
    }
}
