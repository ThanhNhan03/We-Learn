using DMS_API.Repository.Interface;
using WeLearnAPI.Models.Domain;

namespace WeLearnAPI.Repository.Interface
{
    public interface INewsRepository : IRepository<News>
    {
        // Get all news
        Task<IEnumerable<News>> GetAllNewsAsync();

        // Get news by id
        Task<News> GetNewsByIdAsync(int id);

    }
}
