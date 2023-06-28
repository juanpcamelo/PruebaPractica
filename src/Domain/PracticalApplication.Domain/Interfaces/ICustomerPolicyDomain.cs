using PracticalApplication.Domain.Customer;

namespace PracticalApplication.Domain.Interfaces
{
    public interface ICustomerPolicyDomain
    {
        CustomerPolicy customerPolicy(CustomerPolicy customerPolicy);
    }
}
