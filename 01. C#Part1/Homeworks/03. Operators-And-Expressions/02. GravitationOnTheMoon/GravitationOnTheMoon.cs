using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        // The gravitational field of the Moon is approximately 17% of that on the Earth.
        // Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

        Console.Write("Enter weight of a man on Earth: ");
        float weight = float.Parse(Console.ReadLine());
        float weightDifference = 0.17f;
        float weightOnMoon = weight * weightDifference;
        Console.WriteLine("That weight on the Moon will be: {0}", weightOnMoon);
    }
}

