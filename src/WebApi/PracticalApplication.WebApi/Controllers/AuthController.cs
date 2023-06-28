using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practical.Application.Interfaces.Auth;

namespace PracticalApplication.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthLogin _authLogin;

        public AuthController(IAuthLogin authLogin)
        {
            _authLogin = authLogin ?? throw new ArgumentNullException(nameof(authLogin));
        }

        [HttpGet("login")]
        public Task<object> GetLoginAsync(string user, string password)
        {
            try
            {
                return _authLogin.LoginAsync(user, password);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
