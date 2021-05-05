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

        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [MaxLength(150)]
        public string Password { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

        [Required]
        [MaxLength(150)]
        public string Position { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Balance { get; set; }

        public ICollection<UserWebinar> UserWebinars { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {Email} {BirthDate.ToShortDateString()} {Position}";
        }
    }
}
