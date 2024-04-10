namespace Entity
{
    public class CashFlow
    {
        public int Id { get; set; } = 0;

        public int CustomerId { get; set; } = 0;

        public DateTime Time { get; set; } = DateTime.Now;

        public decimal BalanceChanging { get; set; } = 0.0M;

        public decimal BalanceRemaining { get; set; } = 0.0M;
    }
}
