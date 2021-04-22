using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime MyProperty { get; set; }
        public User Author { get; set; }
        public int AuthorId { get; set; }
        public virtual ICollection<LectionComments> LectionComments { get; set; }
        public virtual ICollection<TaskComments> TaskComments { get; set; }
    }
}
