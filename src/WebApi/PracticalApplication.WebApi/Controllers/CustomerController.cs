using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Practical.Application.DTOs.Request;
using Practical.Application.DTOs.Response;
using Practical.Application.Interfaces;

namespace PracticalApplication.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerPolicyApplication _customerApplication;

        public CustomerController(ICustomerPolicyApplication customerApplication)
        {
            _customerApplication = customerApplication;
        }
        
        [HttpGet("/customers")]
        public async Task<IEnumerable<ViewClientPolicy>> Get()
        {
            try
            {

                return await _customerApplication.GetPolicyAllAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("/customer")]
        public async Task<object> Post([FromBody] ViewClientPolicy newPoliza)
        {
            try
            {
                await _customerApplication.AddPolicyAsync(newPoliza);
                return new ObjectResult("sukdsjf");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("/customer/")]
        public Task<ViewClientPolicy> GetById([FromQuery] Filters filtes)
        {
            try
            {

                return _customerApplication.GetPolicyByIdAsync(filtes);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
