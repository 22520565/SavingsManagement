namespace Business;

using System;

[Serializable]
public class SavingOpeningInfo
{
    public decimal Balance { get; set; } = decimal.Zero;

    public decimal AnnualInterestRate { get; set; } = decimal.Zero;

    public int PeriodInMonths { get; set; } = 0;
}
