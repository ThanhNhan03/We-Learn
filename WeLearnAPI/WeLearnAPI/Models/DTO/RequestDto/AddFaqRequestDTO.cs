using System.ComponentModel.DataAnnotations;

namespace WeLearnAPI.Models.DTO.RequestDto
{
    public class AddFaqRequestDTO
    {
        [Required]
        [MaxLength(255)]
        public string FaqQuestion { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string FaqAnswer { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string FaqCategories { get; set; } = string.Empty;
        [Required]
        public Guid AdminId { get; set; }
    }
}
