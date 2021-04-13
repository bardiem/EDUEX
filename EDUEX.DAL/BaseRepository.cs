using System;
using EDUEX.Data;

namespace EDUEX.DAL
{
    public class BaseRepository
    {

        private readonly Lazy<IEduExDbContext> lazyContext;

        private IEduExDbContext context => lazyContext.Value;


        protected readonly Func<IEduExDbContext> getDbContext;

        public BaseRepository(Func<IEduExDbContext> getDbContext)
        {
            this.getDbContext = getDbContext;
            lazyContext = new Lazy<IEduExDbContext>(() => getDbContext());
        }

        protected T Execute<T>(Func<IEduExDbContext, T> functor)
        {
            using (var dbContext = getDbContext())
            {
                return functor(dbContext);
            }
        }

        protected T Query<T>(Func<IEduExDbContext, T> functor)
        {
            return functor(context);
        }
    }
}
