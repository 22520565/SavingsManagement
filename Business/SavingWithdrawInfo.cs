namespace Business;

using System;

[Serializable]
public class SavingWithdrawInfo
{
    public int Id { get; set; } = 0;

    public decimal Balance { get; set; } = decimal.Zero;

    public DateOnly MaturityDate { get; set; } = DateOnly.MaxValue;

    public decimal AmountToGet { get; set; } = decimal.MaxValue;
}
