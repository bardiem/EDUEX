using System.Threading.Tasks;
using EDUEX.Domain;

namespace EDUEX.DAL
{
    public interface IUserAuthRepository : IBaseRepository
    {
        User Get(int id);

        Task<User> GetUserByEmailAsync(string userEmail);

        User GetUserByEmail(string userEmail);

        User GetByEmailAndPassword(string email, string password);
    }
}
