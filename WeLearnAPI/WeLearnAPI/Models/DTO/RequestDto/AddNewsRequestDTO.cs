using System.ComponentModel.DataAnnotations;

namespace WeLearnAPI.Models.DTO.RequestDto
{
    public class AddNewsRequestDTO
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string Content { get; set; } = string.Empty;
        public Guid AdminId { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
