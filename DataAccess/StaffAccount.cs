﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

[Index("Username", Name = "UQ__StaffAcc__F3DBC572752A95C1", IsUnique = true)]
public sealed class StaffAccount
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public bool IsMale { get; set; }

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
    public string Position { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    public string HashedPassword { get; set; } = null!;

    public int PermissionId { get; set; }

    public bool IsDisabled { get; set; }

    [ForeignKey("PermissionId")]
    [InverseProperty("StaffAccounts")]
    public StaffPermission Permission { get; set; } = null!;
}
