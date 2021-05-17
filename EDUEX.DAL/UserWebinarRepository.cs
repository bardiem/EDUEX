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
                var createUserWebinar = context.UserWebinars.Add(userWebinar);
                context.SaveChanges();
                return createUserWebinar.Entity;
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

        public IList<UserWebinar> GetList() => Query((context) => context.UserWebinars.ToList());

        public UserWebinar GetById(int id)
            => Query(context => context.UserWebinars
                .FirstOrDefault(p => p.Id == id));
    }
}
