using EDUEX.Domain;
using System.Collections.Generic;

namespace EDUEX.BL
{
    public interface IUserBL : IBaseBL
    {
        User GetById(int id);

        User Create(User user);

        IList<User> GetAll();

        User Update(User user);

        UserRole UpdateUserRole(UserRole userRole);

        bool IsUserExists(string email);

        UserRole AddRole(int userId, int roleId);

        IList<UserRole> GetUserRoles();
    }
}
