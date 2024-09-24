using System.ComponentModel.DataAnnotations;

public class RegisterRequestDTO
{
    [Required]
    public required string FirstName { get; set; }
    [Required]
    public required string LastName { get; set; } 

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(100, ErrorMessage = "The password must be at least {2}", MinimumLength = 6)]
    public string Password { get; set; } = string.Empty;

    [Required]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    public string ConfirmPassword { get; set; }
}
