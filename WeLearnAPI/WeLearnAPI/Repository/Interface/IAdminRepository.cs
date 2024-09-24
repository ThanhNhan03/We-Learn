using DMS_API.Repository.Interface;
using Microsoft.AspNetCore.Identity;
using WeLearnAPI.Models.Domain;

namespace WeLearnAPI.Repository.Interface
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Task<Admin?> GetAdminByEmailAsync(string email);
        Task<IEnumerable<Admin>> GetAllAdminsAsync(); 
        Task<Admin?> GetAdminByIdAsync(Guid id);
        //Get all teachers
        Task<IEnumerable<Admin>> GetAllTeachersAsync(string roleName);
        Task<(IEnumerable<Admin> Teachers, int TotalCount)> GetAllTeachersAsync(
            string roleName, int pageNumber, int pageSize, 
            string? filter, string? sortOrder);
    }        
}
