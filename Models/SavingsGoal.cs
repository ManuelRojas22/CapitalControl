namespace CapitalControl.Models
{
    public class SavingsGoal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public System.DateTime Deadline { get; set; }
        public string Category { get; set; }
        public string ProgressLabel { get; set; }
        public string TargetLabel { get; set; }
        public string CurrentLabel { get; set; }
        public string RemainingLabel { get; set; }
        public string TargetDateLabel { get; set; }
        public string MonthlyLabel { get; set; }
        public double Progress { get; set; }
        public int DaysRemaining { get; set; }
        public string TargetDate { get; set; }
        public string ColorKey { get; set; }
        public decimal Target { get; set; }
        public decimal Current { get; set; }

        // Recalcula los textos que se muestran en la tabla
        public void RaiseAll()
        {
            System.DateTime date;
            if (!System.DateTime.TryParse(TargetDate, out date)) date = System.DateTime.Today;
            Deadline = date;

            decimal remaining = System.Math.Max(0, Target - Current);
            Progress = Target > 0 ? (double)(Current / Target) * 100 : 0;
            DaysRemaining = (date.Date - System.DateTime.Today).Days;

            int months = System.Math.Max(1, (int)System.Math.Ceiling(DaysRemaining / 30.0));
            ProgressLabel = Progress.ToString("F1") + "%";
            TargetLabel = Fmt.Money(Target);
            CurrentLabel = Fmt.Money(Current);
            RemainingLabel = Fmt.Money(remaining);
            TargetDateLabel = Fmt.Date(date);
            MonthlyLabel = Fmt.Money(remaining / months) + "/mes";
        }
    }
}
