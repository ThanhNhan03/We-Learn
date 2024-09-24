﻿using System.ComponentModel.DataAnnotations;

namespace WeLearnAPI.Models.DTO.RequestDto
{
    public class LoginRequestDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
