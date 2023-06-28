using Moq;
using Practical.Application.Interfaces.Auth;
using PracticalApplication.Test.WebApi.TheoryTest;
using PracticalApplication.WebApi.Controllers;

namespace PracticalApplication.Test.WebApi
{
    public class AuthControllerTest
    {
        private readonly Mock<IAuthLogin> _authLoginMock;

        public AuthControllerTest()
        {
            _authLoginMock = new Mock<IAuthLogin>();
        }

        [Theory]
        [ClassData(typeof(AuthTheory))]
        public async Task Get_Login_Async_Test(object result, string user, string password)
        {
            //Arrange

            _authLoginMock.Setup(c => c.LoginAsync(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(result);

            //Act
            var responseController = new AuthController(_authLoginMock.Object);

            var objResult = await responseController.GetLoginAsync(user, password);


            //Assert
            Assert.NotNull(objResult);
            Assert.Equal(result, objResult);
        }
    }
}
