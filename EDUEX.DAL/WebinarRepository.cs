using EDUEX.Data;
using EDUEX.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EDUEX.DAL
{
    public class WebinarRepository : BaseRepository, IWebinarRepository
    {
        public WebinarRepository(Func<IEduExDbContext> getDbContext) : base(getDbContext)
        {
        }


        public Webinar Create(Webinar webinar)
            => Execute(context =>
            {
                context.Webinars.Add(webinar);
                context.SaveChanges();
                return webinar;
            });


        public Webinar CreateWithUserWebinar(Webinar webinar, int userId)
            => Execute(context =>
            {
                context.Webinars.Add(webinar);
                context.SaveChanges();

                context.UserWebinars.Add(new UserWebinar
                {
                    UserId = userId,
                    EnrollDate = DateTime.UtcNow,
                    WebinarId = webinar.Id,
                    AccessType = Domain.Enums.CourseAccessTypeEnum.Teacher
                });
                context.SaveChanges();
                return webinar;
            });


        public IList<Webinar> GetAll()
            => Query(context => context.Webinars.AsNoTracking().ToList());

        public IList<Webinar> GetBySubject(string subject)
            => Query(context => context.Webinars
            .AsNoTracking().Where(w=>w.Subject == subject || subject == null).ToList());

        public Webinar GetById(int id)
            => Query(context => context.Webinars
                .FirstOrDefault(p => p.Id == id));


        public Webinar GetWithSessionsById(int id)
            => Query(context => context.Webinars
                .Include(w => w.Sessions)
                .FirstOrDefault(p => p.Id == id));


        public Webinar Update(Webinar webinar)
            => Execute(context =>
            {
                var result = context.Webinars.Update(webinar);
                context.SaveChanges();
                return result.Entity;
            });

        public void Delete(int id)
            => Execute(context =>
            {
                var webinar = new Webinar { Id = id };
                context.Webinars.Remove(webinar);
                context.SaveChanges();
            });

        public IList<string> GetSubjects()
            => Execute(context => context.Webinars
                .Select(w => w.Subject)
                .Distinct()
                .ToList());
    }
}
