using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public string Position { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<UserCourses> UserCourses { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Email} {BirthDate.ToShortDateString()} {Position}";
        }
    }
}
