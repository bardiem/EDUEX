using EDUEX.DAL;
using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EDUEX.BL
{
    public class WebinarBL : IWebinarBL
    {
        private readonly IWebinarRepository _webinarRepository;
        private readonly IUserWebinarRepository _userWebinarRepository;

        public WebinarBL(IWebinarRepository webinarRepository, 
            IUserWebinarRepository userWebinarRepository)
        {
            _webinarRepository = webinarRepository;
            _userWebinarRepository = userWebinarRepository;
        }

        public Webinar Create(Webinar webinar)
        {
            return _webinarRepository.Create(webinar);
        }

        public Webinar Create(Webinar webinar, int userId)
        {
            return _webinarRepository.CreateWithUserWebinar(webinar, userId);
        }

        public IList<Webinar> GetAll()
        {
            return _webinarRepository.GetAll();
        }

        public Webinar GetById(int id)
        {
            return _webinarRepository.GetById(id);
        }

        public Webinar Update(Webinar webinar)
        {
            return _webinarRepository.Update(webinar);
        }

        public void Delete(int webinar)
        {
            _webinarRepository.Delete(webinar);
        }

        public DateTime GetEarliestSessionStart(int id)
        {
            var webinar = GetWithSessionsById(id);
            return webinar.Sessions.Min(s => s.StartDate);
        }

        public Webinar GetWithSessionsById(int id)
        {
            return _webinarRepository.GetWithSessionsById(id);
        }

        public IList<string> GetSubjects()
        {
            return _webinarRepository.GetSubjects();
        }
    }
}
