namespace EDUEX.Web.Services
{
    public interface IIdentityService
    {
        string Authenticate(string email, string password);
    }
}
