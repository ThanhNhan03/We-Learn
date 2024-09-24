using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Users : IdentityUser<Guid>
{
    [MaxLength(255)]
    public string? FirstName { get; set; }
    [MaxLength(255)]
    public string? LastName { get; set; }
    public DateTime? Birthday { get; set; }
    public byte? Gender { get; set; }
    [MaxLength(255)]
    public string? Image { get; set; }
    [MaxLength(255)]
    public string? VerificationToken { get; set; }
    public DateTime? VerificationTokenExpires { get; set; }
    [MaxLength(100)]
    public string? RememberToken { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime? DeletedAt { get; set; }

}
