using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WeLearnAPI.Models.Domain;

namespace WeLearnAPI.Services
{
    public interface IAuthService
    {
        Task<string> GenerateJwtToken(IdentityUser<Guid> user, string role);
    }
}
