using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUEX.Domain
{
    public class StudentsOfCourses
    {
        [Key]
        public int Id { get; set; }
        public Students Student { get; set; }
        public int StudentId { get; set; }
        public Courses Course { get; set; }
        public int CourseId { get; set; }

    }
}
