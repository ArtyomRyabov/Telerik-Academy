using System;

class EmployeeData
{
    static void Main()
    {
        /* A marketing company wants to keep record of its employees. Each record would have the following characteristics:
         
            First name
            Last name
            Age (0...100)
            Gender (m or f)
            Personal ID number (e.g. 8306112507)
            Unique employee number (27560000…27569999)
        
           Declare the variables needed to keep the information for a single employee using appropriate 
           primitive data types. Use descriptive names. Print the data at the console.
         */

        Console.WriteLine("Employee info:");
        Console.WriteLine();
        Console.Write("First name: ");
        string firstName = Console.ReadLine();              // Georgi
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();               // Jefferski
        Console.Write("Age: ");
        byte age = byte.Parse(Console.ReadLine());          // 34
        Console.Write("Gender (m/f): ");
        char gender = char.Parse(Console.ReadLine());       // m
        Console.Write("Personal ID number: ");
        long idNumber = long.Parse(Console.ReadLine());     // 8306112507L
        Console.Write("Employee number: ");
        long employeeNumber = long.Parse(Console.ReadLine());   // 27560001L
    }
}

