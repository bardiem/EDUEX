using EDUEX.Domain;
using System.Collections.Generic;

namespace EDUEX.DAL
{
    public interface IWebinarRepository : IBaseRepository
    {
        Webinar Create(Webinar webinar);

        Webinar CreateWithUserWebinar(Webinar webinar, int userId);

        IList<Webinar> GetAll();

        Webinar GetById(int id);

        IList<string> GetSubjects();

        Webinar GetWithSessionsById(int id);

        Webinar Update(Webinar webinar);

        void Delete(int id);
    }
}
