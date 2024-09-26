using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Services.Interface;

namespace WeLearnAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<Users> _userManager;
        private readonly UserManager<Admin> _adminManager;
        private readonly IJwtTokenService _jwtTokenService;

        public AuthService(
            UserManager<Users> userManager,
            UserManager<Admin> adminManager,
            IJwtTokenService jwtTokenService)
        {
            _userManager = userManager;
            _adminManager = adminManager;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<(string token, string role)> AuthenticateAdminAsync(string email, string password)
        {
            var admin = await _adminManager.FindByEmailAsync(email);
            if (admin != null && await _adminManager.CheckPasswordAsync(admin, password))
            {
                var roles = await _adminManager.GetRolesAsync(admin);
                var role = roles.FirstOrDefault() ?? "Admin"; // Assuming admin has a role

                var token = await _jwtTokenService.GenerateJwtToken(admin, role);
                return (token, role);
            }
            return (null, null);
        }

        public async Task<(string accessToken, string refreshToken, string role)> AuthenticateUserAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null && await _userManager.CheckPasswordAsync(user, password))
            {
                var accessToken = await _jwtTokenService.GenerateJwtToken(user, "User");
                var refreshToken = await _jwtTokenService.GenerateRefreshToken();

                user.RefreshToken = refreshToken;
                user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7); // Token hết hạn sau 7 ngày
                await _userManager.UpdateAsync(user);

                return (accessToken, refreshToken, "User");
            }
            return (null, null, null);
        }
    }
}
