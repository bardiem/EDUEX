using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string TaskDescription { get; set; }
        public string Solution { get; set; }
        public Mark Mark { get; set; }
        public int MarkId { get; set; }
        public Attachment Attachment { get; set; }
        public int AttachmentId { get; set; }
        public virtual ICollection<TaskComments> TaskComments { get; set; }
        public virtual ICollection<ModuleTasks> ModuleTasks { get; set; }
        public virtual ICollection<TaskAttachments> TaskAttachments { get; set; }
    }
}
