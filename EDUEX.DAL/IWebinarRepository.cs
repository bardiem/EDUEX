using EDUEX.Domain;
using System.Collections.Generic;

namespace EDUEX.DAL
{
    public interface IWebinarRepository : IBaseRepository
    {
        Webinar Create(Webinar webinar);

        IList<Webinar> GetAll();

        Webinar GetById(int id);

        Webinar GetWithSessionsById(int id);

        Webinar Update(Webinar webinar);

        void Delete(int id);
    }
}
