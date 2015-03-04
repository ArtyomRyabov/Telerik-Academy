using System;

class BitsToBits
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        short zeroesCounter = 0;
        short maxZeroesCounter = 0;
        short onesCounter = 0;
        short maxOnesCounter = 0;

        for (int i = 0; i < N; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int j = 29; j >= 0; j--)
            {
                int bit = (number >> j) & 1;

                if (bit == 0)
                {
                    onesCounter = 0;
                    zeroesCounter++;

                    if (zeroesCounter > maxZeroesCounter)
                    {
                        maxZeroesCounter = zeroesCounter;
                    }
                    if (onesCounter > maxOnesCounter)
                    {
                        maxOnesCounter = onesCounter;
                    }
                }
                else
                {
                    zeroesCounter = 0;
                    onesCounter++;

                    if (onesCounter > maxOnesCounter)
                    {
                        maxOnesCounter = onesCounter;
                    }
                }
            }
        }

        Console.WriteLine(maxZeroesCounter);
        Console.WriteLine(maxOnesCounter);
    }
}