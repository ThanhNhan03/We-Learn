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
        public async Task<(IEnumerable<News>, int)> GetAllNewsAsync(
                int pageNumber,
                int pageSize,
                string sortBy = "Date",
                bool isDescending = true,
                string titleFilter = null)
        {
            var query = _context.News.AsQueryable();

            // Lọc theo tiêu đề nếu có
            if (!string.IsNullOrEmpty(titleFilter))
            {
                query = query.Where(n => n.Title.Contains(titleFilter));
            }

            // Tổng số bản ghi
            int totalCount = await query.CountAsync();

            // Sắp xếp
            query = sortBy switch
            {
                "Title" => isDescending ? query.OrderByDescending(n => n.Title) : query.OrderBy(n => n.Title),
                _ => isDescending ? query.OrderByDescending(n => n.CreatedAt) : query.OrderBy(n => n.CreatedAt)
            };

            // Phân trang
            query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            return (await query.AsNoTracking().ToListAsync(), totalCount);
        }


        // Get news by id
        public async Task<News> GetNewsByIdAsync(int id)
        {
            return await _context.News.FirstOrDefaultAsync(n => n.Id == id);

        }
    }
}
