using DMS_API.Repository.Interface;

namespace WeLearnAPI.Repository.Interface
{
    public interface IUserRepository : IRepository<Users>
    {
        Task<Users?> GetUserByEmailAsync(string email);

        Task<Users?> GetUserByIdAsync(Guid id);

        Task<(IEnumerable<Users> Users, int TotalCount)> GetAllUsersAsync(
            int pageNumber, int pageSize, string? filter, string? sortOrder);
    }
}
