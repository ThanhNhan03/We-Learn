using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WeLearnAPI.Models.Domain;

namespace WeLearnAPI.Services
{
    public interface IAuthService
    {
        Task<string> GenerateJwtToken(IdentityUser<Guid> user, string role);
        Task<string> GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
