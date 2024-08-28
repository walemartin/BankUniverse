using BankUniverse.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace BankUniverse.ConsumerLoan
{
    public class Loan
    {
        public Loan()
        {
            CreatedDate = DateTime.Now;
            LoanRef = BankAccountNUmberGenerator.AlfaNumericGenerator();
            LoanType = LoanType.Payday;
            IsLoanPaid = false;
            LoanAmount = decimal.Zero;
        }
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "loan ref")]
        public string LoanRef { get; set; }

        [Display(Name = "select loan type")]
        public LoanType LoanType { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "Loan amount")]
        public decimal LoanAmount { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Loan start date")]
        public DateTime LoanStartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Loan end date")]
        public DateTime LoanEndDate { get; set; }


        [Display(Name = "Loan Tenor")]
        [Range(1, 60, ErrorMessage = "The value must be greater than 0")]
        public int NoOfMonths { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "created date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "paid status")]
        public bool IsLoanPaid { get; set; }
    }
    public enum LoanType
    {
        [Display(Name = "Payday Loan")]
        Payday,
        [Display(Name = "Quick Cash Loan")]
        Quick_Cash,
        [Display(Name = "Personal Loan")]
        Personal,
        [Display(Name = "Business Loan")]
        Business,
        [Display(Name = "Mortgage loan")]
        Mortgage
    }
}
