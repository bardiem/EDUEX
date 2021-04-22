using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUEX.Domain
{
    public class UserCourses
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public DateTime StartPartticipationDate { get; set; }
        public DateTime EndPartticipationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
