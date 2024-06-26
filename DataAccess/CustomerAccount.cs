﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

[Index("Username", Name = "UQ_Customer", IsUnique = true)]
[Index("Email", Name = "UQ_Email", IsUnique = true)]
public sealed class CustomerAccount
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public bool IsMale { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CicNumber { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string PhoneNumber { get; set; } = null!;

    [StringLength(50)]
    public string Address { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    public string HashedPassword { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal Balance { get; set; }

    public bool IsDisabled { get; set; }

    [InverseProperty("Customer")]
    public ICollection<CashFlow> CashFlows { get; } = new List<CashFlow>();

    [InverseProperty("Customer")]
    public ICollection<Saving> Savings { get; } = new List<Saving>();
}
