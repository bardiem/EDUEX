using EDUEX.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDUEX.Domain
{
    public class Webinar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Subject { get; set; }

        public DateTime EnrollDeadline { get; set; }

        public CourseDifficultyLevelEnum Level { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        public ICollection<UserWebinar> UserWebinars { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}
