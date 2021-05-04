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
        public Role Create(Role role) =>
            Execute(context =>
            {
                var createRole = context.Roles.Add(role);
                context.SaveChanges();
                return createRole.Entity;
            });


        public Role Update(Role role)
            => Execute(context =>
            {
                var result = context.Roles.Update(role);
                context.SaveChanges();
                return result.Entity;
            });

        public string Delete(int role)
        => Execute(context =>
        {
            var role1 = context.Roles.Where(x => x.Id == role).Single<Role>();
            context.Roles.Remove(role1);
            context.SaveChanges();
            return "Record has sucessfully Deleted";
        });

        public IList<Role> GetList() => Query((context) => context.Roles.ToList());
    }
}
