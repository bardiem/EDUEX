using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Lection
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Subject { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public Module Module { get; set; }
        public int ModuleId { get; set; }
    }
}
