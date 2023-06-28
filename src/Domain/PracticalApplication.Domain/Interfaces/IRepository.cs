using PracticalApplication.Domain.Customer;

namespace PracticalApplication.Domain.Interfaces
{
    public interface IRepository
    {
        Task<CustomerPolicy> GetByIdAsync(string id, string placa);
        Task<IEnumerable<CustomerPolicy>> GetAllAsync();
        Task AddAsync(CustomerPolicy customer);
        Task UpdateAsync(CustomerPolicy customer);
        Task DeleteAsync(CustomerPolicy customer);
    }
}
