using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }

        [Range(0, 100)]
        public int Value { get; set; }

        public int AuthorId { get; set; }

        public User Author { get; set; }

        [Required]
        [MaxLength(300)]
        public string Explanation { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

    }
}
