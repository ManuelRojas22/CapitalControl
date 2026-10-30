namespace CapitalControl.Models
{
    public class SavingsGoal
    {
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
        public void RaiseAll() { }
    }
}