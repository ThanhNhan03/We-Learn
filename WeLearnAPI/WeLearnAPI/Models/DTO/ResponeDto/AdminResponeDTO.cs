using System;

namespace WeLearnAPI.Models.DTOs
{
    public class AdminResponseDTO
    {
        public Guid Id { get; set; } 
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public DateTime? Birthday { get; set; } 
        public string? Gender { get; set; } 
        public string? Email { get; set; } 
        public string? Image { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } 
        public DateTime? DeletedAt { get; set; } 
    }
}
