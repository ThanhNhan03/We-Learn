using DMS_API.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Repository.Interface;

namespace DMS_API.Repository
{
    public class UserRepository : Repository<Users>, IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Users?> GetUserByEmailAsync(string email)
        {
            return await _context.AppUsers.FirstOrDefaultAsync(u => u.Email == email);
        }
        public async Task<(IEnumerable<Users> Users, int TotalCount)> GetAllUsersAsync(
            int pageNumber, int pageSize, string? filter, string? sortOrder)
        {
            
            var query = _context.AppUsers.AsNoTracking();

           
            if (!string.IsNullOrEmpty(filter))
            {
                query = query.Where(u => u.FirstName.Contains(filter) || 
                                         u.LastName.Contains(filter) || 
                                         u.Email.Contains(filter));
            }

        
            query = sortOrder switch
            {
                "firstname_desc" => query.OrderByDescending(u => u.FirstName),
                "lastname" => query.OrderBy(u => u.LastName),
                "lastname_desc" => query.OrderByDescending(u => u.LastName),
                _ => query.OrderBy(u => u.FirstName) 
            };

            
            var totalUsers = await query.CountAsync();

            var users = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return (users, totalUsers);
        }

        public async Task<Users?> GetUserByIdAsync(Guid id)
        {
            return await _context.AppUsers.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
