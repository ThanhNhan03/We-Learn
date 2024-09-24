namespace WeLearnAPI.Repository.Interface
{
    public interface IUnitOfWork
    {
        IAdminRepository Admin { get; }
        IUserRepository Users { get; }
        Task SaveChangesAsync();
    }
}