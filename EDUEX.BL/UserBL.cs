using EDUEX.DAL;
using EDUEX.Domain;
using System;
using System.Collections.Generic;

namespace EDUEX.BL
{
    public class UserBL : IUserBL
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IWebinarRepository _webinarRepository;

        public UserBL(IUserRepository userRepository, IUserRoleRepository userRoleRepository, IWebinarRepository webinarRepository)
        {
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _webinarRepository = webinarRepository;
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
            

        public void DeleteUserRole(int id)
        {
            _userRoleRepository.Delete(id);
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


        public IList<UserRole> GetUserRoles(int userId)
        {
            return _userRoleRepository.GetByUserId(userId);
        }

        public User GetUserWithWebinars(int id)
        {
            return _userRepository.GetWithWebinarsById(id);
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
            return _userRoleRepository.Update(userRole);
        }
    }
}
