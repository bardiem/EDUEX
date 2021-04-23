using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Attachment
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Path { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<LectionAttachments> LectionAttachments { get; set; }

        public virtual ICollection<TaskAttachments> TaskAttachments { get; set; }
    }
}