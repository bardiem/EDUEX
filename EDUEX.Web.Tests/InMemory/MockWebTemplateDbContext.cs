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

        public DbSet<Webinar> Webinars { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<UserWebinar> UserWebinars { get; set; }



        public MockWebTemplateDbContext(DbContextOptions options) : base(options)
        {
            Seeder.Seed(this);
        }
    }
}
