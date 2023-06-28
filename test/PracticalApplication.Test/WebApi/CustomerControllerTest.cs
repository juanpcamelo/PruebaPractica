using Moq;
using Practical.Application.DTOs.Response;
using Practical.Application.Interfaces;
using PracticalApplication.Test.WebApi.TheoryTest;
using PracticalApplication.WebApi.Controllers;

namespace PracticalApplication.Test.WebApi
{
    public class CustomerControllerTest
    {
        private readonly Mock<ICustomerPolicyApplication> _customerApplicationMock;

        public CustomerControllerTest()
        {
            _customerApplicationMock = new Mock<ICustomerPolicyApplication>();
        }

        [Theory]
        [ClassData(typeof(CustomerTheory))]
        public async Task Get_Async_Test(IEnumerable<ViewClientPolicy> Result)
        {
            //Arrange

            _customerApplicationMock.Setup(c => c.GetPolicyAllAsync()).ReturnsAsync(Result);

            //Act
            var CustomerController = new CustomerController(_customerApplicationMock.Object);

            var objResult = await CustomerController.Get();


            //Assert
            Assert.NotNull(objResult);
            Assert.Equal(objResult, Result);
        }
    }
}
