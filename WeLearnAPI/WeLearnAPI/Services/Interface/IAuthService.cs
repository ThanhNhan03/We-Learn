using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WeLearnAPI.Models.Domain;

namespace WeLearnAPI.Services.Interface
{
    public interface IAuthService
    {
        Task<(string token, string role)> AuthenticateAdminAsync(string email, string password);
        Task<(string accessToken, string refreshToken, string role)> AuthenticateUserAsync(string email, string password);
    }
}
