using BankUniverse.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace BankUniverse.CoreBankingModel
{
    public class Bank
    {
        public Bank()
        {
            CreatedDate = DateTime.Now;
            BankName = "Bank-" + BankAccountNUmberGenerator.AlfaNumericGenerator();
            BankDescription = "BankDescription-" + BankAccountNUmberGenerator.AlfaNumericGenerator();
            IsActive = true;
            BankBranches = new List<BankBranch>();
        }
        public int Id { get; set; }


        [Display(Name = "Bank Name")]
        public string BankName { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Bank description")]
        public string BankDescription { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created date")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Bank Status")]
        public bool IsActive { get; set; }
        public List<BankBranch> BankBranches { get; set; }
    }
}
