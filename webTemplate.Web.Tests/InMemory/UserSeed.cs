using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDUEX.Domain;

namespace EDUEX.Web.Tests.InMemory
{
    public class UserSeed : Seed<User>
    {
        public override List<User> Init()
        {
            return new List<User>()
            {
                new User() {Id = 1, Name = "Admin", Email = "admin@example.com", Password = "simple" },
                new User() {Id = 2, Name = "UserName", Email = "user@example.com", Password = "simple" },
            };
        }
    }
}
