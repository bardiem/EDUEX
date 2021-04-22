using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public int CommentId { get; set; }
        public string Explanation { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

    }
}
