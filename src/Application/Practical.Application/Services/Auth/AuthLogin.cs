using Practical.Application.DTOs.Request;
using Practical.Application.Interfaces.Auth;
using PracticalApplication.Domain.Interfaces.Auth;

namespace Practical.Application.Services.Auth
{
    public class AuthLogin : IAuthLogin
    {
        private readonly IAuthentication _authentication;

        public AuthLogin(IAuthentication authentication)
        {
            _authentication = authentication ?? throw new ArgumentNullException(nameof(authentication));
        }

        public async Task<object> LoginAsync(string user, string passwoord)
        {
            try
            {
                string token = string.Empty;

                if (string.IsNullOrEmpty(user))
                    throw new InvalidOperationException($"usuario o clave incorrecta");

                if (string.IsNullOrEmpty(passwoord))
                    throw new InvalidOperationException($"usuario o clave incorrecta");

                var currenUser = new User();
                if (currenUser.user == user && currenUser.password == passwoord)
                {
                    token = _authentication.GetAuthAsync(user);
                    return await Task.FromResult(new { User = user, Token = token });
                }
                return await Task.FromResult(new { User = user });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
