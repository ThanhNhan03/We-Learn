namespace WeLearnAPI.Repository.Interface
{
    public interface IUnitOfWork
    {
        IAdminRepository Admin { get; }
        IUserRepository Users { get; }
        INewsRepository News { get; }
        IFaqRepository Faq { get; }
        Task SaveChangesAsync();
    }
}