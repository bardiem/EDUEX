using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class TaskAttachments
    {
        [Key]
        public int Id { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }

        public int AttachmentId { get; set; }

        public Attachment Attachment { get; set; }

        public bool IsAdditionToAnswer { get; set; }
    }
}
