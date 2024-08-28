namespace BankUniverse.CoreBankingModel
{
    public class InterBankTransfer
    {
        public int Id { get; set; }
        public string AccountNumber1 { get; set; }
        //public decimal AvailableBal { get; set; }
        public string Narration { get; set; }

        public string AccountNumber2 { get; set; }
        public decimal TransferAmount { get; set; }
        public DateTime TransactionDate { get; set; }

        //implement a business logic that will implement Debit on sender account and credit on receiver account and pass narration to both account entity
    }
}
