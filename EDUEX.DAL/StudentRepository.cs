using EDUEX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.DAL
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public StudentRepository(Func<IEduExDbContext> getDbContext) : base(getDbContext)
        {
        }


    }
}
