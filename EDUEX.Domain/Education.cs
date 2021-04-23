using EDUEX.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Education
    {
        [Key]
        public int Id { get; set; }

        public EducationLevelEnum Level { get; set; }

        [Required]
        [MaxLength(300)]
        public string Institution { get; set; }

        [Required]
        [MaxLength(100)]
        public string Faculty { get; set; }

        [Required]
        [MaxLength(100)]
        public string Specialty { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }
    }
}
