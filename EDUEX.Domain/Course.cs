using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EDUEX.Domain
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string Topic { get; set; }
        public string Level { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<Module> Modules { get; set; }
        public ICollection<UserCourses> UserCourses { get; set; }
    }
}
