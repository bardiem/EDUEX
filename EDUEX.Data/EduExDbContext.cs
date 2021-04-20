using EDUEX.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace EDUEX.Data
{
    public class EduExDbContext : DbContext, IEduExDbContext
    {
        public static readonly ILoggerFactory DbContextLoggerFactory;

        //static WebTemplateDbContext()
        //{
        //    //DbContextLoggerFactory = new LoggerFactory();
        //    //DbContextLoggerFactory.AddConsole();
        //    //DbContextLoggerFactory.AddNLog();
        //}

        public EduExDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<UserRole> UserRoles { get; set; }

        public virtual DbSet<TeacherInfo> TeacherInfos { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Lection> Lections { get; set; }

        public virtual DbSet<StudentInfo> StudentInfos { get; set; }

        public virtual DbSet<Attachment> Attachments { get; set; }

        public virtual DbSet<CourseRole> CourseRoles { get; set; }

        public virtual DbSet<Module> Modules { get; set; }

        public virtual DbSet<StudentCourse> StudentCourses { get; set; }

        public virtual DbSet<Task> Tasks { get; set; }

        public virtual DbSet<TeacherCourse> TeacherCourses { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer("Server=(local);Initial Catalog=EDUEX;Trusted_Connection=True;MultipleActiveResultSets=true");
            //options.UseLoggerFactory(DbContextLoggerFactory);
            //options.EnableSensitiveDataLogging(true);
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            var seeder = new Seeder();
            seeder.Seed(modelBuilder);
        }
    }

}
