namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Customers;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer client, decimal balance, decimal interestRate)
            : base(client, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Client is IndividualCustomer)
            {
                months -= 3;
            }
            else if (this.Client is CompanyCustomer)
            {
                months -= 2;
            }

            if (months < 0)
            {
                return 0M;
            }

            return ((this.InterestRate / 100M) * this.Balance) * months;
        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Deposit sum must be larger than 0!");
            }

            this.Balance -= amount;
        }
    }
}
