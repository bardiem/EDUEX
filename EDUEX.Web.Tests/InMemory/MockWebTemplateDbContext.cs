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

        public DbSet<Course> Courses { get; set; }

        public DbSet<Lection> Lections { get; set; }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<UserCourses> StudentCourses { get; set; }

        public DbSet<Domain.Task> Tasks { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<Mark> Marks { get; set; }

        public DbSet<ModuleLections> ModuleLections { get; set; }

        public DbSet<ModuleTasks> ModuleTasks { get; set; }

        public DbSet<TaskAttachments> TaskAttachments { get; set; }

        public DbSet<UserCourses> UserCourses { get; set; }

        public DbSet<LectionAttachments> LectionAttachments { get; set; }

        public DbSet<LectionComments> LectionComments { get; set; }

        public DbSet<TaskComments> TaskComments { get; set; }


        public MockWebTemplateDbContext(DbContextOptions options) : base(options)
        {
            Seeder.Seed(this);
        }
    }
}
