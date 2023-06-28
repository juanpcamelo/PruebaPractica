using AutoMapper;
using Practical.Application.DTOs.Request;
using Practical.Application.DTOs.Response;
using Practical.Application.Interfaces;
using PracticalApplication.Domain.Customer;
using PracticalApplication.Domain.Interfaces;

namespace Practical.Application.Services
{
    public class CustomerPolicyApplication : ICustomerPolicyApplication
    {
        private readonly IRepository _repositoryrepository;
        private readonly ICustomerPolicyDomain _customerPolicyDomain;
        private readonly IMapper _mapper;
        public CustomerPolicyApplication(
            IRepository repositoryrepository, 
            ICustomerPolicyDomain customerPolicyDomain,
            IMapper mapper)
        {
            _repositoryrepository = repositoryrepository ?? 
                throw new ArgumentNullException(nameof(repositoryrepository));

            _customerPolicyDomain = customerPolicyDomain ?? 
                throw new ArgumentNullException(nameof(customerPolicyDomain));
            _mapper = mapper;
        }


        public async Task<IEnumerable<ViewClientPolicy>> GetPolicyAllAsync()
        {
            try
            {
                var result = await _repositoryrepository.GetAllAsync();
                return _mapper.Map<IEnumerable<ViewClientPolicy>>(result);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task AddPolicyAsync(ViewClientPolicy viewClientPolicy)
        {
            try
            {
                var newPoliza = _customerPolicyDomain.customerPolicy(_mapper.Map<CustomerPolicy>(viewClientPolicy));

                await _repositoryrepository.AddAsync(newPoliza);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<ViewClientPolicy> GetPolicyByIdAsync(Filters filtes)
        {
            try
            {
                var result = await _repositoryrepository.GetByIdAsync(filtes.Id,filtes.Placa);
                return _mapper.Map<ViewClientPolicy>(result);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
