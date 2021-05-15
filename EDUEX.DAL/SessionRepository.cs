using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDUEX.Data;
using EDUEX.Domain;
using Microsoft.EntityFrameworkCore;

namespace EDUEX.DAL
{
   public class SessionRepository : BaseRepository, ISessionRepository
    {
        public SessionRepository(Func<IEduExDbContext> getDbContext) : base(getDbContext)
        {
        }

        public Session Create(Session session) 
            => Execute(context =>
            {
                var createSession = context.Sessions.Add(session);
                context.SaveChanges();
                return createSession.Entity;
            });

        public IList<Session> GetAll()
            => Query(context => context.Sessions.AsNoTracking().ToList());

        public Session GetById(int id)
            => Query(context => context.Sessions
                .FirstOrDefault(p => p.Id == id));

        public Session Update(Session session) 
            => Execute(context =>
            {
                var updateSession = context.Sessions.Update(session);
                context.SaveChanges();
                return updateSession.Entity;
            });

        public void Delete(int id)
            => Execute(context =>
            {
                var session = new Session { Id = id };
                context.Sessions.Remove(session);
                context.SaveChanges();
            });
    }
}
