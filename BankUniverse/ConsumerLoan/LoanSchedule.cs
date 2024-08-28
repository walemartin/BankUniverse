using BankUniverse.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace BankUniverse.ConsumerLoan
{
    public class LoanSchedule
    {
        public LoanSchedule()
        {
            LoanTrxnId = BankAccountNUmberGenerator.AlfaNumericGenerator();
        }
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "loan ref")]
        public string LoanTrxnId { get; set; }

        [StringLength(50)]
        [Display(Name = "loan ref")]
        public string TrxnId { get; set; }

        public byte Period { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Repayment Dates")]
        public DateTime RepaymentDates { get; set; }


        public int MonthPeriod => RepaymentDates.Date.Month;

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "Monthly Repayment")]
        public decimal MonthlyRepayment { get; set; }

        //upon payslip generation append the 1 while on loan schedule generation append 0
        [Display(Name = "Payment status")]
        public bool? IsPaid { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "repayment status date")]
        public DateTime? RepaymentDate { get; set; }
    }
}
