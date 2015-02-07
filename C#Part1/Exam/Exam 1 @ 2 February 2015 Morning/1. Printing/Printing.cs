using System;

class Printing
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        int allPrintedSheets = n * s;
        decimal reams = allPrintedSheets / 500m;
        decimal oneReamMoney = p * 0.45m;
        decimal savedMoney = reams * p;
        Console.WriteLine("{0:0.00}", savedMoney);
    }
}

