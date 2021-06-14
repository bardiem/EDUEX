using System.ComponentModel.DataAnnotations;
using System;

namespace EDUEX.Domain
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

    }
}
