using EDUEX.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDUEX.Web.Dto
{
    public class SubjectReviewDto
    {
        public class Subject
        {
            [Range(1, int.MaxValue)]
            public int Id { get; set; }

            [Required]
            [MaxLength(50)]
            public string Name { get; set; }

            [Required]
            [MaxLength(100)]
            public string Area { get; set; }
        }
    }
}
