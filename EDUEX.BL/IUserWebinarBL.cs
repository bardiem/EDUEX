using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUEX.BL
{
    public interface IUserWebinarBL : IBaseBL
    {
        IList<UserWebinar> GetList();

        UserWebinar Create(UserWebinar userWebinar);

        UserWebinar Update(UserWebinar userWebinar);

        void Delete(int id);
    }
}
