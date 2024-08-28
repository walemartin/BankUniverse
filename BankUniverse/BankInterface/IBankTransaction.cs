using BankUniverse.CoreBankingModel;

namespace BankUniverse.BankInterface
{
    public interface IBankTransaction
    {
        Task<BankTransaction> Deposit(string accountnumber, decimal amount);
        Task<BankTransaction> WithDraw(string accountnumber, decimal amount);
        Task<BankTransaction> Transfer(string accountnumber, decimal amount);
        // Save changes to the database
        Task SaveChangesAsync();
    }
}
