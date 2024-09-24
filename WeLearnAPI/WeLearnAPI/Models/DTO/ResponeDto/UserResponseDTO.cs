using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class UserResponseDTO 
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? Birthday { get; set; }
    public byte? Gender { get; set; }
    public string? Image { get; set; }

}
