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


        public IList<Webinar> GetAll()
            => Query(context => context.Webinars.AsNoTracking().ToList());


        public Webinar GetById(int id)
            => Query(context => context.Webinars
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
    }
}
