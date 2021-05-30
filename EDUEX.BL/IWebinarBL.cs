using EDUEX.Domain;
using EDUEX.Domain.Contracts.Requests.Queries;
using EDUEX.Domain.Enums;
using System;
using System.Collections.Generic;

namespace EDUEX.BL
{
    public interface IWebinarBL : IBaseBL
    {
        Webinar Create(Webinar webinar);

        Webinar Create(Webinar webinar, int userId);

        IList<Webinar> GetAll();

        IList<Webinar> GetBySubjectOrdered(WebinarSortingQuery query);

        Webinar GetById(int id);

        Webinar GetWithSessionsById(int id);

        Webinar Update(Webinar webinar);

        void Delete(int id);

        DateTime? GetEarliestSessionStart(int id);

        IList<string> GetSubjects();
    }
}
