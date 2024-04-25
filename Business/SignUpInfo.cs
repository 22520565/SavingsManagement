namespace Business;

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

public class SignUpInfo
{
    [StringLength(50), DisallowNull]
    required public string Name { get; set; } = string.Empty;

    [DisallowNull]
    required public bool IsMale { get; set; } = true;

    [StringLength(20), Unicode(false), DisallowNull]
    required public string CicNumber { get; set; } = string.Empty;

    [DisallowNull]
    required public DateOnly BirthDate { get; set; } = default;

    [StringLength(20), Unicode(false), DisallowNull]
    required public string PhoneNumber { get; set; } = string.Empty;

    [StringLength(50), DisallowNull]
    required public string Address { get; set; } = string.Empty;

    [StringLength(50), Unicode(false), AllowNull]
    public string? Email { get; set; } = default;

    [StringLength(50), Unicode(false), DisallowNull]
    public string Username { get; set; } = string.Empty;

    [StringLength(50), Unicode(false), DisallowNull]
    public string Password { get; set; } = string.Empty;
}
