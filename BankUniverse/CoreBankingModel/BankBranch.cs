using BankUniverse.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace BankUniverse.CoreBankingModel
{
    public class BankBranch
    {
        public BankBranch()
        {
            CreatedDate = DateTime.Now;
            BranchOffice = "Branch Office-" + BankAccountNUmberGenerator.AlfaNumericGenerator();
            BankDescription = "Branch Description-" + BankAccountNUmberGenerator.AlfaNumericGenerator();
            IsActive = true;
        }
        public int Id { get; set; }

        [Display(Name = "Branch office")]
        public string BranchOffice { get; set; }

        [Display(Name = "Branch description")]
        public string BankDescription { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Branch status")]
        public bool IsActive { get; set; }
    }
}
