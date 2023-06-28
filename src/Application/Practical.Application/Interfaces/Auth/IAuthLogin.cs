namespace Practical.Application.Interfaces.Auth
{
    public interface IAuthLogin
    {
        Task<object> LoginAsync( string user, string passwoord);
    }
}
