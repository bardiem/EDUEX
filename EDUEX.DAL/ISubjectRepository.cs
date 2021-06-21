using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.DAL
{
    public interface ISubjectRepository : IBaseRepository
    {
        IList<Subject> GetAll();

        Subject GetWithWebinarsById(int id);
    }
}
