using EDUEX.DAL;
using EDUEX.Domain;
using EDUEX.Domain.Contracts.Requests.Queries;
using EDUEX.Domain.Enums;
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

        public IList<Webinar> GetBySubjectOrdered(WebinarSortingQuery query)
        {
            var result = _webinarRepository.GetBySubject(query.Subject);
            switch (query.OrderType)
            {
                case SortingTypeEnum.CheapFirst:
                    return result.OrderBy(r => r.Price).ToList();
                case SortingTypeEnum.ExpensiveFirst:
                    return result.OrderByDescending(r => r.Price).ToList();
                default:
                    return result.OrderByDescending(r => r.EnrollDeadline).ToList();
            }

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

        public DateTime? GetEarliestSessionStart(int id)
        {
            var webinar = GetWithSessionsById(id);
            if(webinar.Sessions.Count() > 0)
                return webinar.Sessions.Min(s => s.StartDate);
            return null;
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
