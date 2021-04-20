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

        public DbSet<TeacherInfo> TeacherInfos { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Lection> Lections { get; set; }

        public DbSet<StudentInfo> StudentInfos { get; set; }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<CourseRole> CourseRoles { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<TeacherCourse> TeacherCourses { get; set; }

        int SaveChanges();
    }
}
