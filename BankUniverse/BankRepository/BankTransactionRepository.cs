using BankUniverse.BankInterface;
using BankUniverse.CoreBankingModel;
using BankUniverse.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace BankUniverse.BankRepository
{
    public class BankTransactionRepository: IBankTransaction
    {
        private readonly ApplicationDbContext _bankContext;
        public BankTransactionRepository(ApplicationDbContext bankContext)
        {
            _bankContext = bankContext;
        }


        public async Task<BankTransaction> Deposit(string accountNumber, decimal amount)
        {
            var account = await _bankContext.BankAccounts.FirstOrDefaultAsync(a => a.AccountNumber == accountNumber) ?? throw new Exception("Account not found");
            account.Balance += amount;

            var transaction = new BankTransaction
            {
                AccNo = accountNumber,
                Amount = amount,
                Accounting = Accounting.CR,
                TransactionDate = DateTime.Now
            };

            await _bankContext.BankTransactions.AddAsync(transaction);
            await SaveChangesAsync();

            return transaction;
        }

       

        public async Task<BankTransaction> Transfer(string accountNumber, decimal amount)
        {
            var account = await _bankContext.BankAccounts.FirstOrDefaultAsync(a => a.AccountNumber == accountNumber) ?? throw new Exception("Account not found");
            if (account.Balance < amount)
            {
                throw new Exception("Insufficient funds");
            }

            account.Balance -= amount;

            // Assume we're transferring to another account (add appropriate logic here)
            // For simplicity, let's assume we're just recording the transfer

            var transaction = new BankTransaction
            {
                AccNo = accountNumber,
                Amount = amount,
                Accounting = Accounting.DR,
                TransactionDate = DateTime.Now
            };

            await _bankContext.BankTransactions.AddAsync(transaction);
            await SaveChangesAsync();

            return transaction;
        }
        public async Task<BankTransaction> WithDraw(string accountNumber, decimal amount)
        {
            var account = await _bankContext.BankAccounts.FirstOrDefaultAsync(a => a.AccountNumber == accountNumber) ?? throw new Exception("Account not found");
            if (account.Balance < amount)
            {
                throw new Exception("Insufficient funds");
            }

            account.Balance -= amount;

            var transaction = new BankTransaction
            {
                AccNo = accountNumber,
                Amount = amount,
                Accounting = Accounting.DR,
                TransactionDate = DateTime.Now
            };

            await _bankContext.BankTransactions.AddAsync(transaction);
            await SaveChangesAsync();

            return transaction;
        }
        public async Task SaveChangesAsync()
        {
            await _bankContext.SaveChangesAsync();
        }

        
    }
}
