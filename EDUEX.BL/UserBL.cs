using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUEX.DAL;
using EDUEX.Domain;

namespace EDUEX.BL
{
    public class UserBL : IUserBL
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;

        public UserBL(IUserRepository userRepository, IUserRoleRepository userRoleRepository)
        {
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
        }

        public UserRole AddRole(int userId, int roleId)
        {
            var createdEnt = _userRoleRepository.Create(new UserRole
            {
                UserId = userId,
                RoleId = roleId
            });
            return createdEnt;
        }

        public User Create(User user)
        {
            return _userRepository.Create(user);
        }

        public IList<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public IList<UserRole> GetUserRoles()
        {
            return _userRoleRepository.GetAll();
        }

        public bool IsUserExists(string email)
        {
            return _userRepository.IsUserExists(email);
        }

        public User Update(User user)
        {
            return _userRepository.Update(user);
        }

        public UserRole UpdateUserRole(UserRole userRole)
        {
            throw new NotImplementedException();
        }
    }
}
