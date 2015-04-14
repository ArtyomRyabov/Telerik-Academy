namespace BankAccounts.Interfaces
{
    public interface IInterestCalculatable
    {
        decimal CalculateInterest(int months);
    }
}
