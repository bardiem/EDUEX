﻿using Microsoft.EntityFrameworkCore;
using System;
using EDUEX.Domain;

namespace EDUEX.Data
{
    public interface IEduExDbContext : IDisposable
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Webinar> Webinars { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<UserWebinars> UserWebinars { get; set; }


        int SaveChanges();
    }
}
