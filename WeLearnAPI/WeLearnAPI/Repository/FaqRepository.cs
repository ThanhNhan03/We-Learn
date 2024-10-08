

using DMS_API.Repository;
using Microsoft.EntityFrameworkCore;
using WeLearnAPI.Models.Domain;
using WeLearnAPI.Repository.Interface;

namespace WeLearnAPI.Repository
{
    public class FaqRepository : Repository<Faq>, IFaqRepository
    {
        private readonly ApplicationDbContext _context;
        public FaqRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Faq>> GetAllFaqsAsync()
        {
            return await _context.Faqs
                .AsNoTracking() 
                .Include(f => f.Admin) 
                .ToListAsync();  
        }
         
         public async Task<Faq> GetFaqByIdAsync(int id)
        {
            return await _context.Faqs
                .AsNoTracking()
                .Include(f => f.Admin)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
         public async Task<Faq> UpdateFaqAsync(Faq faq)
         {
            _context.Faqs.Update(faq);
            await _context.SaveChangesAsync();
            return faq;
         }
        
    }

}
