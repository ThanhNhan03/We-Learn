﻿namespace WeLearnAPI.Models.DTO.ResponeDto
{
    public class AdminLoginResponeDTO
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
    }
}
