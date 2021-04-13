using System;
using System.Collections.Generic;
using System.Linq;
using EDUEX.Data;
using EDUEX.Domain;

namespace EDUEX.DAL
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(Func<IEduExDbContext> getDbContext) : base(getDbContext)
        {

        }


        public IList<Role> GetList() => Query((context) => context.Roles.ToList());
    }
}
