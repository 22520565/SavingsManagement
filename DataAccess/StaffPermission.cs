using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public sealed class StaffPermission
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [InverseProperty("Permission")]
    public ICollection<StaffAccount> StaffAccounts { get; } = new List<StaffAccount>();
}
