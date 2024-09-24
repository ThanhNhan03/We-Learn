using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WeLearnAPI.Models.DTO.RequestDto
{ 
    public class UpdateNewsRequestDTO 
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
