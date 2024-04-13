namespace Entity
{
    public class SavingInterestRate
    {
        public byte PeriodInMonths { get; set; } = byte.MinValue;

        public decimal AnnualInterestRate { get; set; } = decimal.Zero;
    }
}
