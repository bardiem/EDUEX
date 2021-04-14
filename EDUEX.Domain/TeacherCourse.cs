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
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public CourseRole TeacherRole { get; set; }
        public int TeacherRoleId { get; set; }
    }
}
