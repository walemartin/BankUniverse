using BankUniverse.CoreBankingModel;
using System.ComponentModel.DataAnnotations;

namespace BankUniverse.CRM
{
    public class CustomerProfile
    {
        public CustomerProfile()
        {
            CreatedDate = DateTime.Now;
            FirstName = "Star";
            LastName = "Lord";
            Email = "starlord@outlook.com";
            PhoneNumber = "08050007777";
            ResidentialAddress = "1 Microsoft Drive Road, LA, USA";
            Banks = new List<Bank>();
            BankBranches = new List<BankBranch>();
            BankAccounts = new List<BankAccount>();
            BankTransactions = new List<BankTransaction>();
            interBankTransfers = new List<InterBankTransfer>();

        }
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Residencial Address")]
        public string ResidentialAddress { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created date")]
        public DateTime CreatedDate { get; set; }

        public List<Bank> Banks { get; set; }
        public List<BankBranch> BankBranches { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
        public List<BankTransaction> BankTransactions { get; set; }
        public List<InterBankTransfer> interBankTransfers { get; set; }
    }
}
