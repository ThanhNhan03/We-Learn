using System.ComponentModel.DataAnnotations;

namespace WeLearnAPI.Models.Domain
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Foreign Key
        public Guid AdminId { get; set; }

        // Navigation Property
        public Admin Admin { get; set; }
    }
}
