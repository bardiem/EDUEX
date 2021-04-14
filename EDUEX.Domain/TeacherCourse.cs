using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUEX.Domain
{
    public class TeacherCourse
    {
        [Key]
        public int Id { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public CourseRole TeacherRole { get; set; }
        public int TeacherRoleId { get; set; }
    }
}
