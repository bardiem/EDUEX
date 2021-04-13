using Microsoft.EntityFrameworkCore;
using System;
using EDUEX.Domain;

namespace EDUEX.Data
{
    public interface IEduExDbContext : IDisposable
    {
        DbSet<User> Users { get; set; }

        DbSet<Role> Roles { get; set; }

        DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Teachers> Teachers { get; set; }

        public DbSet<Courses> Courses { get; set; }

        public DbSet<Lections> Lections { get; set; }

        public DbSet<Students> Students { get; set; }

        public DbSet<Attachments> Attachments { get; set; }

        public DbSet<CourseRoles> CourseRoles { get; set; }

        public DbSet<Modules> Modules { get; set; }

        public DbSet<StudentsOfCourses> StudentsOfCourses { get; set; }

        public DbSet<Tasks> Tasks { get; set; }

        public DbSet<TeachersOfCourses> TeachersOfCourses { get; set; }

        int SaveChanges();
    }
}
