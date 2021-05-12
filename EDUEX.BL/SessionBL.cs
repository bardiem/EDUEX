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

        public Session Create(Session role)
        {
            return _sessionRepository.Create(role);
        }

        public Session Update(Session role)
        {
            return _sessionRepository.Update(role);
        }

        public void Delete(int role)
        {
            _sessionRepository.Delete(role);
        }
    }

}
