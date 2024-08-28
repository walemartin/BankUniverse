using System.ComponentModel.DataAnnotations;

namespace BankUniverse.ConsumerLoan
{
    public class LoanViewStatus
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "loan ref")]
        public string TrxnId { get; set; }

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

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "loan amount")]
        public decimal LoanAmount { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "repayment amount")]
        public decimal MonthlyRepayment { get; set; }



        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "loan balance")]
        public decimal LoanBalance { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Loan date")]
        public DateTime LoanDate { get; set; }
    }
}
