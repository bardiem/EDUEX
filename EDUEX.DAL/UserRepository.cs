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

        public User GetById(int id)
            => Query(context => context.Users
                .Include(p => p.StudentInfo)
                .Include(p => p.TeacherInfo)
                .FirstOrDefault(p => p.Id == id));
    }
}
