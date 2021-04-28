using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class TaskComments
    {
        [Key]
        public int Id { get; set; }

        public int TaskId { get; set; }

        public Task Task { get; set; }

        public int CommentId { get; set; }

        public Comment Comment { get; set; }
    }
}
