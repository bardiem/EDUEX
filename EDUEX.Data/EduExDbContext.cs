using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using EDUEX.Domain;

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

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

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
