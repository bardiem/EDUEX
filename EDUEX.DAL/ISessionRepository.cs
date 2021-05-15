using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDUEX.DAL
{
    public interface ISessionRepository : IBaseRepository
    {

        Session Create(Session session);

        IList<Session> GetAll();

        Session GetById(int id);

        Session Update(Session session);

        void Delete(int Id);
    }
}
