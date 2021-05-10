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
                var entity = new UserRole {Id = id };
                context.UserRoles.Remove(entity);
                context.SaveChanges();
            });

        public IList<UserRole> GetAll()
            => Query(context => context.UserRoles.ToList());


        public IList<UserRole> GetByUserId(int userId)
            => Query(context => context.UserRoles
                .Where(u => u.UserId == userId)
                .ToList());


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
