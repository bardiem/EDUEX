using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUEX.Data;
using EDUEX.Domain;

namespace EDUEX.DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(Func<IWebTemplateDbContext> getDbContext) : base(getDbContext)
        {
        }

        public User GetById(int id)
            => Query(context => context.Users.FirstOrDefault(p => p.Id == id));
    }
}
