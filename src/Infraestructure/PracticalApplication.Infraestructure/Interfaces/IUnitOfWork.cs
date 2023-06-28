using PracticalApplication.Domain.Interfaces;

namespace PracticalApplication.Infraestructure.Interfaces
{
    public interface IUnitOfWork 
    {
        IRepository CustomerRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
