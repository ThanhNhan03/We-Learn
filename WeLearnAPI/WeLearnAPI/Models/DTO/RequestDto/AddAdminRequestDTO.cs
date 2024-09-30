using System;
using System.ComponentModel.DataAnnotations;

public class AddAdminRequestDTO
{
    [Required]
    [MaxLength(255)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(255)]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(255)]
    public string Email { get; set; }

    public DateTime? Birthday { get; set; }

    [Phone]
    [MaxLength(20)]
    public string TelephoneNumber { get; set; }

    //[MaxLength(255)]
    //public string? Image { get; set; }

    [Required]
    [MinLength(6)]  // Ensure passwords are of adequate length
    public string Password { get; set; }

    [Required]
    public string Role { get; set; } 

    [Required]
    public string Gender { get; set; } 
}
