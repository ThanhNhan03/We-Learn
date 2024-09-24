using AutoMapper;
using Microsoft.AspNetCore.Identity;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Models.DTOs;

namespace WeLearnAPI.Services
{
    public class AdminService : IAdminService
    {
        private readonly UserManager<Admin> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IMapper _mapper;

        public AdminService(UserManager<Admin> userManager, RoleManager<IdentityRole<Guid>> roleManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task<IdentityResult> AddAdminAsync(AddAdminRequestDTO addAdminRequest)
        {
            if (!await _roleManager.RoleExistsAsync(addAdminRequest.Role))
            {
                await _roleManager.CreateAsync(new IdentityRole<Guid>(addAdminRequest.Role));
            }

            var admin = _mapper.Map<Admin>(addAdminRequest);

            admin.CreatedAt = DateTime.Now;
            admin.UpdatedAt = DateTime.Now;

            var result = await _userManager.CreateAsync(admin, addAdminRequest.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(admin, addAdminRequest.Role);
            }

            return result;
        }
    }
}
