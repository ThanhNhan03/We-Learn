using Microsoft.AspNetCore.Identity;

namespace WeLearnAPI.Services.Interface
{
    public interface IAdminService
    {
        Task<IdentityResult> AddAdminAsync(AddAdminRequestDTO addAdminRequest);
    }
}
