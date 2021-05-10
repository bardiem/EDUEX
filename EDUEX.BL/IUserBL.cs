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

        bool IsUserExists(string email);

        UserRole UpdateUserRole(UserRole userRole);

        UserRole AddRole(int userId, int roleId);

        IList<UserRole> GetUserRoles(int userId);

        IList<UserRole> GetUserRoles();

        void DeleteUserRole(int id);

    }
}
