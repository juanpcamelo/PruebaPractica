using PracticalApplication.Domain.Customer;
using PracticalApplication.Domain.Interfaces;

namespace PracticalApplication.Domain.Services
{
    public class CustomerPolicyDomain : ICustomerPolicyDomain
    {
        public CustomerPolicy customerPolicy(CustomerPolicy customerPolicy)
        {
            if (customerPolicy.PolizaStartDate <= DateTime.Now)
            {
                throw new InvalidOperationException("La fecha de la póliza no puede ser posterior a la fecha actual.");
            }
            customerPolicy.PolizaEndDate = CalcularFechaFinal(customerPolicy.PolizaStartDate);
            return customerPolicy;

        }

        public DateTime CalcularFechaFinal(DateTime fechaInicio)
        {
            DateTime fechaFinal = fechaInicio.AddYears(1);
            return fechaFinal;
        }
    }
}
