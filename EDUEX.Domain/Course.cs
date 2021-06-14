using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [MaxLength(500)]
        public string Description { get; set; }

        public int SubjectId { get; set; }

        public Subject Subject { get; set; }

        [Required]
        [MaxLength(100)]
        public string Topic { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }

        public ICollection<Task> Tasks { get; set; }

        public ICollection<Lection> Lections { get; set; }
    }
}

