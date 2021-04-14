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

        public ICollection<UserRole> UserRoles { get; set; }

        public StudentInfo StudentInfo { get; set; }

        public int? StudentInfoId { get; set; }

        public TeacherInfo TeacherInfo { get; set; }

        public int? TeacherInfoId { get; set; }

        [NotMapped]
        public bool IsStudent
        {
            get
            {
                return StudentInfo != null;
            }
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Email}";
        }
    }
}
