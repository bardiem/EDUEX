using Microsoft.EntityFrameworkCore;
using System;
using EDUEX.Domain;

namespace EDUEX.Data
{
    public interface IWebTemplateDbContext : IDisposable
    {
        DbSet<User> Users { get; set; }

        DbSet<Role> Roles { get; set; }

        DbSet<UserRole> UserRoles { get; set; }

        int SaveChanges();
    }
}
