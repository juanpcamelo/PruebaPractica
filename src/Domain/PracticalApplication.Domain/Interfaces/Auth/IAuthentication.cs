namespace PracticalApplication.Domain.Interfaces.Auth
{
    public interface IAuthentication
    {
        string GetAuthAsync(string username);
    }
}
