using System;
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

        private readonly Lazy<INewsRepository> _news;
        public INewsRepository News => _news.Value;
        public IFaqRepository Faq { get; private set; }


        public UnitOfWork(ApplicationDbContext context, UserManager<Admin> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            Admin = new AdminRepository(_context, _userManager, _roleManager);
            Users = new UserRepository(_context);
            _news = new Lazy<INewsRepository>(() => new NewsRepository(_context));
            Faq = new FaqRepository(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

      
        //public void Dispose()
        //{
        //    _context.Dispose();
        //    if (_news.IsValueCreated)
        //    {
        //        (_news.Value as IDisposable)?.Dispose();
        //    }
        //}
    }
}