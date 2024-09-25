using System.ComponentModel.DataAnnotations;

namespace WeLearnAPI.Models.DTO.RequestDto
{
    public class ResetPasswordRequestDTO
    {
        [Required]
        public string Token { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string NewPassword { get; set; }
    }
}
