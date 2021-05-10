using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUEX.DAL
{
    public interface IUserWebinarRepository
    {
        IList<UserWebinar> GetList();

        UserWebinar Create(UserWebinar userWebinar);

        UserWebinar Update(UserWebinar userWebinar);
        void Delete(int id);

        UserWebinar GetUserRole(int id);

        IList<UserWebinar> GetAll();

        IList<UserWebinar> GetByUserId(int userWebinaId);
    }
}