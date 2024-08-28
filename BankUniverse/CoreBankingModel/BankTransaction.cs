namespace BankUniverse.CoreBankingModel
{
    public class BankTransaction
    {
        public int ID { get; set; }
        public string AccNo { get; set; }
        public string Narration { get; set; }

        // Choose either DR(Debit) or CR (Credit)
        public Accounting Accounting { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public DateTime TransactionDate { get; set; }
    }
    public enum Accounting
    {
        DR, CR
    }
}
