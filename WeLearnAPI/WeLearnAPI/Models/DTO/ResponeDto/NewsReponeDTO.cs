using System.ComponentModel.DataAnnotations;

namespace WeLearnAPI.Models.DTO.ResponeDto
{
    public class NewsReponeDTO
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string AdminName { get; set; } = string.Empty;
    }
}
