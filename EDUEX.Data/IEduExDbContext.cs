using Microsoft.EntityFrameworkCore;
using System;
using EDUEX.Domain;

namespace EDUEX.Data
{
    public interface IEduExDbContext : IDisposable
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Webinar> Webinars { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<UserWebinar> UserWebinars { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Lection> Lections { get; set; }


        int SaveChanges();
    }
}
