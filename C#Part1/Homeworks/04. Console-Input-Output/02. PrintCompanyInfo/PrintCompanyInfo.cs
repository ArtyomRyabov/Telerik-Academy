using System;

class PrintCompanyInfo
{
    static void Main()
    {
        /* A company has name, address, phone number, fax number, web site and manager. 
           The manager has first name, last name, age and a phone number. Write a program that reads the information 
           about a company and its manager and prints it back on the console.

                    Example input:
                    
                       program 	             user
                    Company name: 	     Telerik Academy
                    Company address: 	 31 Al. Malinov, Sofia
                    Phone number: 	     +359 888 55 55 555
                    Fax number: 	     2
                    Web site: 	         http://telerikacademy.com/
                    Manager first name:  Nikolay
                    Manager last name: 	 Kostov
                    Manager age: 	     25
                    Manager phone: 	     +359 2 981 981
                    
                    Example output:
                    
                    Telerik Academy
                    Address: 231 Al. Malinov, Sofia
                    Tel. +359 888 55 55 555
                    Fax: (no fax)
                    Web site: http://telerikacademy.com/
                    Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  
           */

        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string mgrFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string mgrLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte mgrAge = byte.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string mgrPhone = Console.ReadLine();

        faxNumber = "(no fax)";
        Console.WriteLine("\n" + new String('-', 40) + "\n");

        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}",
                            companyName, address, phoneNumber, faxNumber, webSite);
        Console.WriteLine("Menager: {0} {1} (age: {2}, tel. {3})",
                            mgrFirstName, mgrLastName, mgrAge, mgrPhone);
    }
}

