using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WeLearnAPI.Models.Domain
{
    public class Admin : IdentityUser<Guid>
    {
        [MaxLength(255)]
        public string? FirstName { get; set; }
        [MaxLength(255)]
        public string? LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public byte? Gender { get; set; }
        [MaxLength(255)]
        public string? Image { get; set; }
        [MaxLength(100)]
        public string? RememberToken { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        //Navigation Property
        public ICollection<News> News { get; set; } = new List<News>();
    }
}
