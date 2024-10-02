using DMS_API.Repository.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Repository.Interface;

namespace DMS_API.Repository
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Admin> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;


        public AdminRepository(ApplicationDbContext context, UserManager<Admin> userManager, RoleManager<IdentityRole<Guid>> roleManager) : base(context)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<Admin?> GetAdminByEmailAsync(string email)
        {
            return await _context.Admins.FirstOrDefaultAsync(a => a.Email == email);
        }
        public async Task<IEnumerable<Admin>> GetAllAdminsAsync()
        {
            return await _context.Admins.ToListAsync();
        }

        public async Task<Admin?> GetAdminByIdAsync(Guid id)
        {
            return await _context.Admins.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Admin>> GetAllTeachersAsync(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                return Enumerable.Empty<Admin>();
            }

            var adminIdsInRole = await _context.UserRoles
                .Where(ur => ur.RoleId == role.Id)
                .Select(ur => ur.UserId)
                .ToListAsync();

            var adminsInRole = await _context.Admins
                .Where(a => adminIdsInRole.Contains(a.Id))
                .ToListAsync();

            return adminsInRole;
        }

        public async Task<(IEnumerable<Admin> Teachers, int TotalCount)> GetAllTeachersAsync(
        string roleName, int pageNumber, int pageSize,
        string? filter, string? sortOrder)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                return (Enumerable.Empty<Admin>(), 0);
            }

            var adminIdsInRole = await _context.UserRoles
                .Where(ur => ur.RoleId == role.Id)
                .Select(ur => ur.UserId)
                .ToListAsync();

            var query = _context.Admins
                .AsNoTracking()
                .Where(a => adminIdsInRole.Contains(a.Id));

         
            if (!string.IsNullOrEmpty(filter))
            {
                query = query.Where(a => a.FirstName.Contains(filter) || a.LastName.Contains(filter) || a.Email.Contains(filter));
            }

            // Sorting
            query = sortOrder switch
            {
                "firstname_desc" => query.OrderByDescending(a => a.FirstName),
                "lastname" => query.OrderBy(a => a.LastName),
                "lastname_desc" => query.OrderByDescending(a => a.LastName),
                _ => query.OrderBy(a => a.FirstName)
            };

            var totalTeachers = await query.CountAsync();

            var teachers = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return (teachers, totalTeachers);
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

    }
}
