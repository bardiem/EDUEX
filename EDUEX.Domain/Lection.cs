using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Lection
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string Topic { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Text { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }


    }
}
