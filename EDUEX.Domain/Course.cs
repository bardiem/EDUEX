using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EDUEX.Domain.Enums;

namespace EDUEX.Domain
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string ShortDescription { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Subject { get; set; }

        [Required]
        [MaxLength(100)]
        public string Topic { get; set; }

        public CourseDifficultyLevelEnum Level { get; set; }

        public DateTime StartDate { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        public ICollection<Module> Modules { get; set; }

        public ICollection<UserCourses> UserCourses { get; set; }
    }
}
