using System;
using System.Collections.Generic;
using System.Linq;
using EDUEX.Data;
using EDUEX.Domain;
using Microsoft.EntityFrameworkCore;

namespace EDUEX.DAL
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(Func<IEduExDbContext> getDbContext) : base(getDbContext)
        {

        }
        public Role Create(Role role)
            => Execute(context =>
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

        public void Delete(int id)
            => Execute(context =>
            {
                var role = new Role { Id = id };
                context.Roles.Remove(role);
                context.SaveChanges();
            });

        public Role GetById(int id)
            => Query(context => context.Roles
                .FirstOrDefault(p => p.Id == id));



        public IList<Role> GetList() 
            => Query((context) => context.Roles.AsNoTracking().ToList());
    }
}
