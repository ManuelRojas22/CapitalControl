namespace CapitalControl.Models
{
    public class Transaction
    {
        public TxType Type { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public string Category { get; set; }
        public string DateLabel { get; set; }
        public string TypeIcon { get; set; }
        public string TypeLabel { get; set; }
        public string AmountLabel { get; set; }
    }
}