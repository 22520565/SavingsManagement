using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

[Serializable]
public sealed class SavingInterestRate
{
    [Key]
    public byte PeriodInMonths { get; set; }

    [Column(TypeName = "decimal(10, 8)")]
    public decimal AnnualInterestRate { get; set; }
}
