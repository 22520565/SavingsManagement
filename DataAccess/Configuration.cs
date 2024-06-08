using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

[Table("Configuration")]
public sealed class Configuration
{
    [Key]
    public byte ID { get; set; }

    [Column(TypeName = "money")]
    public decimal MaxAmountOpeningSaving { get; set; }

    [Column(TypeName = "money")]
    public decimal MinAmountOpeningSaving { get; set; }

    [Column(TypeName = "money")]
    public decimal MaxAmountDepositing { get; set; }

    [Column(TypeName = "money")]
    public decimal MinAmountDepositing { get; set; }

    [Column(TypeName = "money")]
    public decimal MaxAmountWithdrawing { get; set; }

    [Column(TypeName = "money")]
    public decimal MinAmountWithdrawing { get; set; }
}
