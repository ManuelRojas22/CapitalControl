namespace CapitalControl.Models
{
    public class Debt
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Creditor { get; set; }
        public bool IsBank { get; set; }
        public decimal Total { get; set; }
        public decimal Paid { get; set; }
        public System.DateTime DueDate { get; set; }
        public double InterestRate { get; set; }
        public string TypeIcon { get; set; }
        public string ProgressLabel { get; set; }
        public string TotalLabel { get; set; }
        public string PaidLabel { get; set; }
        public string RemainingLabel { get; set; }
        public string DueLabel { get; set; }
        public int DaysToDue { get; set; }
        public void RaiseAll() { }
    }
}