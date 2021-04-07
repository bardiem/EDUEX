using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUEX.Data;
using EDUEX.Domain;

namespace EDUEX.Web.Tests.InMemory
{
    public class MockWebTemplateDbContext : DbContext, IWebTemplateDbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Domain.Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public MockWebTemplateDbContext(DbContextOptions options) : base(options)
        {
            Seeder.Seed(this);
        }
    }
}
