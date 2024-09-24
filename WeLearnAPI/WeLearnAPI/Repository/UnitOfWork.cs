using DMS_API.Repository;
using Microsoft.AspNetCore.Identity;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Repository.Interface;

namespace WeLearnAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Admin> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        public IAdminRepository Admin { get; private set; }

        public IUserRepository Users { get; private set; }
        public INewsRepository News { get; private set; }

        public UnitOfWork(ApplicationDbContext context, UserManager<Admin> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            Admin = new AdminRepository(_context, _userManager, _roleManager);
            Users = new UserRepository(_context);
            News = new NewsRepository(_context);
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}
    }
}