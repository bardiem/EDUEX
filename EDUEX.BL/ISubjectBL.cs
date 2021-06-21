using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.BL
{
    public interface ISubjectBL : IBaseBL
    {
       IList<Subject> GetAll();

        public Subject GetWithWebinarsById(int id);
    }
}
