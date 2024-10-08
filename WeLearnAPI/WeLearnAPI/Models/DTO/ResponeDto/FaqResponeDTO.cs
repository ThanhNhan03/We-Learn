namespace WeLearnAPI.Models.DTO.ResponeDto
{
    public class FaqResponeDTO
    {
        public string Id { get; set; } = string.Empty;
        public string FaqQuestion { get; set; } = string.Empty;
        public string FaqAnswer { get; set; } = string.Empty;
        public string FaqCategories { get; set; } = string.Empty;
        public string AdminName { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
    }
}
