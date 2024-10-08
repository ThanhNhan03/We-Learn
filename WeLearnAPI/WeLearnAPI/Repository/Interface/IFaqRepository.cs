using DMS_API.Repository.Interface;
using WeLearnAPI.Models.Domain;

namespace WeLearnAPI.Repository.Interface
{
    public interface IFaqRepository : IRepository<Faq>
    {
        
        Task<IEnumerable<Faq>> GetAllFaqsAsync();
        Task<Faq> GetFaqByIdAsync(int id);
       
        Task<Faq> UpdateFaqAsync(Faq faq);
        
    }
}
