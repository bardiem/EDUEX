using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class LectionComments
    {
        [Key]
        public int Id { get; set; }
        public int LectionId { get; set; }
        public Lection Lection { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
