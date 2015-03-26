namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Interfaces;

    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer client, decimal balance, decimal interestRate)
            : base(client, balance, interestRate)
        {
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Withdraw sum must be larger than 0!");
            }

            if (amount > this.Balance)
            {
                throw new ArgumentOutOfRangeException("Withdraw sum cannot be larger than the account balance!");
            }

            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000m)
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

            this.Balance += amount;
        }
    }
}
