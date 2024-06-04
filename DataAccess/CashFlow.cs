using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public sealed class CashFlow
{
    [Key]
    public int Id { get; set; }

    public DateTimeOffset Time { get; set; }

    public int CustomerId { get; set; }

    [Column(TypeName = "money")]
    public decimal BalanceChanging { get; set; }

    [StringLength(300)]
    public string Content { get; set; } = null!;

    [ForeignKey("CustomerId")]
    [InverseProperty("CashFlows")]
    public CustomerAccount Customer { get; set; } = null!;
}
