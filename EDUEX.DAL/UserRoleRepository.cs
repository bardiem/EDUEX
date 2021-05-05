using EDUEX.Data;
using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EDUEX.DAL
{
    public class UserRoleRepository : BaseRepository, IUserRoleRepository
    {

        public UserRoleRepository(Func<IEduExDbContext> getDbContext) : base(getDbContext)
        {
        }


        public UserRole Create(UserRole userRole)
            => Execute(context =>
            {
                var entInDb = context.UserRoles.Add(userRole);
                context.SaveChanges();
                return entInDb.Entity;
            });

        public void Delete(int id)
            => Execute(context =>
            {
                var entityInDb = GetUserRole(id);
                context.UserRoles.Remove(entityInDb);
                context.SaveChanges();
            });

        public IList<UserRole> GetAll()
            => Query(context => context.UserRoles.ToList());

        public UserRole GetUserRole(int id)
            => Query(context => context.UserRoles
                .FirstOrDefault(p => p.Id == id));

        public UserRole Update(UserRole userRole)
            => Execute(context =>
            {
                var entInDb = context.UserRoles.Update(userRole);
                context.SaveChanges();
                return entInDb.Entity;
            });
    }
}
