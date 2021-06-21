using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUEX.Domain;
using EDUEX.DAL;

namespace EDUEX.BL
{
    public class SubjectBL : ISubjectBL
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectBL(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        IList<Subject> ISubjectBL.GetAll()
        {
            return _subjectRepository.GetAll();
        }

        public Subject GetWithWebinarsById(int id)
        {
            return _subjectRepository.GetWithWebinarsById(id);
        }
    }
}
