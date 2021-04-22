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

        public DbSet<Course> Courses { get; set; }

        public DbSet<Lection> Lections { get; set; }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<UserCourses> StudentCourses { get; set; }

        public DbSet<Task> Tasks { get; set; }

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


        int SaveChanges();
    }
}
