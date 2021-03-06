using EDUEX.Data;
using EDUEX.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EDUEX.DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(Func<IEduExDbContext> getDbContext) : base(getDbContext)
        {
        }


        public User Create(User user)
            => Execute(context =>
            {
                context.Users.Add(user);
                context.SaveChanges();
                return user;
            });


        public IList<User> GetAll()
            => Query(context => context.Users.AsNoTracking().ToList());


        public User GetById(int id)
            => Query(context => context.Users
                .FirstOrDefault(p => p.Id == id));

        public User GetWithWebinarsById(int id)
            => Query(context => context.Users
                .Include(u => u.UserWebinars)
                .Select(u=> new User
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Balance = u.Balance,
                    BirthDate = u.BirthDate,
                    Email = u.Email,
                    Position = u.Position,
                    UserWebinars = u.UserWebinars.Select(uw=> new UserWebinar{Webinar = uw.Webinar}).OrderByDescending(w => w.Webinar.EnrollDeadline).ToList()
                })
                .FirstOrDefault(p => p.Id == id));

        public bool IsUserExists(string email)
            => Query(context => context.Users.Any(u => u.Email == email));


        public User Update(User user)
            => Execute(context =>
            {
                var result = context.Users.Update(user);
                context.SaveChanges();
                return result.Entity;
            });
    }
}
