namespace Entity
{
    public class Saving
    {
        public int Id { get; set; } = 0;

        public int CustomerId { get; set; } = 0;

        public decimal Balance { get; set; } = 0.0M;

        public decimal AnnualInterestRate { get; set; } = 0.0M;

        public int PeriodInMonths { get; set; } = 0;

        public DateOnly OpenDay { get; set; } = new DateOnly();
    }
}
