using EDUEX.Domain;
using System.Collections.Generic;

namespace EDUEX.DAL
{
    public interface IUserRepository : IBaseRepository
    {
        User GetById(int id);

        User GetWithWebinarsById(int id);

        User Create(User user);

        IList<User> GetAll();

        User Update(User user);

        bool IsUserExists(string email);
    }
}
