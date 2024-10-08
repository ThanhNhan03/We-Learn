using System.ComponentModel.DataAnnotations;

namespace WeLearnAPI.Models.Domain
{
    public class Faq
    {
        public int Id { get; set; }
         [Required]
        [MaxLength(50)]
        public string FaqQuestion { get; set; } = string.Empty;
         [Required]
        [MaxLength(255)]
        public string FaqAnswer { get; set; } = string.Empty;
         [Required]
        [MaxLength(255)]
        public string FaqCategories { get; set; } = string.Empty;
         [Required]
        [MaxLength(50)]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Foreign Key
        public Guid AdminId { get; set; }

        // Navigation Property
        public required Admin Admin { get; set; }

    }
}
