using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUEX.DAL
{
    public interface IUserWebinarRepository : IBaseRepository
    {
        IList<UserWebinar> GetList();

        UserWebinar GetById(int id);

        UserWebinar Create(UserWebinar userWebinar);

        UserWebinar Update(UserWebinar userWebinar);

        void Delete(int id);
    }
}