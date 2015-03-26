namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Customers;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer client, decimal balance, decimal interestRate)
            : base(client, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 1)
            {
                return 0M;
            }

            if (this.Client is CompanyCustomer)
            {
                if (months <= 12)
                {
                    return (((this.InterestRate / 2) / 100M) * this.Balance) * months;
                }
                else
                {
                    return ((this.InterestRate / 100M) * this.Balance) * months;
                }
            }
            else 
            {
                if (months <= 6)
                {
                    return 0M;
                }
                else
                {
                    return ((this.InterestRate / 100M) * this.Balance) * months;
                }
            }
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
