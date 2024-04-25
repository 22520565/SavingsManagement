namespace Business;

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

[Serializable]
public class LoginInfo
{
    [StringLength(50), Unicode(false), DisallowNull]
    required public string Username { get; set; }

    [StringLength(50), Unicode(false), DisallowNull]
    required public string Password { get; set; }
}
