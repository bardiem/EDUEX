using EDUEX.Domain;
using EDUEX.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUEX.BL
{
    public class UserWebinarBL : IUserWebinarBL
    {
        private readonly IUserWebinarRepository userWebinarRepository;

        public UserWebinarBL(IUserWebinarRepository userWebinarRepository)
        {
            this.userWebinarRepository = userWebinarRepository;
        }

        public IList<UserWebinar> GetList()
        {
            return userWebinarRepository.GetList();
        }

        public UserWebinar Create(UserWebinar userWebinar)
        {
            return userWebinarRepository.Create(userWebinar);
        }

        public UserWebinar Update(UserWebinar userWebinar)
        {
            return userWebinarRepository.Update(userWebinar);
        }

        public void Delete(int id)
        {
            userWebinarRepository.Delete(id);
        }

        public UserWebinar GetById(int id) {
            return userWebinarRepository.GetById(id);
        }
    }
}
