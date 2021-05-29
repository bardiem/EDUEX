using EDUEX.Domain;

namespace EDUEX.BL
{
    public interface IUserAuthBL : IBaseBL
    {
        User GetUserById(int id);

        User GetByEmailAndPassword(string email, string password);

        User GetByEmail(string email);
    }
}
