using Microsoft.EntityFrameworkCore;
using EDUEX.Domain;

namespace EDUEX.Data
{
    public class Seeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 1,
                Code = "admin",
                Name = "Administrator"
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 2,
                Code = "user",
                Name = "Regular User"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                FirstName = "Administrator",
                LastName = "Adm",
                Email = "admin@webtemplate.net",
                Password = "123456",
                Position = "Position1"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                FirstName = "Regular User",
                LastName = "Adm",
                Email = "user@webtemplate.net",
                Password = "123456",
                Position = "Position2"
            });

            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                Id = 1,
                RoleId = 1,
                UserId = 1
            });
            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                Id = 2,
                RoleId = 2,
                UserId = 2
            });
        }
    }
}
