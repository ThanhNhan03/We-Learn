using DMS_API.Repository.Interface;
using WeLearnAPI.Models.Domain;

namespace WeLearnAPI.Repository.Interface
{
    public interface INewsRepository : IRepository<News>
    {
        // Get all news
       Task<(IEnumerable<News>, int)> GetAllNewsAsync(int pageNumber, int pageSize, string sortBy, bool isDescending, string titleFilter);
        // Get news by id
        Task<News> GetNewsByIdAsync(int id);
    }
}
