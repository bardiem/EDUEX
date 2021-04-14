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
        public string Description { get; set; }
        public Lection Lection { get; set; }
        public int LectionId { get; set; }
    }
}
