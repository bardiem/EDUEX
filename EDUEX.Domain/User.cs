using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(150)]
        public string Password { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Email}";
        }
    }
}
