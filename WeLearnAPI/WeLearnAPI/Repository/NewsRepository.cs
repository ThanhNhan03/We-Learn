using DMS_API.Repository;
using Microsoft.EntityFrameworkCore;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Repository.Interface;

namespace WeLearnAPI.Repository
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        private readonly ApplicationDbContext _context;

        public NewsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        // Get all news
        public async Task<IEnumerable<News>> GetAllNewsAsync()
        {
            return await _context.News.ToListAsync();
        }

        // Get news by id
        public async Task<News> GetNewsByIdAsync(int id)
        {
            return await _context.News.FirstOrDefaultAsync(n => n.Id == id);

        }
    }
}
