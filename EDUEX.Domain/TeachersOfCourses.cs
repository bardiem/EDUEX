using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUEX.Domain
{
    public class TeachersOfCourses
    {
        [Key]
        public int Id { get; set; }
        public Courses Course { get; set; }
        public int CourseId { get; set; }
        public Teachers Teacher { get; set; }
        public int TeacherId { get; set; }
        public CourseRoles TeacherRole { get; set; }
        public int TeacherRoleId { get; set; }
    }
}
