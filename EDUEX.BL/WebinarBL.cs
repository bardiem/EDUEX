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

        public WebinarBL(IWebinarRepository webinarRepository)
        {
            _webinarRepository = webinarRepository;
        }

        public Webinar Create(Webinar webinar)
        {
            return _webinarRepository.Create(webinar);
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
    }
}
