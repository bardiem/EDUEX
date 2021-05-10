using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUEX.BL
{
    public interface IUserWebinarBL
    {
        IList<UserWebinar> GetList();

        UserWebinar Create(UserWebinar role);

        UserWebinar Update(UserWebinar role);

        void Delete(int id);
    }
}
