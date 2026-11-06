namespace CapitalControl.Models
{
    public class Debt
    {
        public int Id { get; set; }
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

        // Recalcula los textos que se muestran en la tabla
        public void RaiseAll()
        {
            decimal remaining = Total - Paid;
            double progress = Total > 0 ? (double)(Paid / Total) : 0;

            DaysToDue = (DueDate.Date - System.DateTime.Today).Days;
            TypeIcon = IsBank ? "\U0001F3E6" : "\U0001F464";
            ProgressLabel = Fmt.Percent(progress);
            TotalLabel = Fmt.Money(Total);
            PaidLabel = Fmt.Money(Paid);
            RemainingLabel = Fmt.Money(remaining);
            DueLabel = Fmt.Date(DueDate) + " (" + DaysToDue + " días)";
        }
    }
}
