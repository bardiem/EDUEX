using EDUEX.Data;
using EDUEX.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDUEX.DAL
{
    public class UserWebinarRepository : BaseRepository, IUserWebinarRepository
    {

        public UserWebinarRepository(Func<IEduExDbContext> getDbContext) : base(getDbContext)
        {
        }
        public UserWebinar Create(UserWebinar userWebinar)
            => Execute(context =>
            {
                var entInDb = context.UserWebinars.Add(userWebinar);
                context.SaveChanges();
                return entInDb.Entity;
            });

        public UserWebinar Update(UserWebinar userWebinar)
            => Execute(context =>
            {
                var entInDb = context.UserWebinars.Update(userWebinar);
                context.SaveChanges();
                return entInDb.Entity;
            });

        public void Delete(int id)
            => Execute(context =>
            {
                var entity = new UserWebinar { Id = id };
                context.UserWebinars.Remove(entity);
                context.SaveChanges();
            });

        // not implemented

        public IList<UserWebinar> GetAll()
            => Query(context => context.UserWebinars.ToList());

        public IList<UserWebinar> GetByUserId(int userWebinaId)
        {
            throw new NotImplementedException();
        }

        public IList<UserWebinar> GetList() => Query((context) => context.UserWebinars.ToList());


        public UserWebinar GetUserRole(int id)
        {
            throw new NotImplementedException();
        }






        //public IList<UserRole> GetByUserId(int userId)
        //    => Query(context => context.UserRoles
        //        .Where(u => u.UserId == userId)
        //        .ToList());


        //public UserRole GetUserRole(int id)
        //    => Query(context => context.UserRoles
        //        .FirstOrDefault(p => p.Id == id));

    }
}
