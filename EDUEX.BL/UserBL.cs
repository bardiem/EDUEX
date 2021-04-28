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

        public UserBL(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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

        public bool IsUserExists(string email)
        {
            return _userRepository.IsUserExists(email);
        }

        public User Update(User user)
        {
            return _userRepository.Update(user);
        }
    }
}
