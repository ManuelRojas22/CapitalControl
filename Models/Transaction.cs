namespace CapitalControl.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public TxType Type { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public string Category { get; set; }
        public string DateLabel { get; set; }
        public string TypeIcon { get; set; }
        public string TypeLabel { get; set; }
        public string AmountLabel { get; set; }

        // Recalcula los textos que se muestran en la tabla
        public void RaiseAll()
        {
            DateLabel = Fmt.Date(Date);
            switch (Type)
            {
                case TxType.Ingreso:
                    TypeIcon = "⬆"; TypeLabel = "Ingreso"; AmountLabel = "+" + Fmt.Money(Amount);
                    break;
                case TxType.Gasto:
                    TypeIcon = "⬇"; TypeLabel = "Gasto"; AmountLabel = "-" + Fmt.Money(Amount);
                    break;
                default:
                    TypeIcon = "\U0001F4C8"; TypeLabel = "Inversion"; AmountLabel = "-" + Fmt.Money(Amount);
                    break;
            }
        }
    }
}
