using System;
using System.Collections.Generic;
using System.Text;
using EDUEX.DAL;
using EDUEX.Domain;

namespace EDUEX.BL
{
    public class SessionBL : ISessionBL
    {
        private readonly ISessionRepository _sessionRepository;
        public SessionBL(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }
        public IList<Session> GetAll()
        {
            return _sessionRepository.GetAll();
        }

        public Session GetById(int id)
        {
            return _sessionRepository.GetById(id);
        }

        public Session Create(Session session)
        {
            return _sessionRepository.Create(session);
        }

        public Session Update(Session session)
        {
            return _sessionRepository.Update(session);
        }

        public void Delete(int session)
        {
            _sessionRepository.Delete(session);
        }
    }

}
