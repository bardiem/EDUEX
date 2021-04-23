using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class LectionAttachments
    {
        [Key]
        public int Id { get; set; }

        public int LectionId { get; set; }

        public Lection Lection { get; set; }

        public int AttachmentId { get; set; }

        public Attachment Attachment { get; set; }
    }
}
