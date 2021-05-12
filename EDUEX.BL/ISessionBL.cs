using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUEX.BL
{
    public interface ISessionBL : IBaseBL
    {
        Session Create(Session session);

        IList<Session> GetAll();

        Session Update(Session session);

        void Delete(int Id);
    }
}
