using Practical.Application.DTOs.Request;
using Practical.Application.DTOs.Response;

namespace Practical.Application.Interfaces
{
    public interface ICustomerPolicyApplication
    {
        Task<IEnumerable<ViewClientPolicy>> GetPolicyAllAsync();
        Task AddPolicyAsync(ViewClientPolicy viewClientPolicy);
        Task<ViewClientPolicy> GetPolicyByIdAsync(Filters filtes);
    }
}
