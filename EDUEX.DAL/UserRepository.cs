using AutoMapper;
using EDUEX.Data;
using EDUEX.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            => Query(context => context.Users.ToList());


        public User GetById(int id)
            => Query(context => context.Users
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
