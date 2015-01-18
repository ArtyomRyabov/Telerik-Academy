using System;

class BankAccountData
{
    static void Main()
    {
        // A bank account has a holder name (first name, middle name and last name), available amount of 
        // money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
        // Declare the variables needed to keep the information for a single bank account using the 
        // appropriate data types and descriptive names.

        Console.WriteLine(new String('-', 40));
        Console.Write("Bank name: ");
        string bankName = Console.ReadLine();           // FIBN
        Console.WriteLine(new String('-', 40));
        Console.WriteLine();
        Console.WriteLine("Holder:");
        Console.WriteLine(new String('-', 7));
        Console.Write("First name: ");
        string firstName = Console.ReadLine();          // Georgi
        Console.Write("Middle name: ");
        string middleName = Console.ReadLine();         // Tonev
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();           // Jefferski
        Console.WriteLine();
        Console.Write("Balance (BGN): ");
        decimal amountMoney = decimal.Parse(Console.ReadLine());      // 52654.44m
        Console.Write("IBAN: ");
        string iban = Console.ReadLine();               // BG44CECB49673748596847
        Console.Write("Credit card number 1: ");
        long card1 = long.Parse(Console.ReadLine());    
        Console.Write("Credit card number 2: ");        // 68473657786958L
        long card2 = long.Parse(Console.ReadLine());
        Console.Write("Credit card number 3: ");        // 96857465768796L
        long card3 = long.Parse(Console.ReadLine());
        Console.WriteLine(new String('-', 40));         // 35463546576879L
    }
}

