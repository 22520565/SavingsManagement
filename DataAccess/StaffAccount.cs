using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

[Index("Username", Name = "UQ__StaffAcc__F3DBC572752A95C1", IsUnique = true)]
[Serializable]
public sealed class StaffAccount
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public bool IsMale { get; set; }

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
