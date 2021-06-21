using EDUEX.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDUEX.Web.Dto
{
    public class WebinarReviewDto
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        public DateTime EnrollDeadline { get; set; }

        [Required]
        public int SubjectId { get; set; }

        public CourseDifficultyLevelEnum Level { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

    }
}
