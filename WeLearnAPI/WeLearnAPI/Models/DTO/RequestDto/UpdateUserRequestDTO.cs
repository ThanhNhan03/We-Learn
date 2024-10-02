using System;
using System.ComponentModel.DataAnnotations;

public class UpdateUserRequestDTO
{
    [Required]
    [MaxLength(255)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(255)]
    public string LastName { get; set; }

    public DateTime? Birthday { get; set; }

    [Required]
    public string Gender { get; set; }
}
