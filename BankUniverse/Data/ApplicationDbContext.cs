using BankUniverse.ConsumerLoan;
using BankUniverse.CoreBankingModel;
using BankUniverse.CRM;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BankUniverse.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankBranch> bankBranches { get; set; }
        public DbSet<InterBankTransfer> InterBankTransfers { get; set; }
        public DbSet<BankTransaction> BankTransactions { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<CustomerProfile> CustomerProfiles { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanSchedule> LoanSchedules { get; set; }
    }
}
