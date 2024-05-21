using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

[Serializable]
public sealed class Saving
{
    [Key]
    public int Id { get; set; }

    public int CustomerId { get; set; }

    [Column(TypeName = "money")]
    public decimal Balance { get; set; }

    [Column(TypeName = "decimal(10, 8)")]
    public decimal AnnualInterestRate { get; set; }

    public int PeriodInMonths { get; set; }

    public DateTimeOffset OpeningDateTime { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Savings")]
    public CustomerAccount Customer { get; set; } = null!;
}
