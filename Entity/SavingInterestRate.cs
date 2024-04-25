using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity;

[Serializable]
public sealed class SavingInterestRate
{
    [Key]
    public byte PeriodInMonths { get; set; }

    [Column(TypeName = "decimal(8, 5)")]
    public decimal AnnualInterestRate { get; set; }
}
