using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace WeLearnAPI.Services.Interface
{
    public interface IJwtTokenService
    {
        Task<string> GenerateJwtToken(IdentityUser<Guid> user, string role);
        Task<string> GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
