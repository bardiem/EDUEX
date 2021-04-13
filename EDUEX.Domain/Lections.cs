using System.ComponentModel.DataAnnotations;

namespace EDUEX.Domain
{
    public class Lections
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Subject { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public Modules Module { get; set; }
        public int ModuleId { get; set; }
    }
}
