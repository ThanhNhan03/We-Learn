using Microsoft.AspNetCore.Identity;

namespace WeLearnAPI.Services
{
    public interface IAdminService
    {
        Task<IdentityResult> AddAdminAsync(AddAdminRequestDTO addAdminRequest);
    }
}
