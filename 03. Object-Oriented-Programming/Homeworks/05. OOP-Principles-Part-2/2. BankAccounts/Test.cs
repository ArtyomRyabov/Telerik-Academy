namespace BankAccounts
{
    using System;
    using BankAccounts.Accounts;
    using BankAccounts.Customers;

    public class Test
    {
        public static void Main()
        {
            Customer ivan = new IndividualCustomer("Ivan");
            DepositAccount ivanDepositAccount = new DepositAccount(ivan, 500M, 4M);
            Console.WriteLine(ivanDepositAccount.Client.Name);
            Console.WriteLine(ivanDepositAccount.InterestRate);
            ivanDepositAccount.Deposit(100M);
            Console.WriteLine(ivanDepositAccount.Balance);
            ivanDepositAccount.Withdraw(100);
            Console.WriteLine(ivanDepositAccount.Balance);
            Console.WriteLine(ivanDepositAccount.CalculateInterest(5));
            Console.WriteLine(ivanDepositAccount);

            Customer company = new CompanyCustomer("Company");
            MortgageAccount companyMortgageAcount = new MortgageAccount(company, 100000M, 1.5M);
            Console.WriteLine(companyMortgageAcount.Client.Name);
            Console.WriteLine(companyMortgageAcount);
            companyMortgageAcount.Deposit(10000);
            Console.WriteLine(companyMortgageAcount.Balance);
            companyMortgageAcount.CalculateInterest(20);

            LoanAccount companyLoanAccount = new LoanAccount(company, 25000M, 5M);
            Console.WriteLine(companyLoanAccount);
            companyLoanAccount.Deposit(5000.50M);
            Console.WriteLine(companyLoanAccount.CalculateInterest(30));
            Console.WriteLine(companyLoanAccount);
        }
    }
}
