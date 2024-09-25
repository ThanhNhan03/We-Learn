namespace WeLearnAPI.Models.DTO.ResponeDto
{
    public class TokenRequestDTO
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}
