using BankUniverse.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace BankUniverse.CoreBankingModel
{
    public class BankAccount
    {
        public BankAccount()
        {
            AccountType = AccountType.Savings;
            TransactionDate = DateTime.Now;
            Balance = decimal.Zero;
            AccountNumber = BankAccountNUmberGenerator.AlfaNumericGenerator();
        }
        public int Id { get; set; }

        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        [Display(Name = "Account type")]
        public AccountType AccountType { get; set; }

        [Display(Name = "Account balance")]
        public decimal Balance { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Transaction date")]
        public DateTime TransactionDate { get; private set; }

    }
    public enum AccountType
    {
        Savings, Current, Fixed
    }
}
