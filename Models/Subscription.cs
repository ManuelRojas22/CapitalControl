namespace CapitalControl.Models
{
    public class Subscription
    {
        public string Name { get; set; }
        public decimal MonthlyCost { get; set; }
        public System.DateTime StartDate { get; set; }
        public string Logo { get; set; }
        public string CostLabel { get; set; }
        public string BillingLabel { get; set; }
        public string StatusLabel { get; set; }
        public bool IsActive { get; set; }
        public decimal Cost { get; set; }
        public int BillingDay { get; set; }
        public void RaiseAll() { }
    }
}