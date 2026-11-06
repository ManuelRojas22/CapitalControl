namespace CapitalControl.Models
{
    public class Subscription
    {
        public int Id { get; set; }
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

        // Recalcula los textos que se muestran en la tabla
        public void RaiseAll()
        {
            MonthlyCost = Cost;
            CostLabel = Fmt.Money(Cost) + "/mes";
            BillingLabel = "Día " + BillingDay + " de cada mes";
            StatusLabel = IsActive ? "Activa" : "Cancelada";
        }
    }
}
