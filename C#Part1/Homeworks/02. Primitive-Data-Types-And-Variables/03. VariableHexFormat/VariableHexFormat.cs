using System;

class VariableHexFormat
{
    static void Main()
    {
        // Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
        // Use Windows Calculator to find its hexadecimal representation.
        // Print the variable and ensure that the result is 254.

        byte dec = 254;
        byte hex = 0xFE;

        Console.WriteLine("decimal: {0}", dec);
        Console.WriteLine("hexadecimal: {0}", hex);

        // or
        Console.WriteLine(dec == hex);
    }
}

