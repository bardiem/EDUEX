using EDUEX.Data;
using EDUEX.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.DAL
{
    public class SubjectRepository : BaseRepository, ISubjectRepository 
    {
        public SubjectRepository(Func<IEduExDbContext> getDbContext) : base(getDbContext)
        {

        }

        public IList<Subject> GetAll()
            => Query(context => context.Subjects.AsNoTracking().ToList());

        public Subject GetWithWebinarsById(int id)
            => Query(context => context.Subjects
        .Include(w => w.Webinars)
        .FirstOrDefault(p => p.Id == id));
    }
}
