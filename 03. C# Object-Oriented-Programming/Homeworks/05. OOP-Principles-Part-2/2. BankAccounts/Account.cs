namespace BankAccounts
{
    using System;
    using BankAccounts.Interfaces;

    public abstract class Account : IDepositable, IInterestCalculatable
    {
        private Customer client;
        private decimal interestRate;

        protected Account(Customer client, decimal balance, decimal interestRate)
        {
            this.Client = client;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Client
        {
            get
            {
                return this.client;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid customer!");
                }

                this.client = value;
            }
        }

        public decimal Balance { get; protected set; }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Intrest rate must be bigger than 0!");
                }

                this.interestRate = value;
            }
        }

        public abstract void Deposit(decimal amount);

        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("<{0}> <Owner: {1}> <Balance: {2:C}>", this.GetType().Name, this.Client.Name, this.Balance);
        }
    }
}
