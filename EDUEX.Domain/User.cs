using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required]
        //[EmailAddress]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        //[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")]
        [MaxLength(150)]
        public string Password { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        [Required]
        [MaxLength(150)]
        public string Position { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<UserCourses> UserCourses { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {Email} {BirthDate.ToShortDateString()} {Position}";
        }
    }
}
