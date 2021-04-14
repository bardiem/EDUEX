using EDUEX.Data;
using EDUEX.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.Web.Tests.InMemory
{
    public class MockWebTemplateDbContext : DbContext, IEduExDbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Domain.Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<TeacherInfo> TeacherInfos { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Lection> Lections { get; set; }

        public DbSet<StudentInfo> StudentInfos { get; set; }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<CourseRole> CourseRoles { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<Domain.Task> Tasks { get; set; }

        public DbSet<TeacherCourse> TeacherCourses { get; set; }

        public MockWebTemplateDbContext(DbContextOptions options) : base(options)
        {
            Seeder.Seed(this);
        }
    }
}
