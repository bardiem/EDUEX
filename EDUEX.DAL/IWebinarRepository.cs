using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.DAL
{
    public interface IWebinarRepository : IBaseRepository
    {
        Webinar Create(Webinar webinar);

        IList<Webinar> GetAll();

        Webinar GetById(int id);

        Webinar Update(Webinar webinar);

        void Delete(int id);
    }
}
